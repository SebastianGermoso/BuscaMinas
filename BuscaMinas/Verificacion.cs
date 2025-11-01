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
        

        public void VerificarCasillaCercanas(int fila, int columna, Button boton, List<(int,int)> posiciones)
        {
            
            if (fila == 0 || fila == 9 || columna == 0 || columna == 9)
            {


            }
            else
            {
                Comprovacion(fila, columna, boton, posiciones);

                
            }

        }

        public void Comprovacion(int fila, int columna, Button botonPresionado, List<(int, int)> posicionesC)
        {

            cantidadMinas = 0;
            for (int i = fila - 1; i <= fila + 1; i++)
            {
                for (int j = columna - 1; j <= columna + 1; j++)
                {
                    if ((i + j) != (fila + columna))
                    {
                        bool esmina = EsMina(i, j, posicionesC);
                        if (esmina == true)
                        {
                            cantidadMinas += 1;
                        }

                    }
                }
            }
            if (cantidadMinas > 0) { botonPresionado.Text = cantidadMinas.ToString(); }
        }
        public bool EsMina(int fila, int columna, List<(int, int)> minasPosicion)
        {
            MessageBox.Show(minasPosicion.Count.ToString());
            return minasPosicion.Contains((fila, columna));
        }
    }


}
