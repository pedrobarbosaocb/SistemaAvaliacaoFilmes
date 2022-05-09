namespace SistemaAvalFilmes
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblSinopse = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxFilmes = new System.Windows.Forms.ComboBox();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAnoLancamento = new System.Windows.Forms.TextBox();
            this.txtSinopse = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNovoNota = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.txtNovoGenero = new System.Windows.Forms.TextBox();
            this.txtNovoSinopse = new System.Windows.Forms.TextBox();
            this.txtNovoAnoLancamento = new System.Windows.Forms.TextBox();
            this.txtNovoTitulo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(18, 12);
            this.lblTitulo.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(53, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(19, 345);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(26, 13);
            this.lblAno.TabIndex = 1;
            this.lblAno.Text = "Ano";
            // 
            // lblSinopse
            // 
            this.lblSinopse.AutoSize = true;
            this.lblSinopse.Location = new System.Drawing.Point(18, 67);
            this.lblSinopse.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblSinopse.Name = "lblSinopse";
            this.lblSinopse.Size = new System.Drawing.Size(45, 13);
            this.lblSinopse.TabIndex = 2;
            this.lblSinopse.Text = "Sinopse";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(62, 345);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 3;
            this.lblGenero.Text = "Gênero";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(279, 345);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(30, 13);
            this.lblNota.TabIndex = 4;
            this.lblNota.Text = "Nota";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblNota);
            this.panel1.Controls.Add(this.buttonEditar);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.lblGenero);
            this.panel1.Controls.Add(this.lblAno);
            this.panel1.Controls.Add(this.lblSinopse);
            this.panel1.Location = new System.Drawing.Point(12, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 407);
            this.panel1.TabIndex = 5;
            // 
            // comboBoxFilmes
            // 
            this.comboBoxFilmes.FormattingEnabled = true;
            this.comboBoxFilmes.Location = new System.Drawing.Point(12, 38);
            this.comboBoxFilmes.Name = "comboBoxFilmes";
            this.comboBoxFilmes.Size = new System.Drawing.Size(198, 21);
            this.comboBoxFilmes.TabIndex = 6;
            this.comboBoxFilmes.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilmes_SelectedIndexChanged);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(21, 372);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(287, 23);
            this.buttonEditar.TabIndex = 7;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(216, 36);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(121, 23);
            this.buttonAdicionar.TabIndex = 8;
            this.buttonAdicionar.Text = "Adicionar Novo Filme";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pesquisar Filme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Avaliação:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtNota);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.txtGenero);
            this.panel2.Controls.Add(this.txtSinopse);
            this.panel2.Controls.Add(this.txtAnoLancamento);
            this.panel2.Controls.Add(this.txtTitulo);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(345, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 407);
            this.panel2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Avaliação:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nota";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(219, 372);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Salvar Alterações";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 12);
            this.label5.MaximumSize = new System.Drawing.Size(300, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Título";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Gênero";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 67);
            this.label8.MaximumSize = new System.Drawing.Size(300, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Sinopse";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(21, 3);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(288, 26);
            this.txtTitulo.TabIndex = 9;
            // 
            // txtAnoLancamento
            // 
            this.txtAnoLancamento.Location = new System.Drawing.Point(21, 338);
            this.txtAnoLancamento.Name = "txtAnoLancamento";
            this.txtAnoLancamento.Size = new System.Drawing.Size(89, 20);
            this.txtAnoLancamento.TabIndex = 10;
            // 
            // txtSinopse
            // 
            this.txtSinopse.Location = new System.Drawing.Point(22, 59);
            this.txtSinopse.Multiline = true;
            this.txtSinopse.Name = "txtSinopse";
            this.txtSinopse.Size = new System.Drawing.Size(287, 275);
            this.txtSinopse.TabIndex = 11;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(121, 338);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(82, 20);
            this.txtGenero.TabIndex = 12;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button4.Location = new System.Drawing.Point(22, 372);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(279, 340);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(30, 20);
            this.txtNota.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button1.Location = new System.Drawing.Point(121, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Remover";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtNovoSinopse);
            this.panel3.Controls.Add(this.txtNovoNota);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.txtNovoGenero);
            this.panel3.Controls.Add(this.txtNovoAnoLancamento);
            this.panel3.Controls.Add(this.txtNovoTitulo);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(345, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(327, 407);
            this.panel3.TabIndex = 16;
            // 
            // txtNovoNota
            // 
            this.txtNovoNota.Location = new System.Drawing.Point(279, 340);
            this.txtNovoNota.Name = "txtNovoNota";
            this.txtNovoNota.Size = new System.Drawing.Size(30, 20);
            this.txtNovoNota.TabIndex = 14;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button6.Location = new System.Drawing.Point(22, 372);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "Cancelar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtNovoGenero
            // 
            this.txtNovoGenero.Location = new System.Drawing.Point(110, 338);
            this.txtNovoGenero.Name = "txtNovoGenero";
            this.txtNovoGenero.Size = new System.Drawing.Size(82, 20);
            this.txtNovoGenero.TabIndex = 12;
            // 
            // txtNovoSinopse
            // 
            this.txtNovoSinopse.Location = new System.Drawing.Point(22, 59);
            this.txtNovoSinopse.Multiline = true;
            this.txtNovoSinopse.Name = "txtNovoSinopse";
            this.txtNovoSinopse.Size = new System.Drawing.Size(287, 275);
            this.txtNovoSinopse.TabIndex = 11;
            // 
            // txtNovoAnoLancamento
            // 
            this.txtNovoAnoLancamento.Location = new System.Drawing.Point(21, 338);
            this.txtNovoAnoLancamento.Name = "txtNovoAnoLancamento";
            this.txtNovoAnoLancamento.Size = new System.Drawing.Size(83, 20);
            this.txtNovoAnoLancamento.TabIndex = 10;
            // 
            // txtNovoTitulo
            // 
            this.txtNovoTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovoTitulo.Location = new System.Drawing.Point(21, 3);
            this.txtNovoTitulo.Name = "txtNovoTitulo";
            this.txtNovoTitulo.Size = new System.Drawing.Size(288, 26);
            this.txtNovoTitulo.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Avaliação:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(279, 345);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Nota";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(219, 372);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "Salvar Alterações";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 12);
            this.label11.MaximumSize = new System.Drawing.Size(300, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Título";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 67);
            this.label14.MaximumSize = new System.Drawing.Size(300, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Sinopse";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.comboBoxFilmes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblSinopse;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxFilmes;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtSinopse;
        private System.Windows.Forms.TextBox txtAnoLancamento;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNovoNota;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtNovoGenero;
        private System.Windows.Forms.TextBox txtNovoSinopse;
        private System.Windows.Forms.TextBox txtNovoAnoLancamento;
        private System.Windows.Forms.TextBox txtNovoTitulo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
    }
}

