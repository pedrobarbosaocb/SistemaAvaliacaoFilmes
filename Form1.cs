using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAvalFilmes
{
    public partial class Form1 : Form
    {
        FilmeRepository filmes = new FilmeRepository();
        Filme filmeSelecionado = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel2.Visible = false;
            ReloadMainPanel();
            ReloadComboBox();
        }

        public void ReloadMainPanel()
        {
            filmeSelecionado = filmes.Last();
            if (comboBoxFilmes.Text != "")
            {
                try
                {
                    filmeSelecionado = filmes.BuscaFilme(comboBoxFilmes.Text);
                }
                catch (Exception ex)
                {
                    filmeSelecionado = filmes.BuscaFilme(comboBoxFilmes.Items[0].ToString());
                }
            } 
           
            lblTitulo.Text = filmeSelecionado.Nome;
            lblAno.Text = filmeSelecionado.AnoLancamento.ToString();
            lblSinopse.Text = filmeSelecionado.Sinopse.ToString();
            lblGenero.Text = filmeSelecionado.Genero.ToString();
            lblNota.Text = $"{ filmeSelecionado.Nota} / 10";
        }

        private void comboBoxFilmes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadMainPanel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            comboBoxFilmes.Enabled = false;
            buttonEditar.Enabled = false;
            buttonAdicionar.Enabled = false;

            txtTitulo.Text = filmeSelecionado.Nome;
            txtAnoLancamento.Text = filmeSelecionado.AnoLancamento.ToString();
            txtSinopse.Text = filmeSelecionado.Sinopse.ToString();
            txtGenero.Text = filmeSelecionado.Genero;
            txtNota.Text = filmeSelecionado.Nota.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            comboBoxFilmes.Enabled = true;
            buttonEditar.Enabled = true;
            buttonAdicionar.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                filmeSelecionado.Nome = txtTitulo.Text;
                filmeSelecionado.Sinopse = txtSinopse.Text;
                filmeSelecionado.AnoLancamento = int.Parse(txtAnoLancamento.Text);
                filmeSelecionado.Genero = txtGenero.Text;
                filmeSelecionado.Nota = double.Parse(txtNota.Text);

                filmes.UpdateFilme(filmeSelecionado);

                panel2.Visible = false;
                comboBoxFilmes.Enabled = true;
                buttonEditar.Enabled = true;
                buttonAdicionar.Enabled = true;

                ReloadComboBox();
                ReloadMainPanel();
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ReloadComboBox()
        {
            comboBoxFilmes.Items.Clear();
            var filmesArray = filmes.ToArray();
            for (int i = 0; i < filmesArray.Length; i++)
            {
                comboBoxFilmes.Items.Add(filmesArray[i].Nome);
            }
            comboBoxFilmes.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonAdicionar.Enabled = false;
            buttonEditar.Enabled = false;
            panel3.Visible = true;
            comboBoxFilmes.Enabled = false;

            txtNovoNota.Text = string.Empty;
            txtNovoAnoLancamento.Text = string.Empty;
            txtNovoGenero.Text = string.Empty;
            txtNovoSinopse.Text = string.Empty;
            txtNovoTitulo.Text = string.Empty;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            filmes.RemoveFilme(filmeSelecionado);

            panel2.Visible = false;
            comboBoxFilmes.Enabled = true;
            buttonEditar.Enabled = true;
            buttonAdicionar.Enabled = true;

            ReloadComboBox();
            ReloadMainPanel();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            buttonAdicionar.Enabled = true;
            buttonEditar.Enabled = true;
            comboBoxFilmes.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                filmes.AddFilme(txtNovoTitulo.Text, txtNovoGenero.Text, int.Parse(txtNovoAnoLancamento.Text), txtNovoSinopse.Text, double.Parse(txtNovoNota.Text));
                panel3.Visible = false;
                buttonAdicionar.Enabled = true;
                buttonEditar.Enabled = true;
                comboBoxFilmes.Enabled = true;
            } catch (Exception ex)
            {
                MessageBox.Show("Insira todos os campos");
            }
            
            ReloadComboBox();
            ReloadMainPanel();
        }
    }
}
