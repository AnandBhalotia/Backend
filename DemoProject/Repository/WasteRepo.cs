using DemoProject.Data;
using DemoProject.Data.Entities;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Repository
{
    public class WasteRepo
    {
        public DemoProjectDbContext _dbContext;
        public WasteRepo(DemoProjectDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Waste> GetWaste()
        {
            return _dbContext.Wastes;
        }

        public IEnumerable<Waste> GetWastebyid(int Id)
        {
            return _dbContext.Wastes.Where(i => i.Waste_Id == Id);
        }

        public int GetProdIdbyid(Waste waste)
        {
            Waste findwaste = _dbContext.Wastes.Find(waste.Waste_Id);
            return findwaste.Prod_Id;
        }


        public Waste Addwaste(Waste waste)
        {
            _dbContext.Wastes.Add(waste);
            _dbContext.SaveChanges();
            return waste;
        }

        public Waste Updatestatus(Waste waste)
        {
            Waste existingWaste = _dbContext.Wastes.Find(waste.Waste_Id);
            if (existingWaste != null)
            {
                existingWaste.Status = waste.Status;
            }
            _dbContext.SaveChanges();
            return waste;
        }
        public Waste Updateenergy(Waste waste)
        {
            Waste existingWaste = _dbContext.Wastes.Find(waste.Waste_Id);
            if (existingWaste != null)
            {
                existingWaste.Energy = waste.Energy;        
            }
            _dbContext.SaveChanges();
            return waste;
        }

         
    }
}
  
