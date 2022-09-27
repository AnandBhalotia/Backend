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
            Field<NonNullGraphType<StringGraphType>>("PrimarySubstance");
            Field<NonNullGraphType<StringGraphType>>("Quantity");
            Field<StringGraphType>("From");
            Field<StringGraphType>("To");
            Field<StringGraphType>("Status");
            Field<StringGraphType>("Energy");
        }
    }
}
