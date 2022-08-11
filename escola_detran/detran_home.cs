using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace escola_detran
{
    public partial class detran_home : Form
    {
        public detran_home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (banco.funcionario != true) { 
            banco.funcionario = true;
            button1.Text = "Ser Demitido";
            }
            else
            {
                banco.funcionario = false;
                button1.Text = "Virar Funcionario!";
            }
        }
    }
}
