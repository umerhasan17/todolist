namespace ToDoList.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using ToDoList.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ToDoList.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ToDoList.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            AddUser(context);
        }

        // The function AddUser is for debugging purposes. This user is permanently stored in the database so there is no need to create a new user after every build.

        void AddUser(ToDoList.Models.ApplicationDbContext context)
        {
            var user = new ApplicationUser { UserName = "user1@email.com" };
            var um = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            um.Create(user, "password");
        }
    }
}
