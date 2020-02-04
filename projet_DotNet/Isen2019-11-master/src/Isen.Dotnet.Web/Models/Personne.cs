using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Isen.Dotnet.Web.Model
{
    public class Personne 
    {        

        public int Id {get;set;}



        public string Nom {get;set;}
        public string Prenom {get;set;}
        public string DateDeNaissance {get;set;}
        public string Tel {get;set;}
        public string Email {get;set;}

        public List<Personne> GetAllPersonne()
        {
            return new List<Personne>
            {
                new Personne { Id= 1, Nom = "Nicolas1", Prenom = "DAda1", DateDeNaissance= "11/1/1994", Tel= "0644841662", },
                new Personne { Id= 2, Nom = "Nicolas2", Prenom = "DAda2", DateDeNaissance= "11/1/1994", Tel= "0644841662", },
                new Personne { Id= 3, Nom = "Nicolas3", Prenom = "DAda3", DateDeNaissance= "11/1/1994", Tel= "0644841662", },
                new Personne { Id= 4, Nom = "Nicolas4", Prenom = "DAda4", DateDeNaissance= "11/1/1994", Tel= "0644841662", }
            };
        }




    }
}