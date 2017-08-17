using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NotasUnopar.Classes;

namespace NotasUnopar
{
    public partial class frmPrincipal : Form
    {
        private ProvaPresencial prova;

        public frmPrincipal()
        {
            InitializeComponent();
            lbTitulo.BackColor = Color.Transparent;
            pictureBox1.Controls.Add(lbTitulo);
            prova = new ProvaPresencial();
        }

        //Calcular mádia parcial das questões discursivas
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                prova.calcularDiscursivas(cb_questao11.SelectedItem.ToString(), cb_questao12.SelectedItem.ToString());
            //  MessageBox.Show("Valores invalidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbDiscursivas.Text = prova.Discursivas.ToString();
            }
            catch (Exception)
            {
            }
        }

        //Calcular média parcial das questões objetivas
        private void button2_Click(object sender, EventArgs e)
        {
            prova.calcularObjetivas(cb_qtd_objetivas.SelectedIndex);
            txbObjetivas.Text = prova.Objetivas.ToString();
        }
  
        //Calcular media geral
        private void button3_Click(object sender, EventArgs e)
        {
            String q11 = cb_questao11.SelectedItem.ToString();
            String q12 = cb_questao12.SelectedItem.ToString();

            prova.calcularGeral(cb_qtd_objetivas.SelectedIndex, q11, q12);

            txbConceito.Text = prova.verificaConceito();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cb_qtd_objetivas.SelectedIndex = 0;
            cb_questao11.SelectedIndex = 0;
            cb_questao12.SelectedIndex = 0;
            txbDiscursivas.TextAlign = HorizontalAlignment.Center;
            txbObjetivas.TextAlign = HorizontalAlignment.Center;
            txbConceito.TextAlign = HorizontalAlignment.Center;

        }

        public void mensagemTeste(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionou!");
        }
    }
}
