using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (Conexion.getConexion() != null)
                MessageBox.Show("conexion exitosa");
            else
                MessageBox.Show("conexion fallida");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
