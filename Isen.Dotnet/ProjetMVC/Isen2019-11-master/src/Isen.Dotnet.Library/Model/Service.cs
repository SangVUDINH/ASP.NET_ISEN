using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Isen.Dotnet.Library.Model
{
    public class Service : BaseEntity
    {        
        public string NomService {get;set;}

        //class etrangere Role
   
        public override string ToString() =>
            $"{NomService}";
        
    }
}