using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;

namespace SistemasDeClientes
{
    class gerarPDF
    {
        public void gerar(DataGridView grid)
        {
            {/*
            Document doc = new Document(PageSize.A4);//criando e estipulando o tipo da folha usada
            doc.SetMargins(40, 40, 40, 80);//estibulando o espaçamento das margens que queremos
            doc.AddCreationDate();//adicionando as configuracoes

            //caminho onde sera criado o pdf + nome desejado
            //OBS: o nome sempre deve ser terminado com .pdf
            string caminho = @"D:\" + "CONTRATO.pdf";

            //criando o arquivo pdf embranco, passando como parametro a variavel
            //doc criada acima e a variavel caminho
            //tambem criada acima.
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));
            doc.Open();

            //criando uma string vazia
            string dados = "";

            //criando a variavel para paragrafo
            Paragraph paragrafo = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12));
            Paragraph titulo = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 16));
            //etipulando o alinhamneto
            paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
            titulo.Alignment = Element.ALIGN_CENTER;
            //Alinhamento Justificado
            //adicioando texto
            titulo.Add("Clientes");
            paragrafo.Add();
            //acidionado paragrafo ao documento
            doc.Add(titulo);
            doc.Add(paragrafo);
            //fechando documento para que seja salva as alteraçoes.
            doc.Close();
            */
            }

            { //Creating iTextSharp Table from the DataTable data
                PdfPTable pdfTable = new PdfPTable(grid.ColumnCount);
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 100;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfTable.DefaultCell.BorderWidth = 1;

                //Adding Header row
                foreach (DataGridViewColumn column in grid.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    pdfTable.AddCell(cell);

                }
                //Adding DataRow

                foreach (DataGridViewRow row in grid.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        try
                        {
                            pdfTable.AddCell(cell.Value.ToString());
                        }
                        catch
                        {

                        }
                    }
                }

                //Exporting to PDF
                string folderPath = "C:\\PDFs\\";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                using (FileStream stream = new FileStream(folderPath + "DataGridViewExport.pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();

                }
            }
        }

    }
}

