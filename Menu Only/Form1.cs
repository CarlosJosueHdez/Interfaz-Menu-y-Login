using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Only
{
    public partial class Banner : Form
    {
        public Banner()
        {
            InitializeComponent();
        }
        private void AbrirFormHija(Object FormHija)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form fh = FormHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();

        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Cuenta());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new PcProductos());
        }
    }
}
