using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesPOO.Models
{
    internal class AntiHero : SuperHeroe // EL : y nombre de clase, trae todo de esa clase a esta nueva
    {
        public string MakeAntiHeroAction(string Acction)
        {
            return $"El antihero {NameAndidentity} ha: {Acction}";
        }
    }
}
