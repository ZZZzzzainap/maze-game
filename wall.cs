using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_oop_project
{
    internal class wall : mazeopject
    {
        public char icon { get => '#'; }
        public bool issolid { get => true; }
    }
}
