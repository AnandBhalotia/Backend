﻿using DemoProject.Data.Entities;
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
            if (!dbContext.WasteUsers.Any())
            {
                dbContext.WasteUsers.Add(new WasteUser
                {
                    Email = "Akshay1@gmail.com",
                    Password = "1234",
                    Org_Name = "Akshay",
                    Org_Desc = "Agarwal",
                    Phone_No = "1234567809",
                    Type= "Consumer"
                });

                dbContext.WasteUsers.Add(new WasteUser
                {
                    Email = "Anand1",
                    Password = "5678",
                    Org_Name = "Anand",
                    Org_Desc = "Bhalotia",
                    Phone_No = "1234567089",
                    Type= "Producer"
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
                    Energy="too much",
                    Prod_Id=1,
                    Cons_Id=2
                });

                dbContext.Wastes.Add(new Waste
                {
                    Type = "human",
                    Primary_Substance = "Tanmay",
                    Quantity = "86",
                    From = "14aug2000",
                    To = "27sep2022",
                    Status = "Rejected",
                    Energy = "negative",
                    Prod_Id = 1,
                    Cons_Id = 2
                });

                dbContext.SaveChanges();
            }


        }
    }
}
