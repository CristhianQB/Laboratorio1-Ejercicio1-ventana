using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio1_Ejercicio1_ventana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float fahren = float.Parse(txtb.Text);
            float celsius = (fahren - 32) * 5 / 9;
            lbl3.Text = celsius.ToString();
        }
    }
}
