using DemoProject.Data.Entities;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Data.GraphQL.Types
{
    public class WasteType:ObjectGraphType<Waste>
    {
        public WasteType()
        {
            Field(t => t.Waste_Id);
            Field(t => t.Type);
            Field(t => t.Primary_Substance);
            Field(t => t.Quantity);
            Field(t => t.From);
            Field(t => t.To);
            Field(t => t.Status);
            Field(t => t.Energy);
        }
    }
}
