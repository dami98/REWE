using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ObjectOrientedProgrammin
{
    class Kreis : Form
    {
        public float Radius { get; set; }

        public Kreis(string bez="noNme",float _rad = 0)
        {
            this.Bezeichnung = bez;
            this.Radius = _rad;
            this.Flächeninhalt = (float)Math.PI * (_rad * _rad);
            this.Umfang = 2 * (float)Math.PI * _rad;
        }


    }
}
