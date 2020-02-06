using System;
using System.Linq;
using Isen.Dotnet.Library.Context;
using Isen.Dotnet.Library.Model;
using Isen.Dotnet.Library.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Isen.Dotnet.Web.Controllers
{
    public class PersonRoleController : BaseController<PersonRole>
    {
        public PersonRoleController(
            ILogger<PersonRoleController> logger,
            ApplicationDbContext context) : base(logger, context)
        {
        }               

        // Exemple d'override de la query : liste les personnes
        protected override IQueryable<PersonRole> BaseQuery() =>
            base.BaseQuery()
                // Inclure BirthCity lors d'une requête faite sur une ville
                .Include(p => p.Role)
                .Include(p => p.Person);
                // Filtrer sur les villes qui commencent par Toul
                //.Where(p => p.BirthCity.StartsWith("Toul"))
                // Trier par ordre alpha des villes
    }
}