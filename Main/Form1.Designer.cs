
namespace Main
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_cargarFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.btn_enviar_a_db = new System.Windows.Forms.Button();
            this.txt_filename = new System.Windows.Forms.TextBox();
            this.cb_hojas = new System.Windows.Forms.ComboBox();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cargarFile
            // 
            this.btn_cargarFile.Location = new System.Drawing.Point(100, 206);
            this.btn_cargarFile.Name = "btn_cargarFile";
            this.btn_cargarFile.Size = new System.Drawing.Size(203, 41);
            this.btn_cargarFile.TabIndex = 0;
            this.btn_cargarFile.Text = "Buscar Archivo";
            this.btn_cargarFile.UseVisualStyleBackColor = true;
            this.btn_cargarFile.Click += new System.EventHandler(this.btn_cargarFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(396, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Importar datos";
            // 
            // dgv_datos
            // 
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Location = new System.Drawing.Point(100, 266);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.RowHeadersWidth = 51;
            this.dgv_datos.RowTemplate.Height = 24;
            this.dgv_datos.Size = new System.Drawing.Size(954, 284);
            this.dgv_datos.TabIndex = 2;
            // 
            // btn_enviar_a_db
            // 
            this.btn_enviar_a_db.Location = new System.Drawing.Point(851, 206);
            this.btn_enviar_a_db.Name = "btn_enviar_a_db";
            this.btn_enviar_a_db.Size = new System.Drawing.Size(203, 41);
            this.btn_enviar_a_db.TabIndex = 0;
            this.btn_enviar_a_db.Text = "Guardar En DB";
            this.btn_enviar_a_db.UseVisualStyleBackColor = true;
            this.btn_enviar_a_db.Click += new System.EventHandler(this.btn_enviar_a_db_Click);
            // 
            // txt_filename
            // 
            this.txt_filename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_filename.Location = new System.Drawing.Point(321, 217);
            this.txt_filename.Name = "txt_filename";
            this.txt_filename.ReadOnly = true;
            this.txt_filename.Size = new System.Drawing.Size(507, 30);
            this.txt_filename.TabIndex = 3;
            // 
            // cb_hojas
            // 
            this.cb_hojas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_hojas.FormattingEnabled = true;
            this.cb_hojas.Location = new System.Drawing.Point(100, 557);
            this.cb_hojas.Name = "cb_hojas";
            this.cb_hojas.Size = new System.Drawing.Size(297, 33);
            this.cb_hojas.TabIndex = 4;
            this.cb_hojas.SelectedIndexChanged += new System.EventHandler(this.cb_hojas_SelectedIndexChanged);
            // 
            // btn_reporte
            // 
            this.btn_reporte.Location = new System.Drawing.Point(918, 44);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(203, 41);
            this.btn_reporte.TabIndex = 0;
            this.btn_reporte.Text = "ReporteAnimales";
            this.btn_reporte.UseVisualStyleBackColor = true;
            this.btn_reporte.Click += new System.EventHandler(this.btn_reporte_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 567);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pagina";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 649);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_hojas);
            this.Controls.Add(this.txt_filename);
            this.Controls.Add(this.dgv_datos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_enviar_a_db);
            this.Controls.Add(this.btn_reporte);
            this.Controls.Add(this.btn_cargarFile);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cargarFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_datos;
        private System.Windows.Forms.Button btn_enviar_a_db;
        private System.Windows.Forms.TextBox txt_filename;
        private System.Windows.Forms.ComboBox cb_hojas;
        private System.Windows.Forms.Button btn_reporte;
        private System.Windows.Forms.Label label2;
    }
}

