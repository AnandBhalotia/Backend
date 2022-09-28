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
            Field<StringGraphType>("Type");
            Field<StringGraphType>("Primary_Substance");
            Field<StringGraphType>("Quantity");
            Field<StringGraphType>("From");
            Field<StringGraphType>("To");
            Field<StringGraphType>("Status");
            //Field<StringGraphType>("Energy");
            Field<IntGraphType>("Prod_Id");
            //Field<NonNullGraphType<StringGraphType>>("Cons_Id");
        }
    }
}
