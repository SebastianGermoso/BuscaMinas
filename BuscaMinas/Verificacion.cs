using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaMinas
{
    internal class Verificacion
    {
        int cantidadMinas = 0;
        public Minas minas= new Minas();

        public void VerificarCasillaCercanas(int fila, int columna, Button boton)
        {
            if (fila == 0 || fila == 9 || columna == 0 || columna == 9)
            {


            }
            else
            {
                Comprovacion(fila, columna, boton);

                
            }

        }

        public void Comprovacion(int fila, int columna, Button botonPresionado)
        {

            cantidadMinas = 0;
            for (int i = fila - 1; i <= fila + 1; i++)
            {
                for (int j = columna - 1; j <= columna + 1; j++)
                {
                    if ((i + j) != (fila + columna))
                    {
                        bool esmina = minas.EsMina(fila, columna);
                        if (esmina == true)
                        {
                            cantidadMinas += 1;
                        }

                    }
                }
            }
            if (cantidadMinas > 0) { botonPresionado.Text = cantidadMinas.ToString(); }
        }
    }
}
