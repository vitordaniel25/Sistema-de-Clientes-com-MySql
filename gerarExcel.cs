using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasDeClientes
{
    class GerarExcel
    {

        Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
        public void gerarExcel(DataGridView dgvDados)
        {
            if (dgvDados.Rows.Count > 0)
            {
                try
                {
                    XcelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < dgvDados.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = dgvDados.Columns[i - 1].HeaderText;
                    }
                    //
                    for (int i = 0; i < dgvDados.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dgvDados.Columns.Count; j++)
                        {
                            XcelApp.Cells[i + 2, j + 1] = dgvDados.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    //
                    XcelApp.Columns.AutoFit();
                    //

                    XcelApp.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                    XcelApp.Quit();
                }
            }
        }
    }
}
