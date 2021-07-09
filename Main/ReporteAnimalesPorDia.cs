using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class ReporteAnimalesPorDia : Form
    {
        public ReporteAnimalesPorDia()
        {
            InitializeComponent();
        }

        private void ReporteAnimalesPorDia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'VeterinariaDataSet.sp_verFichaAnimales' Puede moverla o quitarla según sea necesario.
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string index = (comboBox1.SelectedIndex + 2).ToString();
            this.sp_verFichaAnimalesTableAdapter.Fill(this.VeterinariaDataSet.sp_verFichaAnimales,index);

            this.reportViewer1.RefreshReport();
        }
    }
}
    