using ClosedXML.Excel;

var xls = new XLWorkbook(@"C:\Nova pasta\testeReader.xlsx"); // coloque o caminho do arquivo a ser lido
var planilha = xls.Worksheets.First();
var totalLinhas = planilha.Rows().Count();
var totalCol = planilha.Columns().Count();

for (int l = 1; l < totalLinhas; l++)
{
    for (int t = 1; t < totalCol; t++)
    {
        var linha = planilha.Row(l).Cell(t).Value.ToString();
        Console.Write(linha + " ");
    }
    Console.WriteLine();
}