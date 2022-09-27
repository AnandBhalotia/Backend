using DemoProject.Data;
using DemoProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Repository
{
    public class AdminRepo
    {

        public DemoProjectDbContext _dbContext;
        public AdminRepo(DemoProjectDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Admin> GetEmployees()
        {
            return _dbContext.Admins;
        }
        public Admin Addemployee(Admin employee)
        {
            _dbContext.Admins.Add(employee);
            _dbContext.SaveChanges();
            return employee;
        }
    }
}
