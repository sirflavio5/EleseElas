using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleseElas_classes
{
    class Carta
    {
        public string nomePessoa, genero, habilitacoes, experiencia, profissao;
        public int idade, pontos;
        public Bitmap foto;


        //Adicionar ao baralho
        public void Adicionar(List<Carta> baralho, String nome, String genero, int idade, String profissao, String habilitacoes, String experiencia, String imagem, int pontos)
        {
            if (imagem == "")
                foto = null;
            else
                foto = new Bitmap(imagem);

            //Adicionar a carta á lista
            baralho.Add(new Carta()
            {
                nomePessoa = nome,
                genero = genero,
                idade = idade,
                profissao = profissao,
                habilitacoes = habilitacoes,
                experiencia = experiencia,
                foto = foto,
                pontos = pontos
            });
        }

        //eliminar do baralho as duas cartas do baralho
        public void Eliminar(List<Carta> baralho, int pessoaAtual)
        {
            // remover do baralho as cartas
            baralho.RemoveAt(pessoaAtual);
            baralho.RemoveAt(pessoaAtual);
        }

        //Modificar as cartas selecionadas do baralho
        public void Modificar(List<Carta> baralho, int pessoaAtual, String nome, String genero, int idade, String profissao, String habilitacoes, String experiencia, int pontos)
        {
            baralho[pessoaAtual].nomePessoa = nome;
            baralho[pessoaAtual].genero = genero;
            baralho[pessoaAtual].idade = idade;
            baralho[pessoaAtual].profissao = profissao;
            baralho[pessoaAtual].habilitacoes = habilitacoes;
            baralho[pessoaAtual].experiencia = experiencia;
            baralho[pessoaAtual].pontos = pontos;
        }
    }
}
