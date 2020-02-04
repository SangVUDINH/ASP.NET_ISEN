using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Isen.Dotnet.Library.Model
{
    public class Personne : BaseEntity
    {        
        public string Nom {get;set;}

        //class etrangere Role
        public Role RolePersonne { get;set;}
        public int? RolePersonneId {get;set;}

        public Service ServicePersonne { get;set;}
        public int? ServicePersonneId {get;set;}
   
        public override string ToString() =>
            $"{Nom} {RolePersonne}" ;
        
    }
}