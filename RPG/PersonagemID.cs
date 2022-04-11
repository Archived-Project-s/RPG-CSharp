using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RPG.ClassesPersonagem;

namespace RPG
{
    public partial class Frm_status : Form
    {
        public Frm_status()
        {
            InitializeComponent();
        }

        private void PersonagemID_Load(object sender, EventArgs e)
        {
            Jogador p1 = new Jogador();
            p1 = GerenciadorArquivos.LoadPlayer();
            Lbl_Nome.Text = p1.Nome;
            Lbl_Genero.Text = p1.Genero.ToString();
            Lbl_Classe.Text = p1.Personagemclasse.ToString();
            Lbl_Level.Text = p1.Level.ToString();
            Lbl_Vida.Text = p1.Vida.ToString();
            Lbl_Forca.Text = p1.Forca.ToString();
            Lbl_Defesa.Text = p1.Defesa.ToString();
            Lbl_Mana.Text = p1.Mana.ToString();
            Lbl_Magia.Text = p1.Magia.ToString();
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Menu Menu = new Frm_Menu();
            Menu.Closed += (s, args) => this.Close();
            Menu.Show();
        }
    }
}
