using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RPG.TelasJogo
{
    public partial class Frm_Tela1 : Form
    {
        public Frm_Tela1()
        {
            InitializeComponent();
            MessageBox.Show("Logo ao acordar você percebe que está em uma caverna escura e sombria...");
            MessageBox.Show("Perdido e desamparado, você busca uma saida.");
            MessageBox.Show("Qual será a sua escolha?");
        }

        private void Frm_Tela1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ainda não existe função");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Luz luz = new Luz();
            luz.Closed += (s, args) => this.Close();
            luz.Show();
        }
    }
}
