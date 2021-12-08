using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using DocsManagement.Models;

namespace DocsManagement.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
            .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.ServicesDocuments.Any())
            {
                context.ServicesDocuments.AddRange(
                new ServicesDocs
                {
                    RegistrationNomer = 101,
                    RegistrationDate = "11/28/2021",
                    TypeDocument = "service",
                    StateDocument = "Registring",
                    CreatedUser = "liban",
                    SignedUser = "Abdullahi",
                    NumerSheets = 2,
                    Summary = "this a service a document for buying somethings or for doing something"
                },
                new ServicesDocs
                {
                    RegistrationNomer = 102,
                    RegistrationDate = "11/28/2021",
                    TypeDocument = "service",
                    StateDocument = "Registring",
                    CreatedUser = "liban",
                    SignedUser = "Abdullahi",
                    NumerSheets = 2,
                    Summary = "this a service a document for buying somethings or for doing something"
                },
                new ServicesDocs
                {
                    RegistrationNomer = 103,
                    RegistrationDate = "11/28/2021",
                    TypeDocument = "service",
                    StateDocument = "Registring",
                    CreatedUser = "liban",
                    SignedUser = "Abdullahi",
                    NumerSheets = 2,
                    Summary = "this a service a document for buying somethings or for doing something"
                },
                new ServicesDocs
                {
                    RegistrationNomer = 104,
                    RegistrationDate = "11/28/2021",
                    TypeDocument = "service",
                    StateDocument = "Registring",
                    CreatedUser = "liban",
                    SignedUser = "Abdullahi",
                    NumerSheets = 2,
                    Summary = "this a service a document for buying somethings or for doing something"
                },
                new ServicesDocs
                {
                    RegistrationNomer = 105,
                    RegistrationDate = "11/28/2021",
                    TypeDocument = "service",
                    StateDocument = "Registring",
                    CreatedUser = "liban",
                    SignedUser = "Abdullahi",
                    NumerSheets = 2,
                    Summary = "this a service a document for buying somethings or for doing something"
                },
                new ServicesDocs
                {
                    RegistrationNomer = 106,
                    RegistrationDate = "11/28/2021",
                    TypeDocument = "service",
                    StateDocument = "Registring",
                    CreatedUser = "liban",
                    SignedUser = "Abdullahi",
                    NumerSheets = 2,
                    Summary = "this a service a document for buying somethings or for doing something"
                },
                new ServicesDocs
                {
                    RegistrationNomer = 107,
                    RegistrationDate = "11/28/2021",
                    TypeDocument = "service",
                    StateDocument = "Registring",
                    CreatedUser = "liban",
                    SignedUser = "Abdullahi",
                    NumerSheets = 2,
                    Summary = "this a service a document for buying somethings or for doing something"
                },
                new ServicesDocs
                {
                    RegistrationNomer = 108,
                    RegistrationDate = "11/28/2021",
                    TypeDocument = "service",
                    StateDocument = "Registring",
                    CreatedUser = "liban",
                    SignedUser = "Abdullahi",
                    NumerSheets = 2,
                    Summary = "this a service a document for buying somethings or for doing something"
                },
                new ServicesDocs
                {
                    RegistrationNomer = 109,
                    RegistrationDate = "11/28/2021",
                    TypeDocument = "service",
                    StateDocument = "Registring",
                    CreatedUser = "liban",
                    SignedUser = "Abdullahi",
                    NumerSheets = 2,
                    Summary = "this a service a document for buying somethings or for doing something"

                }
                );
                context.SaveChanges();
            }
        }
    }
}
