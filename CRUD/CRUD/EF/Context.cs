using CRUD.EF.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Web;

namespace CRUD.EF
{
    public class Context : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}