using DemoProject.Data.GraphQL.Types;
using DemoProject.Repository;
using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Data.GraphQL
{
    public class DemoProjectQuery : ObjectGraphType
    {
        public DemoProjectQuery(WasteUserRepo wasteuserrepo, AdminRepo adminrepo, WasteRepo wasterepo)
        {
            Field<ListGraphType<WasteUserType>>(
                "wasteusers",
                resolve: context => wasteuserrepo.GetWasteUser()
                );

            Field<ListGraphType<WasteType>>(
               "wasteuserbyoname",
               arguments: new QueryArguments(new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "orgname" }),
               resolve: context =>
               {
                   var orgname = context.GetArgument<string>("orgname");
                   return wasteuserrepo.GetWasteUserbyorgname(orgname);
               }

               );

            Field<ListGraphType<AdminType>>(
                    "admins",
                    resolve: context => adminrepo.GetEmployees()
                    );

            Field<ListGraphType<WasteType>>(
               "wastes",
               resolve: context => wasterepo.GetWaste()
               );
        }

    }
}
