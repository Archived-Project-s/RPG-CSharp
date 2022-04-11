using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RPG.TelasJogo
{
    public partial class Luz : Form
    {
        public Luz()
        {
            InitializeComponent();
            MessageBox.Show("Após seguir em direção a luz você toma um susto");
            MessageBox.Show("Não era a saida...");
            MessageBox.Show("E sim um monstro!!!");
        }

        private void Luz_Load(object sender, EventArgs e)
        {
           
        }
    }
}
