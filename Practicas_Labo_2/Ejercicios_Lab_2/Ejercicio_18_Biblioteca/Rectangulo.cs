using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace Geometria
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto p1,Punto p3)
        {

            this.vertice1 = p1;
            this.vertice3 = p3;

            this.vertice2 = new Punto(p1.GetX(), p3.GetY());
            this.vertice4 = new Punto(p3.GetX(), p1.GetY());
            
        }

        public float Area()
        {
            int baseR;
            int alturaR;
            
            if (this.area == 0)
            {
                baseR = (Math.Abs(vertice1.GetX() - vertice4.GetX()));
                alturaR=(Math.Abs(vertice1.GetY() - vertice2.GetY()));
                this.area = baseR * alturaR;
            }
            return this.area;
        }

        public float Perimetro()
        {
            int baseR;
            int alturaR;

            if (this.perimetro == 0)
            {
                baseR = (Math.Abs(vertice1.GetX() - vertice4.GetX()));
                alturaR= (Math.Abs(vertice1.GetY() - vertice2.GetY()));
                this.perimetro = (baseR + alturaR) *2;
            }
            return this.perimetro;
        }

    }
}
