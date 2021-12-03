using API.core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.EF
{
    public class API_Context:DbContext
    {
        public API_Context(DbContextOptions<API_Context> options) :base(options)
        {

        }
        public DbSet<Request> Requests { get; set; }
    }
}
