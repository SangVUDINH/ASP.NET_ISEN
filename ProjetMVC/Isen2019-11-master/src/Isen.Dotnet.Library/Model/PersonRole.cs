using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Isen.Dotnet.Library.Model
{
    public class PersonRole : BaseEntity
    {        
        public int PersonId {get;set;}
        public int RoleId {get;set;}
        public Person Person { get; set; }
         public Role Role { get; set; }

         public override string ToString() =>
            $"{Role.NomRole}";
    }
}