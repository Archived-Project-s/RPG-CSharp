using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPG.TelasJogo;
using RPG.ClassesPersonagem;
namespace RPG
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void Btn_creditos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Projeto por Gabriel Amorim em colaboração com a empresa Meta3");
        }

        private void Btn_CriarPersonagem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCriarPersonagem CriarPersonagem = new FormCriarPersonagem();
            CriarPersonagem.Closed += (s, args) => this.Close();
            CriarPersonagem.Show();
        }

        private void Btn_Jogar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindo...Esse é o inicio de sua nova aventura, espero que se divirta.");
            this.Hide();
            Frm_Tela1 Inicio = new Frm_Tela1();
            Inicio.Closed += (s, args) => this.Close();
            Inicio.Show();
        }

        private void Frm_Menu_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_opcoes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ainda não existe função");
        }

        private void Btn_Pontuacao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ainda não existe função");
        }

        public void Btn_Estatistica_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_status stats = new Frm_status();
            stats.Closed += (s, args) => this.Close();
            stats.Show();
        }

        private void Lbl_Titulo_Click(object sender, EventArgs e)
        {

        }
    }
}
