using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integradora
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }

        private void Btn_Rojo_Click(object sender, EventArgs e)
        {
            SERIAL.Open();
            SERIAL.Write("3");
            SERIAL.Close();
        }

        private void Btn_Verde_Click(object sender, EventArgs e)
        {
            SERIAL.Open();
            SERIAL.Write("1");
            SERIAL.Close();
        }

        private void Btn_Amarillo_Click(object sender, EventArgs e)
        {
            SERIAL.Open();
            SERIAL.Write("2");
            SERIAL.Close();
        }
    }
}
