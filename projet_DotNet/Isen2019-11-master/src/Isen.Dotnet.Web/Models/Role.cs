using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Isen.Dotnet.Web.Model
{
    public class Role 
    {        
        public int Id {get;set;}
        public string Nom {get;set;}
        public string[] ListDePersonne {get;set;}

    }
}