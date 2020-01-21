namespace Calcular_nota
{
    partial class frmConsultarPessoas
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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dbSalatiel1DataSet = new Calcular_nota.dbSalatiel1DataSet();
            this.dbSalatiel1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtPessoas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dbSalatiel1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSalatiel1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPessoas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(12, 246);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dbSalatiel1DataSet
            // 
            this.dbSalatiel1DataSet.DataSetName = "dbSalatiel1DataSet";
            this.dbSalatiel1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbSalatiel1DataSetBindingSource
            // 
            this.dbSalatiel1DataSetBindingSource.DataSource = this.dbSalatiel1DataSet;
            this.dbSalatiel1DataSetBindingSource.Position = 0;
            // 
            // dtPessoas
            // 
            this.dtPessoas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtPessoas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dtPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPessoas.Location = new System.Drawing.Point(12, 12);
            this.dtPessoas.Name = "dtPessoas";
            this.dtPessoas.Size = new System.Drawing.Size(413, 212);
            this.dtPessoas.TabIndex = 1;
            // 
            // frmConsultarPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 299);
            this.Controls.Add(this.dtPessoas);
            this.Controls.Add(this.btnConsultar);
            this.Name = "frmConsultarPessoas";
            this.Text = "frmConsultarPessoas";
            ((System.ComponentModel.ISupportInitialize)(this.dbSalatiel1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSalatiel1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPessoas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private dbSalatiel1DataSet dbSalatiel1DataSet;
        private System.Windows.Forms.BindingSource dbSalatiel1DataSetBindingSource;
        private System.Windows.Forms.DataGridView dtPessoas;
    }
}