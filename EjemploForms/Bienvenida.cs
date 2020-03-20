using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploForms
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void inicio_Click(object sender, EventArgs e)
        {
            //oculto esta ventana
            this.Hide();
            VentanaPrincipal ventana = new VentanaPrincipal();
            ventana.Show();
        }
    }
}
