using DemoProject.Data;
using DemoProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Repository
{
    public class WasteUserRepo
    {
        public DemoProjectDbContext _dbContext;
        public WasteUserRepo(DemoProjectDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<WasteUser> GetWasteUser()
        {
            return _dbContext.WasteUsers;
        }

        public IEnumerable<WasteUser> GetWasteUserbyorgname(string orgName)
        {
            return _dbContext.WasteUsers.Where(i => i.Org_Name == orgName);
        }

        public WasteUser Addwasteuser(WasteUser wasteuser)
        {
            _dbContext.WasteUsers.Add(wasteuser);
            _dbContext.SaveChanges();
            return wasteuser;
        }
    }
}
