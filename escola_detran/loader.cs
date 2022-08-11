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
    public partial class loader : Form
    {
        public loader()
        {
            InitializeComponent();
        }

        private void loader_Load(object sender, EventArgs e)
        {
            banco.loader_verify();
            if (banco.verified == true)
            {
                Form inicio = new Detran();
                inicio.ShowDialog();
            }
        }
    }
}
