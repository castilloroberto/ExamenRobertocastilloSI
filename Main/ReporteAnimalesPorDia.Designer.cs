
namespace Main
{
    partial class ReporteAnimalesPorDia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VeterinariaDataSet = new Main.VeterinariaDataSet();
            this.sp_verFichaAnimalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_verFichaAnimalesTableAdapter = new Main.VeterinariaDataSetTableAdapters.sp_verFichaAnimalesTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VeterinariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_verFichaAnimalesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "verAnimales";
            reportDataSource2.Value = this.sp_verFichaAnimalesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Main.AnimalesPordia.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 159);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1204, 500);
            this.reportViewer1.TabIndex = 0;
            // 
            // VeterinariaDataSet
            // 
            this.VeterinariaDataSet.DataSetName = "VeterinariaDataSet";
            this.VeterinariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_verFichaAnimalesBindingSource
            // 
            this.sp_verFichaAnimalesBindingSource.DataMember = "sp_verFichaAnimales";
            this.sp_verFichaAnimalesBindingSource.DataSource = this.VeterinariaDataSet;
            // 
            // sp_verFichaAnimalesTableAdapter
            // 
            this.sp_verFichaAnimalesTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado",
            "Domingo"});
            this.comboBox1.Location = new System.Drawing.Point(43, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(258, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dia";
            // 
            // ReporteAnimalesPorDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 652);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteAnimalesPorDia";
            this.Text = "ReporteAnimalesPorDia";
            this.Load += new System.EventHandler(this.ReporteAnimalesPorDia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VeterinariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_verFichaAnimalesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_verFichaAnimalesBindingSource;
        private VeterinariaDataSet VeterinariaDataSet;
        private VeterinariaDataSetTableAdapters.sp_verFichaAnimalesTableAdapter sp_verFichaAnimalesTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}