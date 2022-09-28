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
            Field<NonNullGraphType<StringGraphType>>("Org_Name");
            Field<NonNullGraphType<StringGraphType>>("Password");
            Field<NonNullGraphType<StringGraphType>>("Org_Desc");
            Field<NonNullGraphType<StringGraphType>>("Phone_No");
            Field<NonNullGraphType<StringGraphType>>("Type");
        }
    }
}
