using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Aluno alu = new Aluno();

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            alu.setNome(txtnome.Text);
            alu.setNota1(double.Parse(txtnota1.Text));
            alu.setNota2(double.Parse(txtnota2.Text));
            MessageBox.Show("Aluno Cadastrado");
        }

      

        private void btnlistar_Click_1(object sender, EventArgs e)
        {
            alu.calcularMedia();
            txtmedia.Text = Convert.ToString(alu.getMedia());
            txtnota1.Text = Convert.ToString(alu.getNota1());
            txtnota2.Text = Convert.ToString(alu.getNota2());
            txtnome.Text = alu.getNome();
            alu.verificarSituacao();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnome.Text = "";
            txtnota1.Text = "";
            txtnota2.Text = "";
            txtmedia.Text = "";
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
