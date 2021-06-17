using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleseElas_classes
{
    class Curiosidades
    {
        private string curiosidade, profissao;

        public string Profissao
        {
            get { return profissao; }
            set { profissao = value.ToString(); }
        }
        public string Curiosidade
        {
            get { return curiosidade; }
            set { curiosidade = value.ToString(); }
        }

        //Adicionar o que está no ficheiro ao baralho
        public void Adicionar(List<Curiosidades> listaCuriosidade, String nome, String texto)
        {
            //Adicionar a curiosidade á lista
            listaCuriosidade.Add(new Curiosidades()
            {
                profissao = nome,
                Curiosidade = texto
            });
        }

        public void Eliminar(List<Curiosidades> listaCuriosidade, int pessoaAtual)
        {
            // remover a curiosidade
            listaCuriosidade.RemoveAt(pessoaAtual);
        }

        //Modificar a curiosidade
        public void Modificar(List<Curiosidades> listaCuriosidade, int pessoaAtual, String nome, String texto)
        {
            listaCuriosidade[pessoaAtual].Profissao = nome;
            listaCuriosidade[pessoaAtual].Curiosidade = texto;
        }


    }
}
