using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        public bool EsMina(int fila, int columna) 
        { 
            return posicionMinas.Contains((fila, columna));
        }
    }
}
