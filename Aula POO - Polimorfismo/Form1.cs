using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_POO___Polimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Funcionario f = new Funcionario();
        private void btnInss_Click(object sender, EventArgs e)
        {
            f.Nome = txtNome.Text;
            f.Salario = double.Parse(txtSalario.Text);
            lblValor.Text = "Valor do INSS= " + f.Calcular().ToString();
        }

        private void btnFerias_Click(object sender, EventArgs e)
        {
            f.Nome = txtNome.Text;
            f.Salario = double.Parse(txtSalario.Text);
            lblValor.Text = "Valor das Férias= "+ f.Calcular(int.Parse(txtTempo.Text)).ToString();
        }

        private void btnComissao_Click(object sender, EventArgs e)
        {
            Vendedor v = new Vendedor();
            v.Nome = txtNome.Text;
            v.Salario=double.Parse(txtSalario.Text);
            lblValor.Text = "Valor da Comissão =" +
                v.Calcular(6).ToString();
        }
    }
}
