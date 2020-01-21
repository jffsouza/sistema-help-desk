using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Calcular_nota
{
    public partial class frmCalcularnota : Form
    {
        public frmCalcularnota()
        {
            InitializeComponent();
        }

        private void btnCalcularMedia_Click(object sender, EventArgs e)
        {
            //int Nota1, Nota2, Nota3, Nota4 são as variáveis:
            int Nota1; 
            int Nota2; 
            int Nota3;
            int Nota4;
            int Media;
            //Conversão das variáveis do textbox para int:

            if (txtNota1.Text != "")
            {
                Nota1 = Convert.ToInt16(txtNota1.Text);
            }
            else
            {
                MessageBox.Show("Favor digitar a Nota 1");
                txtNota1.Focus();
                return;
            }
            
            if (txtNota2.Text != "")
            {
                Nota2 = Convert.ToInt16(txtNota2.Text);
            }
            else
            {
                MessageBox.Show("Favor digitar a Nota 2");
                txtNota2.Focus();
                return;
            }

            if (txtNota3.Text != "")
            {
                Nota3 = Convert.ToInt16(txtNota3.Text);
            }

            else
            {
                MessageBox.Show("Favor digitar a Nota 3");
                txtNota3.Focus();
                return;
            }

            if (txtNota1.Text != "")
            {
                Nota4 = Convert.ToInt16(txtNota4.Text);
            }
            else
            {
                MessageBox.Show("Favor digitar a Nota 4");
                txtNota4.Focus();
                return;
            }

            /*if ((txtNota1.Text != "") || (txtNota2.Text != "") || (txtNota3.Text != "") || (txtNota4.Text != ""))
            {
                MessageBox.Show ("Favor digitar a nota!");        
            }
            */

            Nota1 = Convert.ToInt16(txtNota1.Text);
            Nota2 = Convert.ToInt16(txtNota2.Text);
            Nota3 = Convert.ToInt16(txtNota3.Text);
            Nota4 = Convert.ToInt16(txtNota4.Text);
         
            Media = (Nota1 + Nota2 + Nota3 + Nota4) / 4;
            txtMedia.Text = Media.ToString();


            //Lógica do Status:
            if (Media >= 7)
            {
                txtStatus.Text = "APROVADO !";
                //MessageBox Abre um "PopUp" para exibir a mensagem:
            }
            else
            {
                txtStatus.Text = "EXAME !";
                //MessageBox Abre um "PopUp" para exibir a mensagem:
                //MessageBox.Show("Aluno reprovado! \nMédia anual: " + txtMedia.Text);
                MessageBox.Show("Favor encaminhar o aluno para o exame !");
                grpExame.Show();
                txtMediaA.Text = txtMedia.Text;
                txtNotaEx.Focus();



            }
        
        }
        //Configurações do botão Limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtNota4.Text = "";
            txtMedia.Text = "";
            txtStatus.Text = "";

            //txtNota1.Focus retorna o cursos de digitação para o textbox informado.
            txtNota1.Focus();
        }

        public void btnMediaEx_Click(object sender, EventArgs e)
        {
            int NotaEx;
            int MediaEx;
            int Media;
            Media = Convert.ToInt16(txtMedia.Text);
            NotaEx = Convert.ToInt16(txtNotaEx.Text);
            MediaEx = (Media + NotaEx) / 2;
            txtMediaEx.Text = MediaEx.ToString();
            if (MediaEx >=5 )
            {
                MessageBox.Show("Aluno Aprovado!");
            }
            else
            {
                MessageBox.Show("Aluno deve cursar DP!");
            }
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtNota4.Text = "";
            txtMedia.Text = "";
            txtStatus.Text = "";
            txtMediaA.Text = "";
            txtMediaEx.Text = "";
            txtNotaEx.Text = "";

            grpExame.Hide();

            //txtNota1.Focus retorna o cursos de digitação para o textbox informado.
            txtNota1.Focus();
        }
    }
}
