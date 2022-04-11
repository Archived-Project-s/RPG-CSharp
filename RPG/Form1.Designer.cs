
namespace RPG
{
    partial class Frm_Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Menu));
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Btn_CriarPersonagem = new System.Windows.Forms.Button();
            this.Btn_Jogar = new System.Windows.Forms.Button();
            this.Btn_Estatistica = new System.Windows.Forms.Button();
            this.Btn_creditos = new System.Windows.Forms.Button();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Titulo.Location = new System.Drawing.Point(205, 84);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(438, 60);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "O Léndario Estágiario";
            this.Lbl_Titulo.Click += new System.EventHandler(this.Lbl_Titulo_Click);
            // 
            // Btn_CriarPersonagem
            // 
            this.Btn_CriarPersonagem.BackColor = System.Drawing.Color.Transparent;
            this.Btn_CriarPersonagem.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_CriarPersonagem.Location = new System.Drawing.Point(12, 149);
            this.Btn_CriarPersonagem.Name = "Btn_CriarPersonagem";
            this.Btn_CriarPersonagem.Size = new System.Drawing.Size(141, 53);
            this.Btn_CriarPersonagem.TabIndex = 1;
            this.Btn_CriarPersonagem.Text = "Criar Personagem";
            this.Btn_CriarPersonagem.UseVisualStyleBackColor = false;
            this.Btn_CriarPersonagem.Click += new System.EventHandler(this.Btn_CriarPersonagem_Click);
            // 
            // Btn_Jogar
            // 
            this.Btn_Jogar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Jogar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Jogar.Location = new System.Drawing.Point(12, 208);
            this.Btn_Jogar.Name = "Btn_Jogar";
            this.Btn_Jogar.Size = new System.Drawing.Size(141, 53);
            this.Btn_Jogar.TabIndex = 2;
            this.Btn_Jogar.Text = "Jogar";
            this.Btn_Jogar.UseVisualStyleBackColor = false;
            this.Btn_Jogar.Click += new System.EventHandler(this.Btn_Jogar_Click);
            // 
            // Btn_Estatistica
            // 
            this.Btn_Estatistica.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Estatistica.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Estatistica.Location = new System.Drawing.Point(12, 267);
            this.Btn_Estatistica.Name = "Btn_Estatistica";
            this.Btn_Estatistica.Size = new System.Drawing.Size(141, 53);
            this.Btn_Estatistica.TabIndex = 3;
            this.Btn_Estatistica.Text = "Stats";
            this.Btn_Estatistica.UseVisualStyleBackColor = false;
            this.Btn_Estatistica.Click += new System.EventHandler(this.Btn_Estatistica_Click);
            // 
            // Btn_creditos
            // 
            this.Btn_creditos.BackColor = System.Drawing.Color.Transparent;
            this.Btn_creditos.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_creditos.Location = new System.Drawing.Point(12, 326);
            this.Btn_creditos.Name = "Btn_creditos";
            this.Btn_creditos.Size = new System.Drawing.Size(141, 53);
            this.Btn_creditos.TabIndex = 6;
            this.Btn_creditos.Text = "Créditos";
            this.Btn_creditos.UseVisualStyleBackColor = false;
            this.Btn_creditos.Click += new System.EventHandler(this.Btn_creditos_Click);
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Sair.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Sair.Location = new System.Drawing.Point(12, 385);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(141, 53);
            this.Btn_Sair.TabIndex = 7;
            this.Btn_Sair.Text = "Sair";
            this.Btn_Sair.UseVisualStyleBackColor = false;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.Btn_creditos);
            this.Controls.Add(this.Btn_Estatistica);
            this.Controls.Add(this.Btn_Jogar);
            this.Controls.Add(this.Btn_CriarPersonagem);
            this.Controls.Add(this.Lbl_Titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu RPG";
            this.Load += new System.EventHandler(this.Frm_Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Button Btn_CriarPersonagem;
        private System.Windows.Forms.Button Btn_Jogar;
        private System.Windows.Forms.Button Btn_Estatistica;
        private System.Windows.Forms.Button Btn_creditos;
        private System.Windows.Forms.Button Btn_Sair;
    }
}

