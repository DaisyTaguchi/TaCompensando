using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaCompencando
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
           
        }

        private void TextBoxRelEtanolGas_TextChanged(object sender, EventArgs e)
        {
            if (Text == "Etanol")
                MessageBox.Show("Tá compensando Etanol");
            else
                MessageBox.Show("Tá compensando Gasolina");
        }

        private void TextBoxEtanol_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelPrLitroGasolina_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEtanol_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRelEtanolGas_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxResEtanol_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
