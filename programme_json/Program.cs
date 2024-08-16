using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;

namespace programme_json
{

	class Personne
	{
		public string  nom {  get; init; }
		public int age { get; init; }
		public bool majeur { get; init; }

		/*
		public Personne(string nom, int age, bool majeur)
		{
			this.nom = nom;
			this.age = age;
			this.majeur = majeur;
		}*/

		public void Afficher()
		{
            Console.WriteLine("Nom " + nom + "- Age " + age + " ans");
        }
	}

	internal class Program
	{
		static void Main(string[] args)
		{ /*
			var personne1 = new Personne() { Nom ="Toto", Age=24, Majeur=false };  
			personne1.Afficher();
			// Sérialisation
			//*Personne
			string json = JsonConvert.SerializeObject(personne1);
            Console.WriteLine(json);

			// Déserialisation
			string jsonTiti = "{ \"nom\":\"Titi\",\"age\":15,\"majeur\":false}";
			Personne titi = JsonConvert.DeserializeObject<Personne>(jsonTiti);
			titi.Afficher();
			
			var Personnes = new List<Personne>()
			{
				new Personne(){nom="Olivier", age=36, majeur=true},
				new Personne(){nom="Jean", age=18, majeur=true},
				new Personne(){nom="Alain", age=17, majeur=false},
			};
			
			var json  = JsonConvert.SerializeObject(Personnes);

            //Console.WriteLine(json);

			File.WriteAllText("Personnes.txt", json);
			*/

			string json = File.ReadAllText("Personnes.txt");
			var personnes = JsonConvert.DeserializeObject<List<Personne>>(json);

            foreach(var personne in personnes)
			{
				personne.Afficher();
			}
        }
	}
}
