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
    public partial class detran_veh : Form
    {
        public detran_veh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sea_txt == null & cbox_busca.SelectedItem == null)
            {
                MessageBox.Show("Erro");
            }
            else
            {

                banco.get_veh(sea_txt.Text, cbox_busca.SelectedItem);

                string setar = "ID: " + banco.vehicle[0] + "\n" +
                    "Placa: " + banco.vehicle[1] + "\n" + 
                    "Cadastro:" + banco.vehicle[2] + "\n" +
                    "Multas: " + banco.vehicle[3] + "\n" +
                    "Modelo: " + banco.vehicle[6] + " " + banco.vehicle[4] + "\n" +
                    "Cor: " + banco.vehicle[5];

                label5.Text = setar;
            }
        }

        private void sea_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbox_busca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
