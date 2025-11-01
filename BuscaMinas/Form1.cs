using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaMinas
{
    public partial class Form1 : Form
    {
        public const int fila = 10;
        public const int columnas = 20;
        public const int hxw = 30;
        public const int cantidadDeMinas = 20;
        Minas minas = new Minas();
        Verificacion verificacion = new Verificacion();

        public Form1()
        {
            InitializeComponent();
            InicializarCuadro();
            minas.PosicionesMina(fila, columnas, cantidadDeMinas);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void InicializarCuadro()
        {
            for (int f = 0; f < fila; f++) 
            { 
                for (int c = 0; c < columnas; c++)
                {
                    Button cuadro = new Button();
                    cuadro.Width = hxw;
                    cuadro.Height = hxw;

                    cuadro.Location = new Point(c * hxw, f * hxw);

                    cuadro.Tag = $"{f},{c}";

                    cuadro.MouseDown += new MouseEventHandler(Boton_MouseDown);

                    this.Controls.Add(cuadro);
                }
            }
        }

        private void Boton_MouseDown(object sender, MouseEventArgs e)
        {
            // 1. Identificar el botón y obtener la coordenada
            Button botonClickeado = (Button)sender;

            // Obtener la cadena "f,c" del Tag y separarla
            string[] coords = botonClickeado.Tag.ToString().Split(',');
            int fila = int.Parse(coords[0]);
            int columna = int.Parse(coords[1]);

            // 2. Comprobar qué botón del ratón se usó
            if (e.Button == MouseButtons.Left)
            {
                //MessageBox.Show("izquierdo en:" + fila + ", " + columna);
                verificacion.VerificarCasillaCercanas(fila, columna, botonClickeado,minas.posicionMinas);
                
            }
            else if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Derecho en:" + fila + ", " + columna);
            }

        }
    }
}
