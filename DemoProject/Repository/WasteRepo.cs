using DemoProject.Data;
using DemoProject.Data.Entities;
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

        public Waste Addwaste(Waste waste)
        {
            _dbContext.Wastes.Add(waste);
            _dbContext.SaveChanges();
            return waste;
        }
    }
}
