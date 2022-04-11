using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

using RPG.ClassesPersonagem;

namespace RPG
{
    public partial class FormCriarPersonagem : Form
    {
        public FormCriarPersonagem()
        {
            InitializeComponent();
        }

        private void Btn_SalvarPersonagem_Click(object sender, EventArgs e)
        {
            //Conferindo se o campo nome esta vazio
            if (String.IsNullOrEmpty(Txt_NomePersonagem.Text) || Txt_NomePersonagem.Text[0] == ' ')
            {
                MessageBox.Show("Você precisa nomear seu personagem. " + " Nota: Nomes também não podem começar com um espaço)");
                return;
            }

            //Conferindo se o campo genero esta vazio
            //Genero
            EntidadeGenero eGenero = new EntidadeGenero();

            if (this.Rdo_GeneroMasc.Checked)
            {
                eGenero = EntidadeGenero.Masculino;
            }
            else if (this.Rdo_GeneroFem.Checked)
            {
                eGenero = EntidadeGenero.Feminino;
            }
            else
            {
                MessageBox.Show("Você deve selecionar um gênero");
                return;
            }

            //Conferindo se o campo Classe esta vazio

            EntidadeClasse eClasse = new EntidadeClasse();
            if (Cbox_ClassePersonagem.Text == "Mago")
            {
                eClasse = EntidadeClasse.Mago;
            }
            else if (Cbox_ClassePersonagem.Text == "Assassino")
            {
                eClasse = EntidadeClasse.Assassino;
            }
            else if (Cbox_ClassePersonagem.Text == "Guerreiro")
            {
                eClasse = EntidadeClasse.Guerreiro;
            }
            else if (Cbox_ClassePersonagem.Text == "Arqueiro")
            {
                eClasse = EntidadeClasse.Arqueiro;
            }
            else
            {
                MessageBox.Show("Você deve selecionar uma classe.");
                return;
            }

            string genero = (string)(this.Rdo_GeneroFem.Checked ? "Feminino" : "Masculino");
            string nome = Txt_NomePersonagem.Text;
            string classe = Cbox_ClassePersonagem.Text;
            MessageBox.Show("\nSeu personagem foi criado.\n" + nome + " é um(a) " + classe + "(a)" + " do gênero " + genero);

            // Criando objeto
            Jogador jogador1 = new Jogador(nome, eGenero, eClasse);

            // Armazena nosso Personagem
            GerenciadorArquivos.ArmazenaPersonagem(jogador1);

            this.Hide();
            Frm_status stats = new Frm_status();
            stats.Closed += (s, args) => this.Close();
            stats.Show();
        }
    }
}
