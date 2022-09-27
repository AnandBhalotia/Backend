using DemoProject.Data.Entities;
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
    public class DemoProjectMutation : ObjectGraphType
    {
        public DemoProjectMutation(WasteProdRepo wasteprodrepo, WasteConsRepo wasteconsrepo, AdminRepo adminrepo, WasteRepo wasterepo)
        {
            Field<WasteProdType>(
            "createwasteprod",
            arguments: new QueryArguments(new QueryArgument<NonNullGraphType<WasteProdInputType>> { Name = "wasteProducer" }),
            resolve: context =>
            {
                var wasteProducer = context.GetArgument<WasteProducer>("wasteProducer");
                return wasteprodrepo.Addwasteprod(wasteProducer);
            });

            Field<WasteConsType>(
            "createwastecons",
            arguments: new QueryArguments(new QueryArgument<NonNullGraphType<WasteConsInputType>> { Name = "wasteConsumer" }),
            resolve: context =>
            {
                var wasteConsumer = context.GetArgument<WasteConsumer>("wasteConsumer");
                return wasteconsrepo.Addwastecons(wasteConsumer);
            });

            Field<AdminType>(
            "createadmin",
            arguments: new QueryArguments(new QueryArgument<NonNullGraphType<AdminInputType>> { Name = "admin" }),
            resolve: context =>
            {
                var admin = context.GetArgument<Admin>("admin");
                return adminrepo.Addemployee(admin);
            });

            Field<WasteType>(
           "createwaste",
           arguments: new QueryArguments(new QueryArgument<NonNullGraphType<WasteInputType>> { Name = "waste" }),
           resolve: context =>
           {
               var waste = context.GetArgument<Waste>("waste");
               return wasterepo.Addwaste(waste);
           });

        }
    }
}
