using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_oop_project
{
   public interface mazeopject
    {
        char icon // the shape of mazeobject
        {
            get;
        }
          
        bool issolid { get;  }// movement block
    }
}
