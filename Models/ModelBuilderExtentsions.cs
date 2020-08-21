using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigikalaManagement.Models
{
    public static class ModelBuilderExtentsions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                    new Employee
                    {
                        Id = 1,
                        Name = "Admin",
                        Department = Dept.HR,
                        Email = "Admin@gmail.com"
                    },
                    new Employee
                    {
                        Id = 2,
                        Name = "User",
                        Department = Dept.IT,
                        Email = "User@gmail.com"
                    }
                );
        }
    }
}
