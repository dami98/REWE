using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectOrientedProgrammin
{
    class Form
    {
        public string Bezeichnung { get; set; }
        public int Seite1 { get; set; }
        public int Seite2 { get; set; }
        public float Umfang { get; set; }
        public float Flächeninhalt { get; set; }


        public Form(string _Bezeichnung="noName",int _leng1 = 0, int _leng2 = 0)
        {
            this.Bezeichnung = _Bezeichnung;
            this.Seite1 = _leng1;
            this.Seite2 = _leng2;
            this.Flächeninhalt = Seite1 * Seite2;
            this.Umfang = Seite1 * 2 + Seite2 * 2;
        }

        public override string ToString()
        {
            return string.Format(@"
----------{0}----------
Seite 1 =       {1}cm
Seite 2 =       {2}cm

Umfang =        {3}cm
Flächeninhalt = {4}cm²
",Bezeichnung,Seite1,Seite2,Umfang,Flächeninhalt);
        }
    }
}
