namespace Calcular_nota
{
    partial class frmCalcularnota
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
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.lblNota4 = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtNota4 = new System.Windows.Forms.TextBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnCalcularMedia = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.grpCalculoNota = new System.Windows.Forms.GroupBox();
            this.grpExame = new System.Windows.Forms.GroupBox();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.btnMediaEx = new System.Windows.Forms.Button();
            this.txtMediaA = new System.Windows.Forms.TextBox();
            this.txtNotaEx = new System.Windows.Forms.TextBox();
            this.txtMediaEx = new System.Windows.Forms.TextBox();
            this.lblMediaEx = new System.Windows.Forms.Label();
            this.lblNotaEx = new System.Windows.Forms.Label();
            this.lblMediaAnual = new System.Windows.Forms.Label();
            this.grpCalculoNota.SuspendLayout();
            this.grpExame.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(16, 35);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(42, 13);
            this.lblNota1.TabIndex = 0;
            this.lblNota1.Text = "Nota 1:";
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(16, 61);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(42, 13);
            this.lblNota2.TabIndex = 1;
            this.lblNota2.Text = "Nota 2:";
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(16, 87);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(42, 13);
            this.lblNota3.TabIndex = 2;
            this.lblNota3.Text = "Nota 3:";
            // 
            // lblNota4
            // 
            this.lblNota4.AutoSize = true;
            this.lblNota4.Location = new System.Drawing.Point(16, 113);
            this.lblNota4.Name = "lblNota4";
            this.lblNota4.Size = new System.Drawing.Size(42, 13);
            this.lblNota4.TabIndex = 3;
            this.lblNota4.Text = "Nota 4:";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(61, 159);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(39, 13);
            this.lblMedia.TabIndex = 4;
            this.lblMedia.Text = "Média:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(61, 189);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status:";
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(52, 20);
            this.txtNota1.MaxLength = 2;
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 20);
            this.txtNota1.TabIndex = 1;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(52, 46);
            this.txtNota2.MaxLength = 2;
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 20);
            this.txtNota2.TabIndex = 2;
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(51, 72);
            this.txtNota3.MaxLength = 2;
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(100, 20);
            this.txtNota3.TabIndex = 3;
            // 
            // txtNota4
            // 
            this.txtNota4.Location = new System.Drawing.Point(51, 98);
            this.txtNota4.MaxLength = 2;
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(100, 20);
            this.txtNota4.TabIndex = 4;
            // 
            // txtMedia
            // 
            this.txtMedia.Enabled = false;
            this.txtMedia.Location = new System.Drawing.Point(106, 156);
            this.txtMedia.MaxLength = 2;
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(100, 20);
            this.txtMedia.TabIndex = 20;
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(106, 186);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 20;
            // 
            // btnCalcularMedia
            // 
            this.btnCalcularMedia.Location = new System.Drawing.Point(12, 239);
            this.btnCalcularMedia.Name = "btnCalcularMedia";
            this.btnCalcularMedia.Size = new System.Drawing.Size(85, 23);
            this.btnCalcularMedia.TabIndex = 5;
            this.btnCalcularMedia.Text = "Calcular Média";
            this.btnCalcularMedia.UseVisualStyleBackColor = true;
            this.btnCalcularMedia.Click += new System.EventHandler(this.btnCalcularMedia_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(109, 239);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(197, 239);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // grpCalculoNota
            // 
            this.grpCalculoNota.Controls.Add(this.txtNota1);
            this.grpCalculoNota.Controls.Add(this.txtNota4);
            this.grpCalculoNota.Controls.Add(this.txtNota3);
            this.grpCalculoNota.Controls.Add(this.txtNota2);
            this.grpCalculoNota.Location = new System.Drawing.Point(12, 12);
            this.grpCalculoNota.Name = "grpCalculoNota";
            this.grpCalculoNota.Size = new System.Drawing.Size(260, 128);
            this.grpCalculoNota.TabIndex = 11;
            this.grpCalculoNota.TabStop = false;
            this.grpCalculoNota.Text = "Calculo Média";
            // 
            // grpExame
            // 
            this.grpExame.Controls.Add(this.btnRetornar);
            this.grpExame.Controls.Add(this.btnMediaEx);
            this.grpExame.Controls.Add(this.txtMediaA);
            this.grpExame.Controls.Add(this.txtNotaEx);
            this.grpExame.Controls.Add(this.txtMediaEx);
            this.grpExame.Controls.Add(this.lblMediaEx);
            this.grpExame.Controls.Add(this.lblNotaEx);
            this.grpExame.Controls.Add(this.lblMediaAnual);
            this.grpExame.Location = new System.Drawing.Point(298, 12);
            this.grpExame.Name = "grpExame";
            this.grpExame.Size = new System.Drawing.Size(233, 163);
            this.grpExame.TabIndex = 12;
            this.grpExame.TabStop = false;
            this.grpExame.Text = "Exame";
            this.grpExame.Visible = false;
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(130, 117);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(75, 23);
            this.btnRetornar.TabIndex = 12;
            this.btnRetornar.Text = "Sair";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // btnMediaEx
            // 
            this.btnMediaEx.Location = new System.Drawing.Point(31, 117);
            this.btnMediaEx.Name = "btnMediaEx";
            this.btnMediaEx.Size = new System.Drawing.Size(86, 23);
            this.btnMediaEx.TabIndex = 11;
            this.btnMediaEx.Text = "Calcular Média";
            this.btnMediaEx.UseVisualStyleBackColor = true;
            this.btnMediaEx.Click += new System.EventHandler(this.btnMediaEx_Click);
            // 
            // txtMediaA
            // 
            this.txtMediaA.Enabled = false;
            this.txtMediaA.Location = new System.Drawing.Point(113, 19);
            this.txtMediaA.MaxLength = 2;
            this.txtMediaA.Name = "txtMediaA";
            this.txtMediaA.Size = new System.Drawing.Size(100, 20);
            this.txtMediaA.TabIndex = 8;
            // 
            // txtNotaEx
            // 
            this.txtNotaEx.Location = new System.Drawing.Point(113, 45);
            this.txtNotaEx.MaxLength = 2;
            this.txtNotaEx.Name = "txtNotaEx";
            this.txtNotaEx.Size = new System.Drawing.Size(100, 20);
            this.txtNotaEx.TabIndex = 9;
            // 
            // txtMediaEx
            // 
            this.txtMediaEx.Enabled = false;
            this.txtMediaEx.Location = new System.Drawing.Point(113, 71);
            this.txtMediaEx.Name = "txtMediaEx";
            this.txtMediaEx.Size = new System.Drawing.Size(100, 20);
            this.txtMediaEx.TabIndex = 10;
            // 
            // lblMediaEx
            // 
            this.lblMediaEx.AutoSize = true;
            this.lblMediaEx.Location = new System.Drawing.Point(23, 74);
            this.lblMediaEx.Name = "lblMediaEx";
            this.lblMediaEx.Size = new System.Drawing.Size(77, 13);
            this.lblMediaEx.TabIndex = 2;
            this.lblMediaEx.Text = "Média Exame: ";
            // 
            // lblNotaEx
            // 
            this.lblNotaEx.AutoSize = true;
            this.lblNotaEx.Location = new System.Drawing.Point(23, 48);
            this.lblNotaEx.Name = "lblNotaEx";
            this.lblNotaEx.Size = new System.Drawing.Size(71, 13);
            this.lblNotaEx.TabIndex = 1;
            this.lblNotaEx.Text = "Nota Exame: ";
            // 
            // lblMediaAnual
            // 
            this.lblMediaAnual.AutoSize = true;
            this.lblMediaAnual.Location = new System.Drawing.Point(23, 22);
            this.lblMediaAnual.Name = "lblMediaAnual";
            this.lblMediaAnual.Size = new System.Drawing.Size(72, 13);
            this.lblMediaAnual.TabIndex = 0;
            this.lblMediaAnual.Text = "Média Anual: ";
            // 
            // frmCalcularnota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 310);
            this.Controls.Add(this.grpExame);
            this.Controls.Add(this.btnCalcularMedia);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.lblNota4);
            this.Controls.Add(this.lblNota3);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.lblNota1);
            this.Controls.Add(this.grpCalculoNota);
            this.Name = "frmCalcularnota";
            this.Text = "frmCalcularnota";
            this.grpCalculoNota.ResumeLayout(false);
            this.grpCalculoNota.PerformLayout();
            this.grpExame.ResumeLayout(false);
            this.grpExame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.Label lblNota4;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.TextBox txtNota4;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnCalcularMedia;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox grpCalculoNota;
        private System.Windows.Forms.GroupBox grpExame;
        private System.Windows.Forms.Label lblMediaAnual;
        private System.Windows.Forms.TextBox txtMediaA;
        private System.Windows.Forms.TextBox txtNotaEx;
        private System.Windows.Forms.TextBox txtMediaEx;
        private System.Windows.Forms.Label lblMediaEx;
        private System.Windows.Forms.Label lblNotaEx;
        private System.Windows.Forms.Button btnMediaEx;
        private System.Windows.Forms.Button btnRetornar;
    }
}