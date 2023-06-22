namespace CatalagoFilmes_SCF.View
{
    partial class TelaCadastroFilme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroFilme));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txBox_Filme = new System.Windows.Forms.TextBox();
            this.txBox_Estreia = new System.Windows.Forms.TextBox();
            this.cbBox_Categoria = new System.Windows.Forms.ComboBox();
            this.txBox_Duracao = new System.Windows.Forms.TextBox();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Filmes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filme:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estreia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(176, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categoria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(12, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Duração:";
            // 
            // txBox_Filme
            // 
            this.txBox_Filme.BackColor = System.Drawing.Color.DarkRed;
            this.txBox_Filme.ForeColor = System.Drawing.SystemColors.Window;
            this.txBox_Filme.Location = new System.Drawing.Point(12, 62);
            this.txBox_Filme.Name = "txBox_Filme";
            this.txBox_Filme.Size = new System.Drawing.Size(299, 23);
            this.txBox_Filme.TabIndex = 5;
            this.txBox_Filme.TextChanged += new System.EventHandler(this.txBox_Filme_TextChanged);
            // 
            // txBox_Estreia
            // 
            this.txBox_Estreia.BackColor = System.Drawing.Color.DarkRed;
            this.txBox_Estreia.ForeColor = System.Drawing.SystemColors.Window;
            this.txBox_Estreia.Location = new System.Drawing.Point(12, 115);
            this.txBox_Estreia.Name = "txBox_Estreia";
            this.txBox_Estreia.Size = new System.Drawing.Size(135, 23);
            this.txBox_Estreia.TabIndex = 6;
            this.txBox_Estreia.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cbBox_Categoria
            // 
            this.cbBox_Categoria.BackColor = System.Drawing.Color.DarkRed;
            this.cbBox_Categoria.ForeColor = System.Drawing.SystemColors.Window;
            this.cbBox_Categoria.FormattingEnabled = true;
            this.cbBox_Categoria.Items.AddRange(new object[] {
            "Terror",
            "Romance",
            "Comédia",
            "Ficção ",
            "Animação",
            "Ação ",
            "Suspense",
            "Drama"});
            this.cbBox_Categoria.Location = new System.Drawing.Point(176, 115);
            this.cbBox_Categoria.Name = "cbBox_Categoria";
            this.cbBox_Categoria.Size = new System.Drawing.Size(135, 23);
            this.cbBox_Categoria.TabIndex = 7;
            // 
            // txBox_Duracao
            // 
            this.txBox_Duracao.BackColor = System.Drawing.Color.DarkRed;
            this.txBox_Duracao.ForeColor = System.Drawing.SystemColors.Window;
            this.txBox_Duracao.Location = new System.Drawing.Point(12, 169);
            this.txBox_Duracao.Name = "txBox_Duracao";
            this.txBox_Duracao.Size = new System.Drawing.Size(135, 23);
            this.txBox_Duracao.TabIndex = 8;
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Cadastrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cadastrar.Location = new System.Drawing.Point(88, 220);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(141, 29);
            this.btn_Cadastrar.TabIndex = 9;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = false;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // TelaCadastroFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(323, 261);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.txBox_Duracao);
            this.Controls.Add(this.cbBox_Categoria);
            this.Controls.Add(this.txBox_Estreia);
            this.Controls.Add(this.txBox_Filme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaCadastroFilme";
            this.Text = "Netflix";
            this.Load += new System.EventHandler(this.TelaCadastroFilme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txBox_Filme;
        private TextBox txBox_Estreia;
        private ComboBox cbBox_Categoria;
        private TextBox txBox_Duracao;
        private Button btn_Cadastrar;
    }
}