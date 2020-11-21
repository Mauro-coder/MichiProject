using MichiProject.Animal.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MichiProject.Animal.Vertebrado
{
    class Vertebrado : Animal
    {
        #region[Propiedades]
        public string Esqueleto { get; set; }
        public int Vertebras { get; set; }
        #endregion[Propiedades]

        #region[Constructor]
        public Vertebrado():base()
        {
            this.Filo = EnumFilo.Cordado.ToString();
        }
        #endregion[Constructor]
    }
}
