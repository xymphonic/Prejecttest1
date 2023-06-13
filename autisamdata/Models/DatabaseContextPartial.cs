using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autisamdata.Models
{
    public partial class DatabasetestContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=MyDatabase;Trusted_Connection=True");
            }
        }

        public Task GetnewsAsync(int v)
        {
            throw new NotImplementedException();
        }

        public Task GetnewsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
