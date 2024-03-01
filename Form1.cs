using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private  void MostrarPrecio()
        {
            int[] arreglo = { 150, 200, 500, 80, 120, 550, 170, 192,560,100, 199, 85, 450, 666, 699, 5000, 809, 127, 168, 497, 356, 215, 3489,134,556, 157, 2050, 5330, 807, 191, 540, 1704, 1972, 5610, 1014, 1999, 8215, 4570, 676, 689, 5560, 819, 167, 148, 457, 316, 295, 3289, 144, 516 };
            string cadena = "";
            foreach (int num in arreglo)
            {
             cadena = cadena + " " + num;

            }
            lbArregloPrecio.Text = cadena.ToString();
        }
    }
}
