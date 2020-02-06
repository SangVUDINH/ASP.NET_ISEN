using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Isen.Dotnet.Library.Model
{
    public class Role : BaseEntity
    {        
        public string NomRole {get;set;}

        public ICollection<PersonRole> PersonRoles { get; set; }

   
        public override string ToString() =>
            $"{NomRole}";
        
    }
}