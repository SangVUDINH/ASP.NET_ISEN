using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Isen.Dotnet.Library.Model
{
    public class Role : BaseEntity
    {        
        public string NomRole {get;set;}

        //class etrangere Role

   
        public override string ToString() =>
            $"{NomRole}";
        
    }
}