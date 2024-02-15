using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesPOO.Models
{
    internal abstract class Heroe
    {
        public abstract string Name { get; set; }
        public abstract string SaveWorld(); //Absract no permite colocarla como abstracto

        public virtual string SaveEarth() { return $"{Name} Ha salvado la tierra"; }
  
    }
}
