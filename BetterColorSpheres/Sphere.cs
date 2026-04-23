using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterColorSpheres
{
    public class Sphere
    {
        private readonly Color color;
        private float raio;
        public int Arremessos {get; set;} = 0;

        public Sphere(Color color, float raio )
        {
            this.color = color;
            this.raio = raio;
        }

        public void Pop()
        {
            raio = 0;
        }

        public void Throw()
        {
            if( raio > 0)
            {
                Arremessos ++;
            }
        }
    }
}