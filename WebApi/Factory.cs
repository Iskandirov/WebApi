namespace WebApi
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Factory : DbContext
    {
       
        public Factory()
            : base("name=Factory")
        {
        }

         public virtual DbSet<Worker> Workers { get; set; }
    }

    public class Worker
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
    }
}