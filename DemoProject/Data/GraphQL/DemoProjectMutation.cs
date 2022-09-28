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
        public DemoProjectMutation(WasteUserRepo wasteuserrepo, AdminRepo adminrepo, WasteRepo wasterepo)
        {
            Field<WasteUserType>(
            "createwasteuser",
            arguments: new QueryArguments(new QueryArgument<NonNullGraphType<WasteUserInputType>> { Name = "wasteUser" }),
            resolve: context =>
            {
                var wasteUser = context.GetArgument<WasteUser>("wasteUser");
                return wasteuserrepo.Addwasteuser(wasteUser);
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

            //Field<WasteType>(
            //  "updatewaste",
            // arguments: new QueryArguments(
            //    new QueryArgument<NonNullGraphType<WasteInputType>> { Name = "human" }
            //   ), 

            //    )

        }
    }
}
