using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Sphere
    {
        private readonly Color color;
        private float raio;
        private int arremessos;

        public Sphere(Color color, float raio )
        {
            this.color = color;
            this.raio = raio;
            arremessos = 0;
        }

        public void Pop()
        {
            raio = 0;
        }

        public void Throw()
        {
            if( raio > 0)
            {
                arremessos ++;
            }
        }

        public int GetTimesThrown()
        {
            return arremessos;
        }

    }
}