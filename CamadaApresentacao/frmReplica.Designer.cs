namespace help_desk
{
    partial class frmReplica
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
            System.Windows.Forms.Label lblTituo;
            this.lblAvisoMensagem = new System.Windows.Forms.Label();
            this.txtReplica = new System.Windows.Forms.RichTextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.painelSuperior = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblAviso = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.painelInferior = new System.Windows.Forms.Panel();
            this.painelDireito = new System.Windows.Forms.Panel();
            lblTituo = new System.Windows.Forms.Label();
            this.painelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAvisoMensagem
            // 
            this.lblAvisoMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAvisoMensagem.AutoSize = true;
            this.lblAvisoMensagem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoMensagem.ForeColor = System.Drawing.Color.Red;
            this.lblAvisoMensagem.Location = new System.Drawing.Point(30, 53);
            this.lblAvisoMensagem.Name = "lblAvisoMensagem";
            this.lblAvisoMensagem.Size = new System.Drawing.Size(13, 17);
            this.lblAvisoMensagem.TabIndex = 25;
            this.lblAvisoMensagem.Text = "*";
            this.lblAvisoMensagem.Visible = false;
            // 
            // txtReplica
            // 
            this.txtReplica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReplica.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReplica.ForeColor = System.Drawing.Color.DimGray;
            this.txtReplica.Location = new System.Drawing.Point(44, 81);
            this.txtReplica.Name = "txtReplica";
            this.txtReplica.Size = new System.Drawing.Size(467, 147);
            this.txtReplica.TabIndex = 24;
            this.txtReplica.Text = "";
            // 
            // lblMensagem
            // 
            this.lblMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.Black;
            this.lblMensagem.Location = new System.Drawing.Point(40, 57);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(90, 21);
            this.lblMensagem.TabIndex = 23;
            this.lblMensagem.Text = "Mensagem:";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(158)))), ((int)(((byte)(253)))));
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(413, 234);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(98, 36);
            this.btnOK.TabIndex = 26;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // painelSuperior
            // 
            this.painelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.painelSuperior.Controls.Add(lblTituo);
            this.painelSuperior.Controls.Add(this.btnFechar);
            this.painelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelSuperior.Location = new System.Drawing.Point(0, 0);
            this.painelSuperior.Name = "painelSuperior";
            this.painelSuperior.Size = new System.Drawing.Size(550, 40);
            this.painelSuperior.TabIndex = 27;
            // 
            // btnFechar
            // 
            this.btnFechar.AccessibleDescription = "";
            this.btnFechar.AccessibleName = "";
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = global::help_desk.Properties.Resources.Icono_cerrar_FN;
            this.btnFechar.Location = new System.Drawing.Point(510, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(40, 40);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(40, 230);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(282, 40);
            this.lblAviso.TabIndex = 28;
            this.lblAviso.Text = "* Campos obrigatórios!\r\nFavor, verifique as informações digitadas.";
            this.lblAviso.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 258);
            this.panel1.TabIndex = 29;
            // 
            // painelInferior
            // 
            this.painelInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.painelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.painelInferior.Location = new System.Drawing.Point(2, 296);
            this.painelInferior.Name = "painelInferior";
            this.painelInferior.Size = new System.Drawing.Size(548, 2);
            this.painelInferior.TabIndex = 30;
            // 
            // painelDireito
            // 
            this.painelDireito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.painelDireito.Dock = System.Windows.Forms.DockStyle.Right;
            this.painelDireito.Location = new System.Drawing.Point(548, 40);
            this.painelDireito.Name = "painelDireito";
            this.painelDireito.Size = new System.Drawing.Size(2, 256);
            this.painelDireito.TabIndex = 31;
            // 
            // lblTituo
            // 
            lblTituo.AutoSize = true;
            lblTituo.BackColor = System.Drawing.Color.Transparent;
            lblTituo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTituo.ForeColor = System.Drawing.Color.White;
            lblTituo.Location = new System.Drawing.Point(3, 8);
            lblTituo.Name = "lblTituo";
            lblTituo.Size = new System.Drawing.Size(150, 21);
            lblTituo.TabIndex = 32;
            lblTituo.Text = "Réplica do chamado";
            // 
            // frmReplica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(550, 298);
            this.Controls.Add(this.painelDireito);
            this.Controls.Add(this.painelInferior);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.painelSuperior);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblAvisoMensagem);
            this.Controls.Add(this.txtReplica);
            this.Controls.Add(this.lblMensagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReplica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Replica";
            this.painelSuperior.ResumeLayout(false);
            this.painelSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblAvisoMensagem;
        public System.Windows.Forms.RichTextBox txtReplica;
        public System.Windows.Forms.Label lblMensagem;
        public System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.Panel painelSuperior;
        public System.Windows.Forms.Button btnFechar;
        public System.Windows.Forms.Label lblAviso;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel painelInferior;
        public System.Windows.Forms.Panel painelDireito;
    }
}