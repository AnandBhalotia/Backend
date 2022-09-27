using DemoProject.Data;
using DemoProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Repository
{
    public class WasteConsRepo
    {
        public DemoProjectDbContext _dbContext;
        public WasteConsRepo(DemoProjectDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<WasteConsumer> GetWasteCons()
        {
            return _dbContext.WasteConsumers;
        }

        public WasteConsumer Addwastecons(WasteConsumer wastecons)
        {
            _dbContext.WasteConsumers.Add(wastecons);
            _dbContext.SaveChanges();
            return wastecons;
        }
    }
}
