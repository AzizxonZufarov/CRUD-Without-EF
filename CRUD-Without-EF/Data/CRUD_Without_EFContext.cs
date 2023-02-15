using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUD_Without_EF.Models;

namespace CRUD_Without_EF.Data
{
    public class CRUD_Without_EFContext : DbContext
    {
        public CRUD_Without_EFContext (DbContextOptions<CRUD_Without_EFContext> options)
            : base(options)
        {
        }

        public DbSet<CRUD_Without_EF.Models.BookViewModel> BookViewModel { get; set; }
    }
}
