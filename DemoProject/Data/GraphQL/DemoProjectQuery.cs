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

            Field<ListGraphType<WasteUserType>>(
               "wasteuserbyid",
               arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "Id" }),
               resolve: context =>
               {
                   var Id = context.GetArgument<int>("Id");
                   return wasteuserrepo.GetWasteUserbyid(Id);
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
