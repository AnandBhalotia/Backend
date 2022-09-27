using DemoProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Data
{
    public static class InitialData
    {
        public static void Seed(this DemoProjectDbContext dbContext)
        {
            if (!dbContext.WasteProducers.Any())
            {
                dbContext.WasteProducers.Add(new WasteProducer
                {
                    Email = "Akshay1@gmail.com",
                    Password = "1234",
                    Org_Name = "Akshay",
                    Org_Desc = "Agarwal",
                    Phone_No = "1234567809",
                    Address= "Bengaluru"
                });

                dbContext.WasteProducers.Add(new WasteProducer
                {
                    Email = "Anand1",
                    Password = "5678",
                    Org_Name = "Anand",
                    Org_Desc = "Bhalotia",
                    Phone_No = "1234567089",
                    Address= "Mumbai"
                });

                dbContext.SaveChanges();
            }

            if (!dbContext.WasteConsumers.Any())
            {
                dbContext.WasteConsumers.Add(new WasteConsumer
                {
                    Email = "Tanmay1@gmail.com",
                    Password = "1234",
                    Org_Name = "Tanmay",
                    Org_Desc = "Ahuja",
                    Phone_No = "1234566666",
                });

                dbContext.WasteConsumers.Add(new WasteConsumer
                {
                    Email = "Arjun1",
                    Password = "5678",
                    Org_Name = "Arjun",
                    Org_Desc = "Nigam",
                    Phone_No = "1234567077",
                });

                dbContext.SaveChanges();
            }

            if (!dbContext.Admins.Any())
            {
                dbContext.Admins.Add(new Admin
                {
                    Email = "Shaswat1@gmail.com",
                    Password = "1234",
                });

                dbContext.Admins.Add(new Admin
                {
                    Email = "Krishn1@yahoo.com",
                    Password = "5678",
                });

                dbContext.SaveChanges();
            }

            if (!dbContext.Wastes.Any())
            {
                dbContext.Wastes.Add(new Waste
                {
                    Type="Organic",
                    Primary_Substance="Food",
                    Quantity="56",
                    From="25may2002",
                    To="31may2002",
                    Status="Accepted",
                    Energy="too much"
                });

                dbContext.Wastes.Add(new Waste
                {
                    Type = "human",
                    Primary_Substance = "Tanmay",
                    Quantity = "86",
                    From = "14aug2000",
                    To = "27sep2022",
                    Status = "Rejected",
                    Energy = "negative"
                });

                dbContext.SaveChanges();
            }


        }
    }
}
