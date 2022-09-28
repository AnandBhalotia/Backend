using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Data.GraphQL.Types
{
    public class WasteInputType : InputObjectGraphType
    {
        public WasteInputType()
        {
            Name = "WasteInput";
            Field<NonNullGraphType<StringGraphType>>("Type");
            Field<NonNullGraphType<StringGraphType>>("Primary_Substance");
            Field<NonNullGraphType<StringGraphType>>("Quantity");
            Field<NonNullGraphType<StringGraphType>>("From");
            Field<NonNullGraphType<StringGraphType>>("To");
            //Field<StringGraphType>("Status");
            //Field<StringGraphType>("Energy");
            Field<NonNullGraphType<IntGraphType>>("Prod_Id");
            //Field<NonNullGraphType<StringGraphType>>("Cons_Id");
        }
    }
}
