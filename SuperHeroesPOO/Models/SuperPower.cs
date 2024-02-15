using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesPOO.Models
{
    internal class SuperPower
    {
        public string Name;
        public string Description;
        public LevelPower Level; // lever Power es el nombre de Enum

        public SuperPower()
        {
            Level = LevelPower.LevelOne; // Llama a la propiedad de la clase
        }
    }
}
