using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using System.Windows.Forms;

namespace HikClient.Utils
{
    internal static class Utils
    {
        public class User
        {
            public string EnployeeNo { get; set; }
            public string Name { get; set; }
            public string UserType { get; set; }
            public string PlanTamplete { get; set; }
            public FaceId FaceId { get; set; }
            public Card Card { get; set; }
        }

        public class FaceId
        {
            public string Id { get; set; }
            public string PathFile { get; set; }
        }

        public class Card
        {
            public string Number { get; set; }
            public string Type { get; set; }
        }

        public class RootObject
        {
            public string typy { get; set; }
            public User User { get; set; }
        }

        public static List<RootObject> Request(string content)
        {
            return JsonConvert.DeserializeObject<List<RootObject>>(content);
        }

        public static string Dirname() { return Directory.GetCurrentDirectory(); }
        public static string Response(int code, string msg, string nameFile = "", string protocolo = "", string idNF = "")
        {
            return $" {'{'} \"xStat\": {code}, \"xMotivo\": \"{msg}\", \"nameFile\": \"{nameFile}\", \"protocolo\": \"{protocolo}\", \"idNF\": \"{idNF}\"  {'}'} ";
        }

        public static List<Dictionary<string, object>> LerDadosDaPlanilha(string filePath)
        {
            List<Dictionary<string, object>> dados = new List<Dictionary<string, object>>();

            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Selecione a planilha apropriada

                int rowCount = worksheet.Dimension.Rows;
                int colCount = worksheet.Dimension.Columns;

                for (int row = 2; row <= rowCount; row++) // Comece da segunda linha, assumindo que a primeira linha é a cabeçalho
                {
                    Dictionary<string, object> linha = new Dictionary<string, object>();

                    for (int col = 1; col <= colCount; col++)
                    {
                        var columnHeader = worksheet.Cells[1, col].Value?.ToString();
                        var cellValue = worksheet.Cells[row, col].Value;

                        // Use a coluna como chave e o valor da célula como valor no dicionário
                        linha[columnHeader] = cellValue ?? "";
                    }

                    dados.Add(linha);
                }
            }

            return dados;
        }



        public class TextBoxWriter : TextWriter
        {
            private TextBox _textBox;

            public TextBoxWriter(TextBox textBox)
            {
                _textBox = textBox;
            }

            public override void Write(char value)
            {
                _textBox.AppendText(value.ToString());
            }

            public override void Write(string value)
            {
                _textBox.AppendText(value);
            }

            public override void WriteLine(string value)
            {
                _textBox.AppendText(value + Environment.NewLine);
            }

            public override Encoding Encoding
            {
                get { return Encoding.Default; }
            }
        }


    }
}
