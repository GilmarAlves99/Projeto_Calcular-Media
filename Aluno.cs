using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularMedia
{
    class Aluno
    {

 private string nome;
        private double nota1;
        private double nota2;
        private double media;
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return nome;
        }
        public void setNota1(double nota1)
        {
            this.nota1 = nota1;
        }
        public double getNota1()
        {
            return nota1;
        }
        public void setNota2(double nota2)
        {
            this.nota2 = nota2;
        }
        public double getNota2()
        {
            return nota2;
        }
        public void setMedia(double media)
        {
            this.media = media;
        }
        public double getMedia()
        {
            return media;
        }
        public void calcularMedia()
        {
            media = ((nota1 + nota2) / 2);
        }
        public void verificarSituacao()
        {
            if (media < 3)
            {
                MessageBox.Show("Aluno " + nome + " : Reprovado \n Média : " + media);
            }
            if ((media >= 3) && (media <= 6))
            {
                MessageBox.Show("Aluno " + nome + " : em Exame \n Média : " + media);
            }
            if (media > 6)
            {
                MessageBox.Show("Aluno " + nome + " : Aprovado \n Média : " + media);
            }
        }
    }
}
