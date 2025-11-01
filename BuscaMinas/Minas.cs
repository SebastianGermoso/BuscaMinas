using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaMinas
{


    internal class Minas
    {
        public List<(int, int)> posicionMinas = new List<(int, int)>();
        
        public void PosicionesMina(int filas, int columnas, int catidadMinas)
        {
            Random random = new Random();
            while(posicionMinas.Count < catidadMinas)
            {
                int fila = random.Next(filas);
                int columna = random.Next(columnas);
                posicionMinas.Add((fila, columna));
            }
            MessageBox.Show(posicionMinas[0].Item1 + ", " + posicionMinas[0].Item2);
        }

        
    }
}
