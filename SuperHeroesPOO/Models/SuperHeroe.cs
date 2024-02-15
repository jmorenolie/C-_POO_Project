using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesPOO.Models
{
    internal class SuperHeroe: Heroe // Internal hace referecial a que se puede usar esta clase dentro de todo el proeycto
    {
        public int Id;

        private string _Name; //Almacena valor final para que el usuario no ande de chistoso 
        public override string Name  // Proceso de encapsulamiento
        {
            get
            {
                return _Name;
            }
            set 
            { 
                _Name = value.Trim(); //Trim limpia los espacios.
            }
        }

        public string NameAndidentity // Encapsular más propiedades
        {
            get { return $"{_Name} " + $"({SecretName})"; }
        }

        public string SecretName;
        public string Description;
        public int Age;
        public List<SuperPower> SuperPowers; // Lista que recibe Clases, recibe la clase SuperPower
        public List<Vestuario> Vestuario;
        public bool CanFly;

        //Crear el constructor
        public SuperHeroe()//Debe ser el mismo nombre de la case, setear 
        {
            Id = 1;
            SuperPowers = new List<SuperPower>();
            CanFly = false;
        }

        //Crear metodo, funcion que realiza acción dentro de una clase
        public string UseSuperPower()// Si es con String, debe retornar un valor // si es con el void, hace referenciua a que hace unas operaciones que no retornan nada pero de manera interna
        {
            StringBuilder sb = new StringBuilder(); //Concatenar string, sb 
            StringBuilder a = new StringBuilder();
            foreach (var Poderes in SuperPowers) //lo que va despues de var es el nombre para llamar a estos Nombre dentro de clase SuperHeroe
            {
                sb.AppendLine($"{NameAndidentity} está usando el super poder {Poderes.Name} y {Poderes.Description}!!");
            }
            return sb.ToString(); // Retornar el valor
        }

        public override string SaveWorld()
        {
            return $"{NameAndidentity} Ha salvado el mundo";
        }
        public override string SaveEarth()
        {
            return $"{NameAndidentity} Ha salvado la tierra";
        }

    }
}
