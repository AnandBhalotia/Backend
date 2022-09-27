using DemoProject.Data.Entities;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Data.GraphQL.Types
{
    public class WasteConsType: ObjectGraphType<WasteConsumer>
    {
        public WasteConsType()
        {
            Field(t => t.Cons_Id);
            Field(t => t.Email);
            Field(t => t.Password);
            Field(t => t.Org_Name);
            Field(t => t.Org_Desc);
            Field(t => t.Phone_No);

        }

    }
}
