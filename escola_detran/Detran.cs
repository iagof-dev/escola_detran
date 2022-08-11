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
    public partial class Detran : Form
    {
        public Detran()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Detran_Load(object sender, EventArgs e)
        {
            Form home = new detran_home();
            banco.setform(home, pan_form);
        }

        private void proprietarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (banco.funcionario == true) {
                Form proprietario = new consu_proprietario();
            banco.setform(proprietario, pan_form);
            }
            else
            {
                MessageBox.Show("Você não é funcionario!", "Detran SP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Detran_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void veiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (banco.funcionario == true)
            {
                Form proprietario = new detran_veh();
                banco.setform(proprietario, pan_form);
            }
            else
            {
                MessageBox.Show("Você não é funcionario!", "Detran SP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
