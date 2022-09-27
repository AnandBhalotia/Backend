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
        public DemoProjectQuery(WasteProdRepo wasteprodrepo, WasteConsRepo wasteconsrepo, AdminRepo adminrepo, WasteRepo wasterepo)
        {
            Field<ListGraphType<WasteProdType>>(
                "wasteproducers",
                resolve: context => wasteprodrepo.GetWasteProd()
                );

            Field<ListGraphType<WasteType>>(
               "wasteprodbyoname",
               arguments: new QueryArguments(new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "orgname" }),
               resolve: context =>
               {
                   var orgname = context.GetArgument<string>("orgname");
                   return wasteprodrepo.GetWasteProdbyorgname(orgname);
               }

               );

            Field<ListGraphType<WasteConsType>>(
               "wasteconsumers",
               resolve: context => wasteconsrepo.GetWasteCons()
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
