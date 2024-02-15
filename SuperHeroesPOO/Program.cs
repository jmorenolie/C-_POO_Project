//POO

//Crear Vestuario
using System.Runtime.InteropServices;
using System.Text;
using SuperHeroesPOO.Models; // Importar las clases que esten dentro de Models

var Ropa = new Vestuario();
Ropa.Id = 1;
Ropa.Name = "Pajamas";
Ropa.Color = "Black";
Ropa.Size = "L";

//Crear SuperPoderes
SuperPower Kamehameha = new SuperPower();
Kamehameha.Name = "Kamehameha";
Kamehameha.Description = "Lanza un Rayo Azul";
Kamehameha.Level = LevelPower.LevelTwo;

SuperPower BesosOsudos = new SuperPower();
BesosOsudos.Name = "BesosOsudos";
BesosOsudos.Description = "Y Enamora a Juani";
BesosOsudos.Level = LevelPower.LevelThree;

SuperPower Volar = new SuperPower();
Volar.Name = "Fly";
Volar.Description = "Fly in the air";
Volar.Level = LevelPower.LevelOne;

SuperPower AbracitoOsudo = new SuperPower();
AbracitoOsudo.Name = "AbracitoOsudo";
AbracitoOsudo.Description = "Da un gran Abrazo";
AbracitoOsudo.Level = LevelPower.LevelThree;

//Creando Objetos
//Crear SuperHeroes

//Goku, Creando Goku
SuperHeroe Goku = new SuperHeroe();
Goku.Id = 1;
Goku.Name = "  Goku  ";
Goku.SecretName = "Kakaroto";
Goku.Description = "Sayayin";
Goku.Age = 35;
List<SuperPower> PowerGoku = new List<SuperPower>(); // Crear Lista de Poderes
PowerGoku.Add(Kamehameha);
PowerGoku.Add(Volar);
Goku.SuperPowers = PowerGoku;
Goku.CanFly = true;
string ResultSuperPowerGoku = Goku.UseSuperPower(); // Llamar metodo.
Console.WriteLine(ResultSuperPowerGoku);

//Karen
SuperHeroe Karen = new SuperHeroe();
Karen.Id = 2; // Añadir propiedades.
Karen.Name = "Karen";
Karen.SecretName = "Karencita";
Karen.Description = "Osuda";
Karen.Age = 20;
List<SuperPower> PowerKaren = new List<SuperPower>(); // Añadir Poderes
PowerKaren.Add(BesosOsudos);
PowerKaren.Add(AbracitoOsudo);
List<Vestuario> vestuarios = new List<Vestuario>();
vestuarios.Add(Ropa);
Karen.SuperPowers = PowerKaren; //new[] { "Amorosa", "Hacer feliz", "Peluda", "Salvar vidas" }; // Asi se crean Arrays
Karen.CanFly = false;
string ResultSuperPowerKaren = Karen.UseSuperPower(); // Llamar metodo.
Console.WriteLine(ResultSuperPowerKaren);

//CREAR ANTIHERO
var DeadPool = new AntiHero();
DeadPool.Id = 3; // Añadir propiedades.
DeadPool.Name = "DeadPool";
DeadPool.SecretName = "Ryan Reinolds";
DeadPool.Description = "Antihero";
DeadPool.Age = 21;
List<SuperPower> PowerDeadPool = new List<SuperPower>(); // Añadir Poderes
PowerDeadPool.Add(Volar);
DeadPool.SuperPowers = PowerDeadPool; 
DeadPool.CanFly = false;
string ResultSuperPowerDeadPool = DeadPool.UseSuperPower(); // Llamar metodo.
string AccionAntihero = DeadPool.MakeAntiHeroAction("Ataca a los Tombos");
string ResultSaveWorld = DeadPool.SaveWorld();
Console.WriteLine(AccionAntihero);
Console.WriteLine(ResultSaveWorld);
//Enumeración enum
enum LevelPower
{
    LevelOne,
    LevelTwo,
    LevelThree
}

