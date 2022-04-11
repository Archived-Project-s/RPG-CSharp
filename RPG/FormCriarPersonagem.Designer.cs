
namespace RPG
{
    partial class FormCriarPersonagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCriarPersonagem));
            this.Lbl_NomePersonagem = new System.Windows.Forms.Label();
            this.Txt_NomePersonagem = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Gbox_Genero = new System.Windows.Forms.GroupBox();
            this.Rdo_GeneroFem = new System.Windows.Forms.RadioButton();
            this.Rdo_GeneroMasc = new System.Windows.Forms.RadioButton();
            this.Cbox_ClassePersonagem = new System.Windows.Forms.ComboBox();
            this.Lbl_ClassesPerosonagem = new System.Windows.Forms.Label();
            this.Btn_SalvarPersonagem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Gbox_Genero.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_NomePersonagem
            // 
            this.Lbl_NomePersonagem.AutoSize = true;
            this.Lbl_NomePersonagem.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_NomePersonagem.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_NomePersonagem.Location = new System.Drawing.Point(274, 223);
            this.Lbl_NomePersonagem.Name = "Lbl_NomePersonagem";
            this.Lbl_NomePersonagem.Size = new System.Drawing.Size(279, 21);
            this.Lbl_NomePersonagem.TabIndex = 0;
            this.Lbl_NomePersonagem.Text = "Digite o Nome de seu Personagem";
            this.Lbl_NomePersonagem.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Txt_NomePersonagem
            // 
            this.Txt_NomePersonagem.Location = new System.Drawing.Point(298, 247);
            this.Txt_NomePersonagem.Name = "Txt_NomePersonagem";
            this.Txt_NomePersonagem.Size = new System.Drawing.Size(220, 23);
            this.Txt_NomePersonagem.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::RPG.Properties.Resources.guysouth111;
            this.pictureBox1.Location = new System.Drawing.Point(237, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Gbox_Genero
            // 
            this.Gbox_Genero.BackColor = System.Drawing.Color.Transparent;
            this.Gbox_Genero.Controls.Add(this.Rdo_GeneroFem);
            this.Gbox_Genero.Controls.Add(this.Rdo_GeneroMasc);
            this.Gbox_Genero.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Gbox_Genero.Location = new System.Drawing.Point(298, 276);
            this.Gbox_Genero.Name = "Gbox_Genero";
            this.Gbox_Genero.Size = new System.Drawing.Size(220, 65);
            this.Gbox_Genero.TabIndex = 3;
            this.Gbox_Genero.TabStop = false;
            this.Gbox_Genero.Text = "Gênero";
            // 
            // Rdo_GeneroFem
            // 
            this.Rdo_GeneroFem.AutoSize = true;
            this.Rdo_GeneroFem.BackColor = System.Drawing.Color.Transparent;
            this.Rdo_GeneroFem.Location = new System.Drawing.Point(114, 19);
            this.Rdo_GeneroFem.Name = "Rdo_GeneroFem";
            this.Rdo_GeneroFem.Size = new System.Drawing.Size(100, 25);
            this.Rdo_GeneroFem.TabIndex = 1;
            this.Rdo_GeneroFem.TabStop = true;
            this.Rdo_GeneroFem.Text = "Feminino";
            this.Rdo_GeneroFem.UseVisualStyleBackColor = false;
            // 
            // Rdo_GeneroMasc
            // 
            this.Rdo_GeneroMasc.AutoSize = true;
            this.Rdo_GeneroMasc.BackColor = System.Drawing.Color.Transparent;
            this.Rdo_GeneroMasc.Location = new System.Drawing.Point(7, 19);
            this.Rdo_GeneroMasc.Name = "Rdo_GeneroMasc";
            this.Rdo_GeneroMasc.Size = new System.Drawing.Size(109, 25);
            this.Rdo_GeneroMasc.TabIndex = 0;
            this.Rdo_GeneroMasc.TabStop = true;
            this.Rdo_GeneroMasc.Text = "Masculino";
            this.Rdo_GeneroMasc.UseVisualStyleBackColor = false;
            // 
            // Cbox_ClassePersonagem
            // 
            this.Cbox_ClassePersonagem.FormattingEnabled = true;
            this.Cbox_ClassePersonagem.Items.AddRange(new object[] {
            "Mago",
            "Assassino",
            "Guerreiro",
            "Arqueiro"});
            this.Cbox_ClassePersonagem.Location = new System.Drawing.Point(298, 367);
            this.Cbox_ClassePersonagem.Name = "Cbox_ClassePersonagem";
            this.Cbox_ClassePersonagem.Size = new System.Drawing.Size(220, 23);
            this.Cbox_ClassePersonagem.TabIndex = 4;
            // 
            // Lbl_ClassesPerosonagem
            // 
            this.Lbl_ClassesPerosonagem.AutoSize = true;
            this.Lbl_ClassesPerosonagem.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_ClassesPerosonagem.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_ClassesPerosonagem.Location = new System.Drawing.Point(298, 343);
            this.Lbl_ClassesPerosonagem.Name = "Lbl_ClassesPerosonagem";
            this.Lbl_ClassesPerosonagem.Size = new System.Drawing.Size(71, 21);
            this.Lbl_ClassesPerosonagem.TabIndex = 5;
            this.Lbl_ClassesPerosonagem.Text = "Classes";
            // 
            // Btn_SalvarPersonagem
            // 
            this.Btn_SalvarPersonagem.BackColor = System.Drawing.Color.Transparent;
            this.Btn_SalvarPersonagem.Location = new System.Drawing.Point(298, 396);
            this.Btn_SalvarPersonagem.Name = "Btn_SalvarPersonagem";
            this.Btn_SalvarPersonagem.Size = new System.Drawing.Size(220, 23);
            this.Btn_SalvarPersonagem.TabIndex = 6;
            this.Btn_SalvarPersonagem.Text = "Salvar Personagem";
            this.Btn_SalvarPersonagem.UseVisualStyleBackColor = false;
            this.Btn_SalvarPersonagem.Click += new System.EventHandler(this.Btn_SalvarPersonagem_Click);
            // 
            // FormCriarPersonagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_SalvarPersonagem);
            this.Controls.Add(this.Lbl_ClassesPerosonagem);
            this.Controls.Add(this.Cbox_ClassePersonagem);
            this.Controls.Add(this.Gbox_Genero);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Txt_NomePersonagem);
            this.Controls.Add(this.Lbl_NomePersonagem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCriarPersonagem";
            this.Text = "Crie Seu Personagem";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Gbox_Genero.ResumeLayout(false);
            this.Gbox_Genero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_NomePersonagem;
        private System.Windows.Forms.TextBox Txt_NomePersonagem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox Gbox_Genero;
        private System.Windows.Forms.RadioButton Rdo_GeneroFem;
        private System.Windows.Forms.RadioButton Rdo_GeneroMasc;
        private System.Windows.Forms.ComboBox Cbox_ClassePersonagem;
        private System.Windows.Forms.Label Lbl_ClassesPerosonagem;
        private System.Windows.Forms.Button Btn_SalvarPersonagem;
    }
}