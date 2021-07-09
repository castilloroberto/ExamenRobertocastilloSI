using ExcelDataReader;
using Main.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Form1 : Form
    {
        DataTableCollection tableCollection;
        DataTable dataTable;
        Consultas consultas = new Consultas();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cargarFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            //{
            //    Filter = "Excel | *.xls | Excel Workbook | *.xlsx"
            //};
            var res = openFile.ShowDialog();

            if (res == DialogResult.OK)
            {
                txt_filename.Text = openFile.FileName;

                var stream = File.Open(openFile.FileName,FileMode.Open,FileAccess.Read);

                IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream);



                DataSet resultado = reader.AsDataSet(new ExcelDataSetConfiguration() {

                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration { UseHeaderRow = true }
                }) ;

                tableCollection = resultado.Tables;
                cb_hojas.Items.Clear();
                dataTable = tableCollection[0];
                dgv_datos.DataSource = dataTable;
                foreach (DataTable table in tableCollection)
                {

                    cb_hojas.Items.Add(table.TableName);

                }
                
                

            }

        }

        private void cb_hojas_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataTable = tableCollection[cb_hojas.SelectedItem.ToString()];
            dgv_datos.DataSource = dataTable;
        }

        private void btn_reporte_Click(object sender, EventArgs e)
        {
            var reporte = new ReporteAnimalesPorDia();
            reporte.Show();
        }

        private void btn_enviar_a_db_Click(object sender, EventArgs e)
        {


            var lista = dataTable.AsEnumerable();
            foreach (var item in lista)
            {
                consultas.InsertDatos(
                    item.Field<string>("NombreAnimal"),
                    item.Field<string>("AmoAnimal"),
                    item.Field<string>("RazaAnimal"),
                    item.Field<string>("ColorAnimal"),
                    item.Field<string>("PesoAnimal"),
                    item.Field<DateTime>("FechaNacimiento")
                    );
            }
            MessageBox.Show("Datos Guardados con Exito", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }
    }
}
