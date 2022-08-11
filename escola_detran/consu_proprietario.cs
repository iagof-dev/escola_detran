using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace escola_detran
{
    public partial class consu_proprietario : Form
    {
        public consu_proprietario()
        {
            InitializeComponent();
            label5.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (cbox_busca.SelectedItem == null & sea_txt.Text == null)
            {
                MessageBox.Show("Preencha todos os campos.");
            }
            else {
                label5.Visible = true;
                label5.Text = "Pesquisando...";
                Thread.Sleep(1000);
                try
                {
                    banco.get_prop(sea_txt.Text, cbox_busca.SelectedItem);
                    string resultado = "Nome: " + banco.proprietario[1] + "\nCpf: " + banco.proprietario[2] + "\nCNH: " + banco.proprietario[3] + "\nEndereco: " + banco.proprietario[4] + "\nNumero: " + banco.proprietario[5] + "\nComplemento: " + banco.proprietario[6] + "\nBairro: " + banco.proprietario[7] + "\nCEP: " + banco.proprietario[2] + "\nEstado: " + banco.proprietario[13] + "\nCadastro: " + banco.proprietario[9] + "\nVeiculo: " + banco.proprietario[10] + "\nGenero: " + banco.proprietario[11] + "\nCidade: " + banco.proprietario[12] + "\nCNH Validade: " + banco.proprietario[15];
                    label5.Text = resultado;

                    banco.get_veh(banco.proprietario[10], "id");

                    if (banco.vehicle[3] == "0")
                    {
                        banco.vehicle[3] = "Não há multas registradas";
                    }

                    string vehiclefvzdsa = "Placa: " + banco.vehicle[1] + "\n" + 
                    "Cadastro:" + banco.vehicle[2] + "\n" +
                    "Multas: " + banco.vehicle[3] + "\n" +
                    "Modelo: " + banco.vehicle[6] + " " + banco.vehicle[4] + "\n" +
                    "Cor: " + banco.vehicle[5];
                    label6.Text = vehiclefvzdsa;
                }
                catch(Exception f)
                {
                    MessageBox.Show(f + "");
                }

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
