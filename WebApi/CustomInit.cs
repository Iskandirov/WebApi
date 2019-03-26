using System.Data.Entity;

namespace WebApi
{
    internal class CustomInit<T> : DropCreateDatabaseIfModelChanges<Factory>
    {
        protected override void Seed(Factory context)
        {
            base.Seed(context);

            context.Workers.Add(new Worker
            {
                FirstName = "Petro",
                LastName = "Petrenko",
                Age =  66,
                Salary = 130000m
            });
            context.Workers.Add(new Worker
            {
                FirstName = "Ivan",
                LastName = "Ivanenko",
                Age = 36,
                Salary = 190000m
            });
            context.Workers.Add(new Worker
            {
                FirstName = "Volodumur",
                LastName = "Klichko",
                Age = 44,
                Salary = 999999m
            });
            context.SaveChanges();
        }
    }
}