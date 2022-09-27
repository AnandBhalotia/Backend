using DemoProject.Data.Entities;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Data.GraphQL.Types
{
    public class WasteProdType:ObjectGraphType<WasteProducer>
    {
        public WasteProdType()
        {
            Field(t => t.Prod_Id);
            Field(t => t.Email);
            Field(t => t.Password);
            Field(t => t.Org_Name);
            Field(t => t.Org_Desc);
            Field(t => t.Phone_No);
            Field(t => t.Address);
        }
    }
}
