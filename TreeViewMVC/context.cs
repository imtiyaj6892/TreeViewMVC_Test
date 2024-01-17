using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TreeViewMVC.Models;

namespace TreeViewMVC
{
    public class context: DbContext
    {
        public context()
            :base("ConnectionString")
        {

        }
      
 


        public DbSet<Node> Node { get; set; }
    }
}