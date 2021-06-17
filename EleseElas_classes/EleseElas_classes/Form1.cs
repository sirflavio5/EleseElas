using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EleseElas_classes
{
    public partial class Form1 : Form
    {

        int pessoaAtual;
        int pontosfinais;
        //caminho para o ficheiro
        readonly string path = "people.csv";
        readonly string pathCuriosidades = "curiosidades.csv";
        Ficheiro ficheiro = new Ficheiro();
        Carta carta = new Carta();
        List<Carta> baralho = new List<Carta>();
        Curiosidades curiosidades = new Curiosidades();
        List<Curiosidades> listaCuriosidades = new List<Curiosidades>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ficheiro.LerFicheiro(baralho, carta, path);
            ficheiro.LerFicheiroCuriosidades(listaCuriosidades, curiosidades, pathCuriosidades);
            EsconderTudo();
            lbltextos.Visible = true;
            lbltextos.Text = "Escolhe a pessoa mais indica para a profissão que aparece. Carrega no botão JOGAR! Boa sorte.";

        }

        //validação de campos para quando adicionarmos não irem vazios
        private bool CheckErrors()
        {
            if (string.IsNullOrWhiteSpace(textBox_nome1.Text))
            {
                textBox_nome1.Focus();
                errorProvider1.SetError(textBox_nome1, "Preencha este campo");
                return false;
            }
            else
                errorProvider1.SetError(textBox_nome1, "");

            if (string.IsNullOrWhiteSpace(textBox_genero1.Text))
            {
                textBox_genero1.Focus();
                errorProvider1.SetError(textBox_genero1, "Preencha este campo");
                return false;
            }
            else
                errorProvider1.SetError(textBox_genero1, "");

            if (string.IsNullOrWhiteSpace(textBox_idade1.Text))
            {
                textBox_idade1.Focus();
                errorProvider1.SetError(textBox_idade1, "Preencha este campo");
                return false;
            }
            else
                errorProvider1.SetError(textBox_idade1, "");

            if (string.IsNullOrWhiteSpace(textBoxProfissao.Text))
            {
                textBoxProfissao.Focus();
                errorProvider1.SetError(textBoxProfissao, "Preencha este campo");
                return false;
            }
            else
                errorProvider1.SetError(textBoxProfissao, "");

            if (string.IsNullOrWhiteSpace(textBox_habilitacoes1.Text))
            {
                textBox_habilitacoes1.Focus();
                errorProvider1.SetError(textBox_habilitacoes1, "Preencha este campo");
                return false;
            }
            else
                errorProvider1.SetError(textBox_habilitacoes1, "");

            if (string.IsNullOrWhiteSpace(textBox_experiencia1.Text))
            {
                textBox_experiencia1.Focus();
                errorProvider1.SetError(textBox_experiencia1, "Preencha este campo");
                return false;
            }
            else
                errorProvider1.SetError(textBox_experiencia1, "");

            if (string.IsNullOrWhiteSpace(textBox_nome2.Text))
            {
                textBox_nome2.Focus();
                errorProvider1.SetError(textBox_nome2, "Preencha este campo");
                return false;
            }
            else
                errorProvider1.SetError(textBox_nome2, "");

            if (string.IsNullOrWhiteSpace(textBox_genero2.Text))
            {
                textBox_genero2.Focus();
                errorProvider1.SetError(textBox_genero2, "Preencha este campo");
                return false;
            }
            else
                errorProvider1.SetError(textBox_genero2, "");

            if (string.IsNullOrWhiteSpace(textBox_idade2.Text))
            {
                textBox_idade2.Focus();
                errorProvider1.SetError(textBox_idade2, "Preencha este campo");
                return false;
            }
            else
                errorProvider1.SetError(textBox_idade2, "");

            if (string.IsNullOrWhiteSpace(textBox_habilitacoes2.Text))
            {
                textBox_habilitacoes2.Focus();
                errorProvider1.SetError(textBox_habilitacoes2, "Preencha este campo");
                return false;
            }
            else
                errorProvider1.SetError(textBox_habilitacoes2, "");

            if (string.IsNullOrWhiteSpace(textBox_experiencia2.Text))
            {
                textBox_experiencia2.Focus();
                errorProvider1.SetError(textBox_experiencia2, "Preencha este campo");
                return false;
            }
            else
                errorProvider1.SetError(textBox_experiencia2, "");

            return true;
        }

        #region panel

        private void Panel1_Click(object sender, EventArgs e)
        {
            panelcarta1.BorderStyle = BorderStyle.FixedSingle;
            panelcarta2.BorderStyle = BorderStyle.None;
            buttonEscolher.Enabled = true;
        }

        private void Panel2_Click(object sender, EventArgs e)
        {
            panelcarta1.BorderStyle = BorderStyle.None;
            panelcarta2.BorderStyle = BorderStyle.FixedSingle;
            buttonEscolher.Enabled = true;
        }

        #endregion

        private void EsconderTudo()
        {
            //Paineis
            panelcarta1.Visible = false;
            panelcarta2.Visible = false;
            //TextBox
            textBox_experiencia1.Visible = false;
            textBox_experiencia2.Visible = false;
            textBox_genero1.Visible = false;
            textBox_genero2.Visible = false;
            textBox_habilitacoes1.Visible = false;
            textBox_habilitacoes2.Visible = false;
            textBox_idade1.Visible = false;
            textBox_idade2.Visible = false;
            textBox_nome1.Visible = false;
            textBox_nome2.Visible = false;
            textBoxPontos1.Visible = false;
            textBoxPontos2.Visible = false;
            textBoxProfissao.Visible = false;
            //Label
            labelPontos.Visible = false;
            labelPontos2.Visible = false;
            labelExperiencia1.Visible = false;
            labelExperiencia2.Visible = false;
            labelGenero1.Visible = false;
            labelGenero2.Visible = false;
            labelHabilitacoes1.Visible = false;
            labelHabilitacoes2.Visible = false;
            labelidade1.Visible = false;
            labelidade2.Visible = false;
            labelNome1.Visible = false;
            labelNome2.Visible = false;
            nomePessoa1.Visible = false;
            nomePessoa2.Visible = false;
            idadePessoa1.Visible = false;
            idadePessoa2.Visible = false;
            generoPessoa1.Visible = false;
            generoPessoa2.Visible = false;
            habilitacoesPessoa1.Visible = false;
            habilitacoesPessoa2.Visible = false;
            experienciaPessoa1.Visible = false;
            experienciaPessoa2.Visible = false;
            pontosPessoa1.Visible = false;
            pontosPessoa2.Visible = false;
            lbltextos.Visible = false;
            lblProfissao.Visible = false;
            lblsabiasque.Visible = false;
            //Butoes
            buttonEscolher.Visible = false;
            buttonAdicionar.Visible = false;
            buttonEliminar.Visible = false;
            buttonNext.Visible = false;
            buttonPrev.Visible = false;
            btnOK.Visible = false;
            buttonModificar.Visible = false;
            //Imagens
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
        }

        private void ExibirCartas(int cartaAmostrar)
        {
            panelcarta1.BorderStyle = BorderStyle.None;
            panelcarta2.BorderStyle = BorderStyle.None;


            lblProfissao.Text = baralho[cartaAmostrar].profissao;

            nomePessoa2.Text = baralho[cartaAmostrar].nomePessoa;
            idadePessoa2.Text = baralho[cartaAmostrar].idade.ToString();
            generoPessoa2.Text = baralho[cartaAmostrar].genero;
            habilitacoesPessoa2.Text = baralho[cartaAmostrar].habilitacoes;
            experienciaPessoa2.Text = baralho[cartaAmostrar].experiencia;
            pontosPessoa2.Text = baralho[cartaAmostrar].pontos.ToString();
            pictureBox2.Image = baralho[cartaAmostrar].foto;

            nomePessoa1.Text = baralho[cartaAmostrar + 1].nomePessoa;
            idadePessoa1.Text = baralho[cartaAmostrar + 1].idade.ToString();
            generoPessoa1.Text = baralho[cartaAmostrar + 1].genero;
            habilitacoesPessoa1.Text = baralho[cartaAmostrar + 1].habilitacoes;
            experienciaPessoa1.Text = baralho[cartaAmostrar + 1].experiencia;
            pontosPessoa1.Text = baralho[cartaAmostrar + 1].pontos.ToString();
            pictureBox1.Image = baralho[cartaAmostrar + 1].foto;



        }

        private void Jogar_Click(object sender, EventArgs e)
        {
            EsconderTudo();
            pontosfinais = 0;
            if (baralho.Count > 0)
            {
                MostrarCaixasJogo();
                pessoaAtual = 0;
                ExibirCartas(pessoaAtual);
            }
            else
            {
                lbltextos.Visible = true;
                lbltextos.Text = "Não existem cartas disponiveis";
            }

        }

        private void MenuItemModificarCartoes_Click(object sender, EventArgs e)
        {
            EsconderTudo();
            if (baralho.Count > 0)
            {
                panelcarta1.Visible = true;
                panelcarta2.Visible = true;
                lblProfissao.Visible = true;
                buttonModificar.Visible = true;
                buttonNext.Visible = true;
                buttonPrev.Visible = true;
                labelPontos.Visible = true;
                labelPontos2.Visible = true;
                labelExperiencia1.Visible = true;
                labelExperiencia2.Visible = true;
                labelGenero1.Visible = true;
                labelGenero2.Visible = true;
                labelHabilitacoes1.Visible = true;
                labelHabilitacoes2.Visible = true;
                labelidade1.Visible = true;
                labelidade2.Visible = true;
                labelNome1.Visible = true;
                labelNome2.Visible = true;
                nomePessoa1.Visible = true;
                nomePessoa2.Visible = true;
                idadePessoa1.Visible = true;
                idadePessoa2.Visible = true;
                generoPessoa1.Visible = true;
                generoPessoa2.Visible = true;
                habilitacoesPessoa1.Visible = true;
                habilitacoesPessoa2.Visible = true;
                experienciaPessoa1.Visible = true;
                experienciaPessoa2.Visible = true;
                pontosPessoa1.Visible = true;
                pontosPessoa2.Visible = true;
                pessoaAtual = 0;
                ExibirCartas(pessoaAtual);
            }
            else
            {
                lbltextos.Visible = true;
                lbltextos.Text = "Não existem cartas disponiveis";
            }
        }

        private void MenuItemEliminar_Click(object sender, EventArgs e)
        {
            EsconderTudo();
            if (baralho.Count > 0)
            {
                panelcarta1.Visible = true;
                panelcarta2.Visible = true;
                lblProfissao.Visible = true;
                buttonEliminar.Visible = true;
                buttonNext.Visible = true;
                buttonPrev.Visible = true;
                labelPontos.Visible = true;
                labelPontos2.Visible = true;
                labelExperiencia1.Visible = true;
                labelExperiencia2.Visible = true;
                labelGenero1.Visible = true;
                labelGenero2.Visible = true;
                labelHabilitacoes1.Visible = true;
                labelHabilitacoes2.Visible = true;
                labelidade1.Visible = true;
                labelidade2.Visible = true;
                labelNome1.Visible = true;
                labelNome2.Visible = true;
                nomePessoa1.Visible = true;
                nomePessoa2.Visible = true;
                idadePessoa1.Visible = true;
                idadePessoa2.Visible = true;
                generoPessoa1.Visible = true;
                generoPessoa2.Visible = true;
                habilitacoesPessoa1.Visible = true;
                habilitacoesPessoa2.Visible = true;
                experienciaPessoa1.Visible = true;
                experienciaPessoa2.Visible = true;
                pontosPessoa1.Visible = true;
                pontosPessoa2.Visible = true;
                pessoaAtual = 0;
                ExibirCartas(pessoaAtual);
            }
            else
            {
                lbltextos.Visible = true;
                lbltextos.Text = "Não existem cartas disponiveis";
            }
        }

        private void MenuItemAdicionar_Click(object sender, EventArgs e)
        {
            EsconderTudo();
            panelcarta1.Visible = true;
            panelcarta2.Visible = true;
            textBoxProfissao.Visible = true;
            textBox_experiencia1.Visible = true;
            textBox_experiencia2.Visible = true;
            textBox_genero1.Visible = true;
            textBox_genero2.Visible = true;
            textBox_habilitacoes1.Visible = true;
            textBox_habilitacoes2.Visible = true;
            textBox_idade1.Visible = true;
            textBox_idade2.Visible = true;
            textBox_nome1.Visible = true;
            textBox_nome2.Visible = true;
            textBoxPontos1.Visible = true;
            textBoxPontos2.Visible = true;
            textBoxProfissao.Text = "";
            textBox_experiencia1.Text = "";
            textBox_experiencia2.Text = "";
            textBox_genero1.Text = "";
            textBox_genero2.Text = "";
            textBox_habilitacoes1.Text = "";
            textBox_habilitacoes2.Text = "";
            textBox_idade1.Text = "";
            textBox_idade2.Text = "";
            textBox_nome1.Text = "";
            textBox_nome2.Text = "";
            textBoxPontos1.Text = "";
            textBoxPontos2.Text = "";
            labelPontos.Visible = true;
            labelPontos2.Visible = true;
            labelExperiencia1.Visible = true;
            labelExperiencia2.Visible = true;
            labelGenero1.Visible = true;
            labelGenero2.Visible = true;
            labelHabilitacoes1.Visible = true;
            labelHabilitacoes2.Visible = true;
            labelidade1.Visible = true;
            labelidade2.Visible = true;
            labelNome1.Visible = true;
            labelNome2.Visible = true;
            lblProfissao.Visible = true;
            lblProfissao.Text = "Profissão";
            buttonAdicionar.Visible = true;
        }

        private void ButtonEscolher_Click(object sender, EventArgs e)
        {
            //Botao escolher só fica disponivel depois de ser selecionado um panel
            buttonEscolher.Enabled = false;
            //Verificar qual foi o panel escolhido pelo utilizador e adicionar os pontos da carta aos pontosfinais.
            //pessoaAtual = panelcarta1
            //pessoaAtual+1 = panelcarta2
            if (panelcarta1.BorderStyle.ToString() == "FixedSingle")
                pontosfinais += baralho[pessoaAtual].pontos;
            else
                pontosfinais += baralho[pessoaAtual+1].pontos;

            if (baralho.Count > pessoaAtual + 2)
            {
                //Verificar se existem curiosidades
                if (listaCuriosidades.Count >= pessoaAtual)
                    ExibirCuriosidade();
                else
                {
                    pessoaAtual = (pessoaAtual + 2) % baralho.Count;
                    ExibirCartas(pessoaAtual);
                }
            }
            else
            {
                EsconderTudo();
                lbltextos.Visible = true;
                lbltextos.Text = "Chegou ao Final com " + pontosfinais + "pontos";
            }
        }

        private void ExibirCuriosidade()
        {
            EsconderTudo();
            lblsabiasque.Visible = true;
            lbltextos.Visible = true;
            btnOK.Visible = true;
            lbltextos.Text = listaCuriosidades[pessoaAtual].Curiosidade;
        }

        private void ButtonAdicionar_Click(object sender, EventArgs e)
        {
            if (CheckErrors())
            {
                carta.Adicionar(baralho, textBox_nome1.Text, textBox_genero1.Text, Int32.Parse(textBox_idade1.Text), textBoxProfissao.Text, textBox_habilitacoes1.Text, textBox_experiencia1.Text, "", Int32.Parse(textBoxPontos1.Text));
                carta.Adicionar(baralho, textBox_nome2.Text, textBox_genero2.Text, Int32.Parse(textBox_idade2.Text), textBoxProfissao.Text, textBox_habilitacoes2.Text, textBox_experiencia2.Text, "", Int32.Parse(textBoxPontos2.Text));
                EsconderTudo();
            }
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            pessoaAtual = (pessoaAtual + 2) % baralho.Count;
            ExibirCartas(pessoaAtual);
        }

        private void ButtonPrev_Click(object sender, EventArgs e)
        {
            pessoaAtual = (baralho.Count + pessoaAtual - 2) % baralho.Count;
            ExibirCartas(pessoaAtual);
        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            carta.Eliminar(baralho, pessoaAtual);
            EsconderTudo();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            EsconderTudo();
            MostrarCaixasJogo();
            pessoaAtual = (pessoaAtual + 2) % baralho.Count;
            ExibirCartas(pessoaAtual);
        }

        private void MostrarCaixasJogo()
        {
            panelcarta1.Visible = true;
            panelcarta2.Visible = true;
            lblProfissao.Visible = true;
            buttonEscolher.Visible = true;
            labelExperiencia1.Visible = true;
            labelExperiencia2.Visible = true;
            labelGenero1.Visible = true;
            labelGenero2.Visible = true;
            labelHabilitacoes1.Visible = true;
            labelHabilitacoes2.Visible = true;
            labelidade1.Visible = true;
            labelidade2.Visible = true;
            labelNome1.Visible = true;
            labelNome2.Visible = true;
            nomePessoa1.Visible = true;
            nomePessoa2.Visible = true;
            idadePessoa1.Visible = true;
            idadePessoa2.Visible = true;
            generoPessoa1.Visible = true;
            generoPessoa2.Visible = true;
            habilitacoesPessoa1.Visible = true;
            habilitacoesPessoa2.Visible = true;
            experienciaPessoa1.Visible = true;
            experienciaPessoa2.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (buttonModificar.Text == "Modificar")
            {
                textBoxProfissao.Visible = true;
                textBox_experiencia1.Visible = true;
                textBox_experiencia2.Visible = true;
                textBox_genero1.Visible = true;
                textBox_genero2.Visible = true;
                textBox_habilitacoes1.Visible = true;
                textBox_habilitacoes2.Visible = true;
                textBox_idade1.Visible = true;
                textBox_idade2.Visible = true;
                textBox_nome1.Visible = true;
                textBox_nome2.Visible = true;
                textBoxPontos1.Visible = true;
                textBoxPontos2.Visible = true;
                labelPontos.Visible = true;
                labelPontos2.Visible = true;
                lblProfissao.Visible = false;
                buttonNext.Visible = false;
                buttonPrev.Visible = false;
                buttonModificar.Text = "Guardar";
                textBoxProfissao.Text = lblProfissao.Text;
                textBox_experiencia1.Text = experienciaPessoa1.Text;
                textBox_experiencia2.Text = experienciaPessoa2.Text;
                textBox_genero1.Text = generoPessoa1.Text;
                textBox_genero2.Text = generoPessoa2.Text;
                textBox_habilitacoes1.Text = habilitacoesPessoa1.Text;
                textBox_habilitacoes2.Text = habilitacoesPessoa2.Text;
                textBox_idade1.Text = idadePessoa1.Text;
                textBox_idade2.Text = idadePessoa2.Text;
                textBox_nome1.Text = nomePessoa1.Text;
                textBox_nome2.Text = nomePessoa2.Text;
                textBoxPontos1.Text = pontosPessoa1.Text;
                textBoxPontos2.Text = pontosPessoa2.Text;
            }
            else if (buttonModificar.Text == "Guardar")
            {
                if (CheckErrors())
                {
                    carta.Modificar(baralho, pessoaAtual, textBox_nome1.Text, textBox_genero1.Text, Int32.Parse(textBox_idade1.Text), textBoxProfissao.Text, textBox_habilitacoes1.Text, textBox_experiencia1.Text, Int32.Parse(textBoxPontos1.Text));
                    carta.Modificar(baralho, pessoaAtual + 1, textBox_nome2.Text, textBox_genero2.Text, Int32.Parse(textBox_idade2.Text), textBoxProfissao.Text, textBox_habilitacoes2.Text, textBox_experiencia2.Text, Int32.Parse(textBoxPontos2.Text));
                    EsconderTudo();
                }
                buttonModificar.Text = "Modificar";
            }
        }

        private void guardarNosFicheirosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ficheiro.GuardarFicheiro(baralho, path);
            ficheiro.GuardarFicheiroCuriosidades(listaCuriosidades, pathCuriosidades);
            EsconderTudo();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("Guardou as alterações efectuadas? Confirma que deseja sair?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
                Application.Exit();
            else
                EsconderTudo();

        }
    }
}
