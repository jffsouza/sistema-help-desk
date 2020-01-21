namespace help_desk
{
    partial class frmChamados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtProtocolo = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.dgvAberto = new System.Windows.Forms.DataGridView();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnNovoChamado = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAberto = new System.Windows.Forms.TabPage();
            this.lblAvisoAberto = new System.Windows.Forms.Label();
            this.tabFechado = new System.Windows.Forms.TabPage();
            this.lblAvisoFechado = new System.Windows.Forms.Label();
            this.dgvFechado = new System.Windows.Forms.DataGridView();
            this.btnAtualizar = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAberto)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabAberto.SuspendLayout();
            this.tabFechado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFechado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtualizar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(158)))), ((int)(((byte)(253)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(707, 45);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(181, 36);
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblAviso);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.txtProtocolo);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 96);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(100, 70);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(218, 20);
            this.lblAviso.TabIndex = 17;
            this.lblAviso.Text = "* Nenhum registro encontrado !";
            this.lblAviso.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Black;
            this.lblID.Location = new System.Drawing.Point(18, 41);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(80, 21);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "Protocolo:";
            // 
            // txtProtocolo
            // 
            this.txtProtocolo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProtocolo.BackColor = System.Drawing.Color.White;
            this.txtProtocolo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProtocolo.ForeColor = System.Drawing.Color.DimGray;
            this.txtProtocolo.Location = new System.Drawing.Point(104, 35);
            this.txtProtocolo.Name = "txtProtocolo";
            this.txtProtocolo.Size = new System.Drawing.Size(569, 33);
            this.txtProtocolo.TabIndex = 10;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(158)))), ((int)(((byte)(253)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(751, 474);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(137, 36);
            this.btnSair.TabIndex = 20;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dgvAberto
            // 
            this.dgvAberto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAberto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAberto.BackgroundColor = System.Drawing.Color.White;
            this.dgvAberto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAberto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAberto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAberto.ColumnHeadersHeight = 30;
            this.dgvAberto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAberto.EnableHeadersVisualStyles = false;
            this.dgvAberto.Location = new System.Drawing.Point(6, 6);
            this.dgvAberto.Name = "dgvAberto";
            this.dgvAberto.RowHeadersVisible = false;
            this.dgvAberto.RowHeadersWidth = 20;
            this.dgvAberto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAberto.Size = new System.Drawing.Size(856, 304);
            this.dgvAberto.TabIndex = 17;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVisualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btnVisualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVisualizar.FlatAppearance.BorderSize = 0;
            this.btnVisualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(158)))), ((int)(((byte)(253)))));
            this.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.ForeColor = System.Drawing.Color.White;
            this.btnVisualizar.Location = new System.Drawing.Point(199, 474);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(181, 36);
            this.btnVisualizar.TabIndex = 24;
            this.btnVisualizar.Text = "Visualizar Chamado";
            this.btnVisualizar.UseVisualStyleBackColor = false;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnNovoChamado
            // 
            this.btnNovoChamado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNovoChamado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(158)))), ((int)(((byte)(253)))));
            this.btnNovoChamado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNovoChamado.FlatAppearance.BorderSize = 0;
            this.btnNovoChamado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btnNovoChamado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoChamado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoChamado.ForeColor = System.Drawing.Color.White;
            this.btnNovoChamado.Location = new System.Drawing.Point(12, 474);
            this.btnNovoChamado.Name = "btnNovoChamado";
            this.btnNovoChamado.Size = new System.Drawing.Size(181, 36);
            this.btnNovoChamado.TabIndex = 25;
            this.btnNovoChamado.Text = "Novo Chamado";
            this.btnNovoChamado.UseVisualStyleBackColor = false;
            this.btnNovoChamado.Click += new System.EventHandler(this.btnNovoChamado_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabAberto);
            this.tabControl.Controls.Add(this.tabFechado);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(12, 114);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(876, 350);
            this.tabControl.TabIndex = 26;
            // 
            // tabAberto
            // 
            this.tabAberto.Controls.Add(this.lblAvisoAberto);
            this.tabAberto.Controls.Add(this.dgvAberto);
            this.tabAberto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAberto.Location = new System.Drawing.Point(4, 30);
            this.tabAberto.Name = "tabAberto";
            this.tabAberto.Padding = new System.Windows.Forms.Padding(3);
            this.tabAberto.Size = new System.Drawing.Size(868, 316);
            this.tabAberto.TabIndex = 0;
            this.tabAberto.Text = "Abertos";
            this.tabAberto.UseVisualStyleBackColor = true;
            // 
            // lblAvisoAberto
            // 
            this.lblAvisoAberto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblAvisoAberto.AutoSize = true;
            this.lblAvisoAberto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoAberto.ForeColor = System.Drawing.Color.Red;
            this.lblAvisoAberto.Location = new System.Drawing.Point(299, 271);
            this.lblAvisoAberto.Name = "lblAvisoAberto";
            this.lblAvisoAberto.Size = new System.Drawing.Size(271, 20);
            this.lblAvisoAberto.TabIndex = 18;
            this.lblAvisoAberto.Text = "* Não existe chamados para a exibição!";
            this.lblAvisoAberto.Visible = false;
            // 
            // tabFechado
            // 
            this.tabFechado.Controls.Add(this.lblAvisoFechado);
            this.tabFechado.Controls.Add(this.dgvFechado);
            this.tabFechado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabFechado.Location = new System.Drawing.Point(4, 30);
            this.tabFechado.Name = "tabFechado";
            this.tabFechado.Padding = new System.Windows.Forms.Padding(3);
            this.tabFechado.Size = new System.Drawing.Size(868, 316);
            this.tabFechado.TabIndex = 1;
            this.tabFechado.Text = "Finalizados";
            this.tabFechado.UseVisualStyleBackColor = true;
            // 
            // lblAvisoFechado
            // 
            this.lblAvisoFechado.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblAvisoFechado.AutoSize = true;
            this.lblAvisoFechado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoFechado.ForeColor = System.Drawing.Color.Red;
            this.lblAvisoFechado.Location = new System.Drawing.Point(299, 271);
            this.lblAvisoFechado.Name = "lblAvisoFechado";
            this.lblAvisoFechado.Size = new System.Drawing.Size(271, 20);
            this.lblAvisoFechado.TabIndex = 19;
            this.lblAvisoFechado.Text = "* Não existe chamados para a exibição!";
            this.lblAvisoFechado.Visible = false;
            // 
            // dgvFechado
            // 
            this.dgvFechado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFechado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFechado.BackgroundColor = System.Drawing.Color.White;
            this.dgvFechado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvFechado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFechado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFechado.ColumnHeadersHeight = 30;
            this.dgvFechado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFechado.EnableHeadersVisualStyles = false;
            this.dgvFechado.Location = new System.Drawing.Point(6, 6);
            this.dgvFechado.Name = "dgvFechado";
            this.dgvFechado.RowHeadersVisible = false;
            this.dgvFechado.RowHeadersWidth = 20;
            this.dgvFechado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFechado.Size = new System.Drawing.Size(856, 304);
            this.dgvFechado.TabIndex = 18;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtualizar.Image = global::help_desk.Properties.Resources.icons8_Available_Updates_52px;
            this.btnAtualizar.Location = new System.Drawing.Point(853, 108);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(32, 32);
            this.btnAtualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAtualizar.TabIndex = 27;
            this.btnAtualizar.TabStop = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // frmChamados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnNovoChamado);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChamados";
            this.Text = "frmChamados";
            this.Load += new System.EventHandler(this.frmChamados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAberto)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabAberto.ResumeLayout(false);
            this.tabAberto.PerformLayout();
            this.tabFechado.ResumeLayout(false);
            this.tabFechado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFechado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtualizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtProtocolo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dgvAberto;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnNovoChamado;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAberto;
        private System.Windows.Forms.TabPage tabFechado;
        private System.Windows.Forms.DataGridView dgvFechado;
        private System.Windows.Forms.Label lblAvisoAberto;
        private System.Windows.Forms.Label lblAvisoFechado;
        private System.Windows.Forms.PictureBox btnAtualizar;
    }
}