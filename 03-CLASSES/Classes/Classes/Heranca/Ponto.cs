using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Heranca
{
    public class Ponto
    {
        public int x, y;
        private int distancia;

        public Ponto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        protected void CalcularDistancia()
        {
            //Faz alfguma coisa....
        }

        private void CalcularDistancia2()
        {
            //Faz alfguma coisa....
        }

        public virtual void CalcularDistancia3()
        {
            //Faz alfguma coisa....
        }
    }
}
