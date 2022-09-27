using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Data.GraphQL.Types
{
    public class WasteProdInputType: InputObjectGraphType
    {
        public WasteProdInputType()
        {
            Name = "WasteProdInput";
            Field<NonNullGraphType<StringGraphType>>("Email");
            Field<NonNullGraphType<StringGraphType>>("OrgName");
            Field<NonNullGraphType<StringGraphType>>("Password");
            Field<StringGraphType>("OrgDesc");
            Field<StringGraphType>("PhoneNo");
            Field<StringGraphType>("Address");
        }
    }
}
