using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerCell
{
    public class Cell
    {
        private float charge;
        
        public string Name { get; }
        public float Charge
        {
            get
            {
                return charge;
            }

            set
            {
                if (value > 200)
                {
                    charge = 200;
                }
                else if( value < 0)
                {
                    charge = 0;
                }
                else
                {
                    charge = value;
                }

            }
        }

        public int Level
        {
            get
            {
                int val = 1 + Convert.ToInt32(Charge)/40;
                return val;
            }
        }

        public void Consume(float amount)
        {
            if (amount < Charge)
            {
                Charge -= amount;
            }
            else
            {
                Charge = 0;
            }
        }

        public void Restore()
        {
            Charge = 200;
        }

        public Cell (string name)
        {
            Name = name;
            Charge = 200;
        }

        public override string ToString()
        {
            return $"[{Name}] Level {Level}: {Charge:F0}/200";
        }
    }
}