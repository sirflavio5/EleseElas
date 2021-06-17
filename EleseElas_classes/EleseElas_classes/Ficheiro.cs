using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleseElas_classes
{
    class Ficheiro
    {

        public void LerFicheiro(List<Carta> baralho, Carta pessoa, string pathFile)
        {
            //ler o ficheiro das cartas
            string[] lines = File.ReadAllLines(pathFile);
            foreach (string line in lines)
            {
                if (line != "")
                {
                    string[] columns = line.Split(',');
                    //adiciona a linha lida do ficheiro ao baralho das cartas            
                    pessoa.Adicionar(baralho, columns[0], columns[1], Int32.Parse(columns[2]), columns[3], columns[4], columns[5], columns[6], Int32.Parse(columns[7]));
                }
            }
        }
       
        public void GuardarFicheiro(List<Carta> baralho, string pathFile)
        {
            //apagar o texto todo do ficheiro
            File.WriteAllText(pathFile, String.Empty);

            // reescrever o ficheiro consoante as pessoas q estão na lista
            String texto;
            for (int i = 0; i < baralho.Count; i++)
            {
                if (i == baralho.Count - 1)
                    texto = baralho[i].nomePessoa + "," + baralho[i].genero + "," + baralho[i].idade + "," + baralho[i].profissao + "," + baralho[i].habilitacoes + "," + baralho[i].experiencia + "," + baralho[i].foto + "," + baralho[i].pontos;
                else
                    texto = baralho[i].nomePessoa + "," + baralho[i].genero + "," + baralho[i].idade + "," + baralho[i].profissao + "," + baralho[i].habilitacoes + "," + baralho[i].experiencia + "," /*+ baralho[i].foto*/ + "," + baralho[i].pontos + Environment.NewLine;

                File.AppendAllText(pathFile, texto);
            }
        }

        public void LerFicheiroCuriosidades(List<Curiosidades> listaCuriosidades, Curiosidades curiosidade, string pathFile)
        {
            string[] lines = File.ReadAllLines(pathFile);
            foreach (string line in lines)
            {
                if (line != "")
                {
                    //adicionar à lista das profissoes uma carta nova do ficheiro das curiosidades
                    string[] columns = line.Split('+');
                    curiosidade.Adicionar(listaCuriosidades, columns[0], columns[1]);
                }
            }
        }

        public void GuardarFicheiroCuriosidades(List<Curiosidades> listaCuriosidades, string pathFile)
        {
            //apagar o texto todo do ficheiro
            File.WriteAllText(pathFile, String.Empty);

            // reescrever o ficheiro consoante as pessoas q estão na lista
            String texto;
            for (int i = 0; i < listaCuriosidades.Count; i++)
            {
                if (i == listaCuriosidades.Count - 1)
                    texto = listaCuriosidades[i].Profissao + "+" + listaCuriosidades[i].Curiosidade;
                else
                    texto = listaCuriosidades[i].Profissao + "+" + listaCuriosidades[i].Curiosidade + Environment.NewLine;

                File.AppendAllText(pathFile, texto);
            }
        }
    }
}
