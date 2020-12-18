using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_3_LISTA_1_V2
{
    class Quadrado
    {
        #region atributos
        private double diagonal;
        private double area;
        #endregion
        #region construtor
        public Quadrado() 
        {
            diagonal = 0;
            calcularArea();
        }
        #endregion
        #region set e gets
        public void setDiagonal(double diagonal)
        {
            this.diagonal =diagonal;
        }
        public double getDiagonal()
        {
            return diagonal;
        }
        public double getArea()
        {
            return area;
        }
        #endregion
        #region metodos
        public void calcularArea()
        {
            area = Math.Pow(diagonal, 2) / 2;
        }
        #endregion
    }
}
