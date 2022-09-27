using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Data.GraphQL.Types
{
    public class WasteUserInputType: InputObjectGraphType
    {
        public WasteUserInputType()
        {
            Name = "WasteUserInput";
            Field<NonNullGraphType<StringGraphType>>("Email");
            Field<NonNullGraphType<StringGraphType>>("OrgName");
            Field<NonNullGraphType<StringGraphType>>("Password");
            Field<StringGraphType>("OrgDesc");
            Field<StringGraphType>("PhoneNo");
            Field<NonNullGraphType<StringGraphType>>("Type");
            Field<NonNullGraphType<StringGraphType>>("ProdId");
            Field<NonNullGraphType<StringGraphType>>("ConsId");
        }
    }
}
