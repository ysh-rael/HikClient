using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;

namespace HikBRAClient
{
    using HikClient.Event;
    using HikClient.Utils;
    using System.Xml;

    public partial class app : Form
    {
        private Utils.TextBoxWriter _textBoxWriter;
        public int QuantErr = 0;
        public int QuantImportSucess = 0;
        public int QuantImportErr = 0;
        public int CountUser = 0;
        public app()
        {
            InitializeComponent();
            SelectProtocoll.SelectedValue = 0;

            _textBoxWriter = new Utils.TextBoxWriter(BoxConsole);
            Console.SetOut(_textBoxWriter);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BoxAjuda_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListarTitulosDasColunas(string filePath, ComboBox select)
        {
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Selecione a planilha apropriada

                int colCount = worksheet.Dimension.Columns;

                // Limpe os itens anteriores, se houver
                select.Items.Clear();
                select.Items.Add("SELECIONE");


                // Adicione os títulos das colunas ao ComboBox
                for (int col = 1; col <= colCount; col++)
                {
                    var columnHeader = worksheet.Cells[1, col].Value?.ToString();
                    if (!string.IsNullOrEmpty(columnHeader))
                    {
                        select.Items.Add(columnHeader);
                    }
                }
            }
        }

        private void bttnImport_Click(object sender, EventArgs e)
        {
            openFileDialog_escolheArquivo.Filter = "Arquivos Excel|*.xlsx;*.xls";
            openFileDialog_escolheArquivo.Title = "Escolha um arquivo Excel";

            if (openFileDialog_escolheArquivo.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog_escolheArquivo.FileName;
                inputPathFile.Text = filePath;
                // Aqui você pode usar o caminho do arquivo (filePath) para processar o arquivo Excel conforme necessário.
                // Configure a propriedade LicenseContext
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // ou LicenseContext.Commercial se você tiver uma licença comercial

                try
                {
                    ListarTitulosDasColunas(filePath, SelectId);
                    ListarTitulosDasColunas(filePath, SelectNome);

                    ListarTitulosDasColunas(filePath, SelectCard);
                    ListarTitulosDasColunas(filePath, SelectType);
                    ListarTitulosDasColunas(filePath, SelectTemplete);

                } catch (Exception ex)
                {
                    MessageBox.Show("Erro ao capturar os campos da base de dados.");
                    QuantErr++;
                    LabelQuantErr.Text = QuantErr.ToString();
                    sugestSolution.Text += "# Verificar arquivo utilizado como Base de dados." + Environment.NewLine;
                    Console.WriteLine(ex);
                }


            }
        }

        private string GetValComboBox(ComboBox Combo)
        {
            // Verifique se há um item selecionado no ComboBox
            return Combo.SelectedItem != null ? Combo.SelectedItem.ToString() : "";

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bttnInit_Click(object sender, EventArgs e)
        {
            BoxConsole.Text = string.Empty;

            Device Dispositivo = new Device();

            try
            {
                Dispositivo.struDeviceInfo.strUsername = InputUser.Text;
                Dispositivo.struDeviceInfo.strPassword = InputPass.Text;
                Dispositivo.struDeviceInfo.strDeviceIP = InputHost.Text;
                Dispositivo.struDeviceInfo.strHttpPort = NumericPort.Value.ToString();

                Dispositivo.Login();
            }
            catch (Exception ex)
            {
                QuantErr++;
                LabelQuantErr.Text = QuantErr.ToString();
                Console.WriteLine(ex);
                sugestSolution.Text += "# Verificar autenticação do leitor: host, porta, user e pass." + Environment.NewLine;
            }


            try
            {
                // Get valores campo
                string TestId    = GetValComboBox(SelectId);
                string TestNome  = GetValComboBox(SelectNome);
                string TestCard  = GetValComboBox(SelectCard);
                string TestType  = GetValComboBox(SelectType);
                string TestTemplete  = GetValComboBox(SelectTemplete);

                // Base de dados
                string filePath = openFileDialog_escolheArquivo.FileName;
                List<Dictionary<string, object>> dados = Utils.LerDadosDaPlanilha(filePath);

                // Contador

                int QuantImport = dados.Count == 0 ? 0 : dados.Count - 1;




                Progress.Value = 0;
                sugestSolution.Text = string.Empty;

                if (QuantErr == 0)
                    foreach (var linha in dados)
                    {
                        string Id = "";
                        string Nome = "";
                        string UserType = "normal";
                        string Templete = "1";
                        foreach (var chaveValor in linha)
                        {
                            try
                            {
                                string Column = chaveValor.Key;
                                object Value = chaveValor.Value;

                                if (Column == TestId) Id = Value.ToString();
                                if (Column == TestNome) Nome = Value.ToString();
                                if (Column == UserType) UserType = Value.ToString();
                                if (Column == TestTemplete) Templete = Value.ToString();
                            }
                            catch (Exception ex)
                            {
                                QuantImportErr++;
                                QuantErr++;
                                LabelQuantErr.Text = QuantErr.ToString();
                                sugestSolution.Text += "# Verificar Valores em 'Compos a serem preenchidos'." + Environment.NewLine;
                                sugestSolution.Text += "# Verificar na planilha se algum usuário está um valor nulo no campo selecionado ou com valor inválido." + Environment.NewLine;
                                Console.WriteLine($"ERR - Não foi possível obter o conteudo das colunas. EXeption: {ex}");
                                continue;
                            }

                        }

                        bool Usuario = UserManagement.Set(Dispositivo, Id, Nome, "normal", "1");
                        CountUser++;

                        if (Usuario)
                        {
                            QuantImportSucess++;
                            LabelQuantImportSucess.Text = QuantImportSucess.ToString();


                            Console.WriteLine($"# Usuário importado: ID: {Id} | Nome: {Nome}");
                        }
                        else
                        {
                            QuantErr++;
                            QuantImportErr++;
                            LabelQuantErr.Text = QuantErr.ToString();
                            LabelQuantImportErr.Text = QuantImportErr.ToString();

                            Console.WriteLine($"Erro ao importar User: ID: {Id} | Nome: {Nome}");
                        }
                        float porcentUserCreated = (CountUser / QuantImport) * 100.0f;
                        Progress.Value = (int)porcentUserCreated;
                    }



                LabelPorcSuccess.Text = (100 - (QuantImportErr / QuantImport) * 100.0f).ToString() + "%";
                float porcentConclued = (CountUser / QuantImport) * 100.0f;
                Progress.Value = (int)porcentConclued;
            } catch (Exception ex)
            {
                QuantErr++;
                LabelQuantErr.Text = QuantErr.ToString();
                sugestSolution.Text += "# Verificar Caminho para base de dados e campos a serem preenchidos. (Esse é um tratamento de erro genérico. O erro pode ter ocorrido ao capturar os dados ou ler a resposta da importação do usuário.)" + Environment.NewLine;
                Console.WriteLine(ex);
            }

            MessageBox.Show(QuantErr == 0 ? "Finalizado!" : "Finalizado com erros!");

            Progress.Value = 100;





        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelQuantErr_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
