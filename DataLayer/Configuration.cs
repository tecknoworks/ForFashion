﻿using BusinessObjects;
using BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            //ContextKey = "DataLayer.ApplicationDbContext";
        }

        protected override void Seed(ApplicationDbContext context)
        {

            context.Shirts.AddOrUpdate(
               s => s.Id,
               new Shirt() {  Id = 1, Name = "Floral print shirt"},
               new Shirt() {  Id = 2, Name = " Striped shirt"},
               new Shirt() { Id = 3, Name = "Top with bow"},
               new Shirt() { Id = 4, Name = "Shirt with back bows" },
               new Shirt() { Id = 5, Name = "Frilled shirt" },
               new Shirt() { Id = 6, Name = "Cropped shirt" },
               new Shirt() { Id = 7, Name = "Poplin shirt" },
                new Shirt() { Id = 8, Name = "Short shirt whith embroideries" },
               new Shirt() { Id = 9, Name = "Tropical print shirt" },
               new Shirt() { Id = 10, Name = "Constrast shirt" },
               new Shirt() { Id = 11, Name = "Asymetric cut out shirt" }, 
               new Shirt() { Id = 12, Name = "Oversized shirt" },
               new Shirt() { Id = 13, Name = " Tulle shirt" },
               new Shirt() { Id = 14, Name = "Off the shoulder shirt" },
                new Shirt() { Id = 15, Name = "Check shirt with frill" },
               new Shirt() { Id = 16, Name = "Denim shirt" },
               new Shirt() { Id = 17, Name = "Double layered shirt" },
               new Shirt() { Id = 18, Name = "Kimono blouse" },
                new Shirt() { Id = 19, Name = "Halter neck top" },
               new Shirt() { Id = 20, Name = "Polka dot shirt" },
               new Shirt() { Id = 21, Name = "Shirt with pearl details" },
               new Shirt() { Id = 22, Name = "Velvet top" },
               new Shirt() { Id = 23,Name = "Blouse with hood"},
               new Shirt() { Id = 24, Name = "Frilled sateen blouse"},
               new Shirt() { Id = 25, Name = "V-neck chocker shirt"},
               new Shirt() { Id = 26, Name = "Metallic button overshirt"},
               new Shirt() { Id = 27, Name = "Faux suede top"},
               new Shirt() { Id = 28, Name = "Pearly shirt"},
               new Shirt() { Id = 29, Name = "Cats print shirt"},
               new Shirt() { Id = 30, Name = "High-neck blouse"}
               );
            context.Dresses.AddOrUpdate(
               d => d.Id,
               new Dress() { Id = 1, Name = "Floral" },
               new Dress() { Id = 2, Name = "Combined asymetric dress" },
               new Dress() { Id = 3, Name = "Midi dress" },
               new Dress() { Id = 4, Name = "Stripped dress" },
                new Dress() { Id = 5, Name = "Long ribbed dress" },
               new Dress() { Id = 6, Name = "Polka dot dress" },
               new Dress() { Id = 7, Name = "Long stripped dress" },
               new Dress() { Id = 8, Name = "Sleeveless oversized dress" },
                new Dress() { Id = 9, Name = "Flowing dress with ruffled sleeves" },
               new Dress() { Id = 10, Name = "Off-the-shoulder dress" },
               new Dress() { Id = 11, Name = "Oversized dress with fringe" },
               new Dress() { Id = 12, Name = "Combined midi dress" },
                new Dress() { Id = 13, Name = "Constrasting Jacquard Dress" },
               new Dress() { Id = 14, Name = "Shinny ribbed dress" },
               new Dress() { Id = 15, Name = "Checked shirt tunic" },
               new Dress() { Id = 16, Name = "Tulle dress" },
                new Dress() { Id = 17, Name = "Frilled-sleeve dress" },
               new Dress() { Id = 18, Name = "Printed satin dress" },
               new Dress() { Id = 19, Name = "Multicoloured stripped dress" },
               new Dress() { Id = 20, Name = "Denim mini dress" }
               );
            
            var fh1 = new FashionHouse() { Id = 1, Name = "Versace", PhoneNumber = "+40(0)31 6300031"};
            var fh2 = new FashionHouse() { Id = 2, Name = "Chanel", PhoneNumber = "+40(0)31 6355531" };
            var fh3 = new FashionHouse() { Id = 3, Name = "Gucci", PhoneNumber = "+40(0)31 8975531" };
            var fh4 = new FashionHouse() { Id = 4, Name = "Calvin Klein", PhoneNumber = "+40(0)31 35232531" };
            var fh5 = new FashionHouse() { Id = 5, Name = "QASIMI", PhoneNumber = "+40(0)31 35212331" };
            context.FashionHouse.AddOrUpdate(
                f => f.Id,
                fh1,
                fh2,
                fh3,
                fh4,
                fh5);
            context.Collection.AddOrUpdate(
                c => c.Id,
                new Collection() { Id = 1, Name = "Spring-Summmer",year = 2012, FashionHouse = fh1 },
                new Collection() { Id = 2, Name = "Spring-Summer", year = 2012, FashionHouse = fh2 },
                new Collection() { Id = 3, Name = "Spring-Summer", year = 2012, FashionHouse = fh3 },
                new Collection() { Id = 4, Name = "Autumn-Winter", year = 2012, FashionHouse = fh3 },
                new Collection() { Id = 5, Name = "Spring-Summer", year = 2017, FashionHouse = fh3 },
                new Collection() { Id = 6, Name = "Paris Haute Couture Spring/Summer", year = 2016, FashionHouse = fh4 },
                new Collection() { Id = 7, Name = "New York Fashion Week Fall/Winter", year = 2017, FashionHouse = fh5 },
                new Collection() { Id = 8, Name = "New York Fashion Week Fall/Winter", year = 2017, FashionHouse = fh5 },
                new Collection() { Id = 9, Name = "Autumn-Winter", year = 2017, FashionHouse = fh1 },
                new Collection() { Id = 10, Name = "Autumn-Winter", year = 2013, FashionHouse = fh2 },
                new Collection() { Id = 11, Name = "Spring-Summmer", year = 2013, FashionHouse = fh1 },
                new Collection() { Id = 12, Name = "Spring-Summer", year = 2013, FashionHouse = fh2 },
                new Collection() { Id = 13, Name = "Spring-Summer", year = 2013, FashionHouse = fh3 },
                new Collection() { Id = 14, Name = "Autumn-Winter", year = 2013, FashionHouse = fh3 },
                new Collection() { Id = 15, Name = "Spring-Summer", year = 2014, FashionHouse = fh3 },
                new Collection() { Id = 16, Name = "Paris Haute Couture Spring/Summer", year = 2013, FashionHouse = fh4 },
                new Collection() { Id = 17, Name = "New York Fashion Week Fall/Winter", year = 2013, FashionHouse = fh5 },
                new Collection() { Id = 18, Name = "New York Fashion Week Fall/Winter", year = 2013, FashionHouse = fh5 },
                new Collection() { Id = 19, Name = "Autumn-Winter", year = 2014, FashionHouse = fh1 },
                new Collection() { Id = 20, Name = "Autumn-Winter", year = 2014, FashionHouse = fh2 },
                new Collection() { Id = 21, Name = "Spring-Summmer", year = 2015, FashionHouse = fh1 },
                new Collection() { Id = 22, Name = "Spring-Summer", year = 2015, FashionHouse = fh2 },
                new Collection() { Id = 23, Name = "Spring-Summer", year = 2015, FashionHouse = fh3 },
                new Collection() { Id = 24, Name = "Autumn-Winter", year = 2015, FashionHouse = fh3 },
                new Collection() { Id = 25, Name = "Spring-Summer", year = 2015, FashionHouse = fh3 },
                new Collection() { Id = 26, Name = "Paris Haute Couture Spring/Summer", year = 2018, FashionHouse = fh4 },
                new Collection() { Id = 27, Name = "New York Fashion Week Fall/Winter", year = 2018, FashionHouse = fh5 },
                new Collection() { Id = 28, Name = "New York Fashion Week Fall/Winter", year = 2018, FashionHouse = fh5 },
                new Collection() { Id = 29, Name = "Autumn-Winter", year = 2015, FashionHouse = fh1 },
                new Collection() { Id = 30, Name = "Autumn-Winter", year = 2015, FashionHouse = fh1 },
                new Collection() { Id = 31, Name = "Spring-Summmer", year = 2016, FashionHouse = fh1 },
                new Collection() { Id = 32, Name = "Spring-Summer", year = 2016, FashionHouse = fh2 },
                new Collection() { Id = 33, Name = "Spring-Summer", year = 2016, FashionHouse = fh3 },
                new Collection() { Id = 34, Name = "Autumn-Winter", year = 2016, FashionHouse = fh3 },
                new Collection() { Id = 35, Name = "Spring-Summer", year = 2016, FashionHouse = fh3 },
                new Collection() { Id = 39, Name = "Autumn-Winter", year = 2016, FashionHouse = fh1 },
                new Collection() { Id = 40, Name = "Autumn-Winter", year = 2016, FashionHouse = fh1 },
                new Collection() { Id = 1, Name = "Spring-Summmer",year = 2016, FashionHouse = fh1 },
                new Collection() { Id = 2, Name = "Autumn-Winter",year = 2017, FashionHouse = fh2 },
                new Collection() { Id = 3, Name = "Spring-Summer", year = 2017, FashionHouse = fh3 },

                new Collection() { Id = 3, Name = "Spring-Summer", year = 2017, FashionHouse = fh3 },

                new Collection() { Id = 3, Name = "Spring-Summer", year = 2017, FashionHouse = fh3 },

                new Collection() { Id = 4, Name = "Paris Haute Couture Spring/Summer", year = 2016, FashionHouse = fh4 },
                new Collection() { Id = 5, Name = "New York Fashion Week Fall/Winter", year = 2017, FashionHouse = fh5 });


            context.SaveChanges(); 
            base.Seed(context);

        }
    }
}
 