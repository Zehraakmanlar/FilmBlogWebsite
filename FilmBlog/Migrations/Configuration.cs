namespace FilmBlog.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FilmBlog.Models.Class.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            //burası default olarak false geldi biz true yaptık
        }

        protected override void Seed(FilmBlog.Models.Class.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
