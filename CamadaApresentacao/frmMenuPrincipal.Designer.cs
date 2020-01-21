namespace help_desk
{
    partial class frmMenuPrincipal
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
            System.Windows.Forms.Label lblUnderControl;
            System.Windows.Forms.Label lblHelpDesk;
            System.Windows.Forms.Label lblTituo;
            this.painelSuperior = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.painelMenuLateral = new System.Windows.Forms.Panel();
            this.painelbtnChamados = new System.Windows.Forms.Panel();
            this.borderbtn2 = new System.Windows.Forms.Panel();
            this.btnChamados = new System.Windows.Forms.Button();
            this.linhainferior = new System.Windows.Forms.Panel();
            this.painelinferiorUsuario = new System.Windows.Forms.Panel();
            this.picboxLogoff = new System.Windows.Forms.PictureBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.painelbtnAtualizacoes = new System.Windows.Forms.Panel();
            this.borderBtn = new System.Windows.Forms.Panel();
            this.btnDepartamento = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnAtualizacoes = new System.Windows.Forms.Button();
            this.painelLOGO = new System.Windows.Forms.Panel();
            this.picboxLogo = new System.Windows.Forms.PictureBox();
            this.timerbtnAtualizacoes = new System.Windows.Forms.Timer(this.components);
            this.timerData = new System.Windows.Forms.Timer(this.components);
            this.painelFormulario = new System.Windows.Forms.Panel();
            lblUnderControl = new System.Windows.Forms.Label();
            lblHelpDesk = new System.Windows.Forms.Label();
            lblTituo = new System.Windows.Forms.Label();
            this.painelSuperior.SuspendLayout();
            this.painelMenuLateral.SuspendLayout();
            this.painelbtnChamados.SuspendLayout();
            this.painelinferiorUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogoff)).BeginInit();
            this.painelbtnAtualizacoes.SuspendLayout();
            this.painelLOGO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUnderControl
            // 
            lblUnderControl.AutoSize = true;
            lblUnderControl.BackColor = System.Drawing.Color.Transparent;
            lblUnderControl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblUnderControl.ForeColor = System.Drawing.Color.White;
            lblUnderControl.Location = new System.Drawing.Point(30, 66);
            lblUnderControl.Name = "lblUnderControl";
            lblUnderControl.Size = new System.Drawing.Size(141, 25);
            lblUnderControl.TabIndex = 1;
            lblUnderControl.Text = "Under Control";
            // 
            // lblHelpDesk
            // 
            lblHelpDesk.AutoSize = true;
            lblHelpDesk.BackColor = System.Drawing.Color.Transparent;
            lblHelpDesk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHelpDesk.ForeColor = System.Drawing.Color.White;
            lblHelpDesk.Location = new System.Drawing.Point(58, 89);
            lblHelpDesk.Name = "lblHelpDesk";
            lblHelpDesk.Size = new System.Drawing.Size(80, 21);
            lblHelpDesk.TabIndex = 2;
            lblHelpDesk.Text = "Help Desk";
            // 
            // lblTituo
            // 
            lblTituo.AutoSize = true;
            lblTituo.BackColor = System.Drawing.Color.Transparent;
            lblTituo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTituo.ForeColor = System.Drawing.Color.White;
            lblTituo.Location = new System.Drawing.Point(12, 8);
            lblTituo.Name = "lblTituo";
            lblTituo.Size = new System.Drawing.Size(182, 21);
            lblTituo.TabIndex = 6;
            lblTituo.Text = "Sistema Help Desk [v1.0]";
            // 
            // painelSuperior
            // 
            this.painelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.painelSuperior.Controls.Add(lblTituo);
            this.painelSuperior.Controls.Add(this.btnRestaurar);
            this.painelSuperior.Controls.Add(this.btnMinimizar);
            this.painelSuperior.Controls.Add(this.btnMaximizar);
            this.painelSuperior.Controls.Add(this.btnFechar);
            this.painelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelSuperior.Location = new System.Drawing.Point(0, 0);
            this.painelSuperior.Name = "painelSuperior";
            this.painelSuperior.Size = new System.Drawing.Size(1100, 40);
            this.painelSuperior.TabIndex = 0;
            this.painelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.painelSuperior_MouseDown);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Image = global::help_desk.Properties.Resources.Icono_Restaurar;
            this.btnRestaurar.Location = new System.Drawing.Point(1020, 0);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(40, 40);
            this.btnRestaurar.TabIndex = 4;
            this.btnRestaurar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.AccessibleDescription = "Minimizar";
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = global::help_desk.Properties.Resources.Icono_Minimizar;
            this.btnMinimizar.Location = new System.Drawing.Point(980, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 40);
            this.btnMinimizar.TabIndex = 5;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Image = global::help_desk.Properties.Resources.Icono_Maximizar;
            this.btnMaximizar.Location = new System.Drawing.Point(1020, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(40, 40);
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
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
            this.btnFechar.Location = new System.Drawing.Point(1060, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(40, 40);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // painelMenuLateral
            // 
            this.painelMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.painelMenuLateral.Controls.Add(this.painelbtnChamados);
            this.painelMenuLateral.Controls.Add(this.linhainferior);
            this.painelMenuLateral.Controls.Add(this.painelinferiorUsuario);
            this.painelMenuLateral.Controls.Add(this.painelbtnAtualizacoes);
            this.painelMenuLateral.Controls.Add(this.painelLOGO);
            this.painelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.painelMenuLateral.Location = new System.Drawing.Point(0, 40);
            this.painelMenuLateral.Name = "painelMenuLateral";
            this.painelMenuLateral.Size = new System.Drawing.Size(200, 540);
            this.painelMenuLateral.TabIndex = 1;
            // 
            // painelbtnChamados
            // 
            this.painelbtnChamados.Controls.Add(this.borderbtn2);
            this.painelbtnChamados.Controls.Add(this.btnChamados);
            this.painelbtnChamados.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelbtnChamados.Location = new System.Drawing.Point(0, 175);
            this.painelbtnChamados.Name = "painelbtnChamados";
            this.painelbtnChamados.Size = new System.Drawing.Size(200, 50);
            this.painelbtnChamados.TabIndex = 6;
            // 
            // borderbtn2
            // 
            this.borderbtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(158)))), ((int)(((byte)(253)))));
            this.borderbtn2.Dock = System.Windows.Forms.DockStyle.Left;
            this.borderbtn2.Location = new System.Drawing.Point(0, 0);
            this.borderbtn2.Name = "borderbtn2";
            this.borderbtn2.Size = new System.Drawing.Size(5, 50);
            this.borderbtn2.TabIndex = 2;
            // 
            // btnChamados
            // 
            this.btnChamados.FlatAppearance.BorderSize = 0;
            this.btnChamados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(158)))), ((int)(((byte)(253)))));
            this.btnChamados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChamados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamados.ForeColor = System.Drawing.Color.White;
            this.btnChamados.Image = global::help_desk.Properties.Resources.chamado;
            this.btnChamados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChamados.Location = new System.Drawing.Point(0, 0);
            this.btnChamados.Name = "btnChamados";
            this.btnChamados.Size = new System.Drawing.Size(200, 50);
            this.btnChamados.TabIndex = 2;
            this.btnChamados.Text = "  Chamados";
            this.btnChamados.UseVisualStyleBackColor = true;
            this.btnChamados.Click += new System.EventHandler(this.btnChamados_Click);
            // 
            // linhainferior
            // 
            this.linhainferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linhainferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhainferior.Location = new System.Drawing.Point(0, 465);
            this.linhainferior.Name = "linhainferior";
            this.linhainferior.Size = new System.Drawing.Size(200, 1);
            this.linhainferior.TabIndex = 5;
            // 
            // painelinferiorUsuario
            // 
            this.painelinferiorUsuario.Controls.Add(this.picboxLogoff);
            this.painelinferiorUsuario.Controls.Add(this.lblDepartamento);
            this.painelinferiorUsuario.Controls.Add(this.lblEmail);
            this.painelinferiorUsuario.Controls.Add(this.lblNome);
            this.painelinferiorUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.painelinferiorUsuario.Location = new System.Drawing.Point(0, 466);
            this.painelinferiorUsuario.Name = "painelinferiorUsuario";
            this.painelinferiorUsuario.Size = new System.Drawing.Size(200, 74);
            this.painelinferiorUsuario.TabIndex = 4;
            // 
            // picboxLogoff
            // 
            this.picboxLogoff.Image = global::help_desk.Properties.Resources.logoff;
            this.picboxLogoff.Location = new System.Drawing.Point(151, 13);
            this.picboxLogoff.Name = "picboxLogoff";
            this.picboxLogoff.Size = new System.Drawing.Size(26, 26);
            this.picboxLogoff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picboxLogoff.TabIndex = 10;
            this.picboxLogoff.TabStop = false;
            this.picboxLogoff.Click += new System.EventHandler(this.picboxLogoff_Click);
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.ForeColor = System.Drawing.Color.White;
            this.lblDepartamento.Location = new System.Drawing.Point(6, 30);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(92, 17);
            this.lblDepartamento.TabIndex = 9;
            this.lblDepartamento.Text = "Departamento";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(6, 49);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 17);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(5, 8);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(52, 20);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome";
            // 
            // painelbtnAtualizacoes
            // 
            this.painelbtnAtualizacoes.Controls.Add(this.borderBtn);
            this.painelbtnAtualizacoes.Controls.Add(this.btnDepartamento);
            this.painelbtnAtualizacoes.Controls.Add(this.btnUsuario);
            this.painelbtnAtualizacoes.Controls.Add(this.btnAtualizacoes);
            this.painelbtnAtualizacoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelbtnAtualizacoes.Location = new System.Drawing.Point(0, 125);
            this.painelbtnAtualizacoes.MaximumSize = new System.Drawing.Size(200, 120);
            this.painelbtnAtualizacoes.MinimumSize = new System.Drawing.Size(200, 50);
            this.painelbtnAtualizacoes.Name = "painelbtnAtualizacoes";
            this.painelbtnAtualizacoes.Size = new System.Drawing.Size(200, 50);
            this.painelbtnAtualizacoes.TabIndex = 3;
            // 
            // borderBtn
            // 
            this.borderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(158)))), ((int)(((byte)(253)))));
            this.borderBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.borderBtn.Location = new System.Drawing.Point(0, 0);
            this.borderBtn.Name = "borderBtn";
            this.borderBtn.Size = new System.Drawing.Size(5, 50);
            this.borderBtn.TabIndex = 0;
            // 
            // btnDepartamento
            // 
            this.btnDepartamento.FlatAppearance.BorderSize = 0;
            this.btnDepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartamento.ForeColor = System.Drawing.Color.White;
            this.btnDepartamento.Location = new System.Drawing.Point(0, 90);
            this.btnDepartamento.Name = "btnDepartamento";
            this.btnDepartamento.Padding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.btnDepartamento.Size = new System.Drawing.Size(200, 30);
            this.btnDepartamento.TabIndex = 2;
            this.btnDepartamento.Text = "• Departamento";
            this.btnDepartamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartamento.UseVisualStyleBackColor = true;
            this.btnDepartamento.Click += new System.EventHandler(this.btnDepartamento_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.Location = new System.Drawing.Point(0, 50);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Padding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.btnUsuario.Size = new System.Drawing.Size(200, 30);
            this.btnUsuario.TabIndex = 1;
            this.btnUsuario.Text = "• Usuário";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnAtualizacoes
            // 
            this.btnAtualizacoes.FlatAppearance.BorderSize = 0;
            this.btnAtualizacoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(158)))), ((int)(((byte)(253)))));
            this.btnAtualizacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizacoes.ForeColor = System.Drawing.Color.White;
            this.btnAtualizacoes.Image = global::help_desk.Properties.Resources.clientes;
            this.btnAtualizacoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizacoes.Location = new System.Drawing.Point(0, 0);
            this.btnAtualizacoes.Name = "btnAtualizacoes";
            this.btnAtualizacoes.Size = new System.Drawing.Size(200, 50);
            this.btnAtualizacoes.TabIndex = 1;
            this.btnAtualizacoes.Text = "     Atualizações";
            this.btnAtualizacoes.UseVisualStyleBackColor = true;
            this.btnAtualizacoes.Click += new System.EventHandler(this.btnAtualizacoes_Click);
            // 
            // painelLOGO
            // 
            this.painelLOGO.Controls.Add(lblHelpDesk);
            this.painelLOGO.Controls.Add(lblUnderControl);
            this.painelLOGO.Controls.Add(this.picboxLogo);
            this.painelLOGO.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelLOGO.Location = new System.Drawing.Point(0, 0);
            this.painelLOGO.Name = "painelLOGO";
            this.painelLOGO.Size = new System.Drawing.Size(200, 125);
            this.painelLOGO.TabIndex = 2;
            // 
            // picboxLogo
            // 
            this.picboxLogo.Image = global::help_desk.Properties.Resources.logoimg;
            this.picboxLogo.Location = new System.Drawing.Point(64, 8);
            this.picboxLogo.Name = "picboxLogo";
            this.picboxLogo.Size = new System.Drawing.Size(67, 58);
            this.picboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxLogo.TabIndex = 0;
            this.picboxLogo.TabStop = false;
            // 
            // timerbtnAtualizacoes
            // 
            this.timerbtnAtualizacoes.Interval = 15;
            this.timerbtnAtualizacoes.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerData
            // 
            this.timerData.Enabled = true;
            this.timerData.Interval = 1000;
            // 
            // painelFormulario
            // 
            this.painelFormulario.BackColor = System.Drawing.Color.White;
            this.painelFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelFormulario.Location = new System.Drawing.Point(200, 40);
            this.painelFormulario.Name = "painelFormulario";
            this.painelFormulario.Size = new System.Drawing.Size(900, 540);
            this.painelFormulario.TabIndex = 2;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1100, 580);
            this.Controls.Add(this.painelFormulario);
            this.Controls.Add(this.painelMenuLateral);
            this.Controls.Add(this.painelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuPrincipal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.painelSuperior.ResumeLayout(false);
            this.painelSuperior.PerformLayout();
            this.painelMenuLateral.ResumeLayout(false);
            this.painelbtnChamados.ResumeLayout(false);
            this.painelinferiorUsuario.ResumeLayout(false);
            this.painelinferiorUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogoff)).EndInit();
            this.painelbtnAtualizacoes.ResumeLayout(false);
            this.painelLOGO.ResumeLayout(false);
            this.painelLOGO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painelSuperior;
        private System.Windows.Forms.Panel painelMenuLateral;
        private System.Windows.Forms.Timer timerbtnAtualizacoes;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Panel linhainferior;
        private System.Windows.Forms.Panel painelinferiorUsuario;
        private System.Windows.Forms.Timer timerData;
        private System.Windows.Forms.Panel painelbtnAtualizacoes;
        private System.Windows.Forms.Panel borderBtn;
        private System.Windows.Forms.Button btnDepartamento;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnAtualizacoes;
        private System.Windows.Forms.Panel painelLOGO;
        private System.Windows.Forms.PictureBox picboxLogo;
        private System.Windows.Forms.Panel painelbtnChamados;
        private System.Windows.Forms.Panel borderbtn2;
        private System.Windows.Forms.Button btnChamados;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.PictureBox picboxLogoff;
        private System.Windows.Forms.Panel painelFormulario;
    }
}