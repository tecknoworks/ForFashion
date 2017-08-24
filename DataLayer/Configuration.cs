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
            var fh5 = new FashionHouse() { Id = 5, Name = "Valentino", PhoneNumber = "+40(0)31 35212331" };
            context.FashionHouse.AddOrUpdate(
                f => f.Id,
                fh1,
                fh2,
                fh3,
                fh4,
                fh5);
            var c1 = new Collection() { Id = 1, Name = "Spring-Summmer", year = 2012, FashionHouse = fh1 };
            var c2 = new Collection() { Id = 2, Name = "Spring-Summmer", year = 2013, FashionHouse = fh1 };
            var c3 = new Collection() { Id = 3, Name = "Spring-Summmer", year = 2014, FashionHouse = fh1 };
            var c4 = new Collection() { Id = 4, Name = "Spring-Summmer", year = 2015, FashionHouse = fh1 };
            var c5 = new Collection() { Id = 5, Name = "Spring-Summmer", year = 2016, FashionHouse = fh1 };
            var c6 = new Collection() { Id = 6, Name = "Spring-Summmer", year = 2017, FashionHouse = fh1 };
            var c7 = new Collection() { Id = 7, Name = "Autumn-Winter", year = 2012, FashionHouse = fh1 };
            var c8 = new Collection() { Id = 8, Name = "Autumn-Winter", year = 2013, FashionHouse = fh1 };
            var c9 = new Collection() { Id = 9, Name = "Autumn-Winter", year = 2014, FashionHouse = fh1 };
            var c10 = new Collection() { Id = 10, Name = "Autumn-Winter", year = 2015, FashionHouse = fh1 };
            var c11 = new Collection() { Id = 11, Name = "Autumn-Winter", year = 2016, FashionHouse = fh1 };
            var c12 = new Collection() { Id = 12, Name = "Autumn-Winter", year = 2017, FashionHouse = fh1 };
            var c13 = new Collection() { Id = 13, Name = "Spring-Summer", year = 2012, FashionHouse = fh2 };
            var c14 = new Collection() { Id = 14, Name = "Spring-Summer", year = 2013, FashionHouse = fh2 };
            var c15 = new Collection() { Id = 15, Name = "Spring-Summer", year = 2014, FashionHouse = fh2 };
            var c16 = new Collection() { Id = 16, Name = "Spring-Summer", year = 2015, FashionHouse = fh2 };
            var c17 = new Collection() { Id = 17, Name = "Spring-Summer", year = 2016, FashionHouse = fh2 };
            var c18 = new Collection() { Id = 18, Name = "Spring-Summer", year = 2017, FashionHouse = fh2 };
            var c19 = new Collection() { Id = 19, Name = "Autumn-Winter", year = 2012, FashionHouse = fh2 };
            var c20 = new Collection() { Id = 20, Name = "Autumn-Winter", year = 2013, FashionHouse = fh2 };
            var c21 = new Collection() { Id = 21, Name = "Autumn-Winter", year = 2014, FashionHouse = fh2 };
            var c22 = new Collection() { Id = 22, Name = "Autumn-Winter", year = 2015, FashionHouse = fh2 };
            var c23 = new Collection() { Id = 23, Name = "Autumn-Winter", year = 2016, FashionHouse = fh2 };
            var c24 = new Collection() { Id = 24, Name = "Autumn-Winter", year = 2017, FashionHouse = fh2 };
            var c25 = new Collection() { Id =25, Name = "Spring-Summer", year = 2012, FashionHouse = fh3 };
            var c26 = new Collection() { Id = 26, Name = "Spring-Summer", year = 2013, FashionHouse = fh3 };
            var c27 = new Collection() { Id = 27, Name = "Spring-Summer", year = 2014, FashionHouse = fh3 };
            var c28 = new Collection() { Id = 28, Name = "Spring-Summer", year = 2015, FashionHouse = fh3 };
            var c29 = new Collection() { Id = 29, Name = "Spring-Summer", year = 2016, FashionHouse = fh3 };
            var c30 = new Collection() { Id = 30, Name = "Spring-Summer", year = 2017, FashionHouse = fh3 };
            var c31 = new Collection() { Id = 31, Name = "Autumn-Winter", year = 2012, FashionHouse = fh3 };
            var c32 = new Collection() { Id = 32, Name = "Autumn-Winter", year = 2013, FashionHouse = fh3 };
            var c33 = new Collection() { Id = 33, Name = "Autumn-Winter", year = 2014, FashionHouse = fh3 };
            var c34 = new Collection() { Id = 34, Name = "Autumn-Winter", year = 2015, FashionHouse = fh3 };
            var c35= new Collection() { Id = 35, Name = "Autumn-Winter", year = 2016, FashionHouse = fh3 };
            var c36 = new Collection() { Id = 36, Name = "Autumn-Winter", year = 2017, FashionHouse = fh3 };
            var c37 = new Collection() { Id = 37, Name = "Spring-Summer", year = 2012, FashionHouse = fh4 };
            var c38 = new Collection() { Id = 38, Name = "Spring-Summer", year = 2013, FashionHouse = fh4 };
            var c39 = new Collection() { Id = 39, Name = "Spring-Summer", year = 2014, FashionHouse = fh4 };
            var c40 = new Collection() { Id = 40, Name = "Spring-Summer", year = 2015, FashionHouse = fh4 };
            var c41 = new Collection() { Id = 41, Name = "Spring-Summer", year = 2016, FashionHouse = fh4 };
            var c42 = new Collection() { Id = 42, Name = "Spring-Summer", year = 2017, FashionHouse = fh4 };
            var c43 = new Collection() { Id = 43, Name = "Autumn-Winter", year = 2012, FashionHouse = fh4 };
            var c44 = new Collection() { Id = 44, Name = "Autumn-Winter", year = 2013, FashionHouse = fh4 };
            var c45 = new Collection() { Id = 45, Name = "Autumn-Winter", year = 2014, FashionHouse = fh4 };
            var c46 = new Collection() { Id = 46, Name = "Autumn-Winter", year = 2015, FashionHouse = fh4 };
            var c47 = new Collection() { Id = 47, Name = "Autumn-Winter", year = 2016, FashionHouse = fh4 };
            var c48 = new Collection() { Id = 48, Name = "Autumn-Winter", year = 2017, FashionHouse = fh4 };
            var c49 = new Collection() { Id = 49, Name = "Spring-Summer", year = 2012, FashionHouse = fh5 };
            var c50 = new Collection() { Id = 50, Name = "Spring-Summer", year = 2013, FashionHouse = fh5 };
            var c51 = new Collection() { Id = 51, Name = "Spring-Summer", year = 2014, FashionHouse = fh5 };
            var c52 = new Collection() { Id = 52, Name = "Spring-Summer", year = 2015, FashionHouse = fh5 };
            var c53 = new Collection() { Id = 53, Name = "Spring-Summer", year = 2016, FashionHouse = fh5 };
            var c54 = new Collection() { Id = 54, Name = "Spring-Summer", year = 2017, FashionHouse = fh5 };
            var c55 = new Collection() { Id = 55, Name = "Autumn-Winter", year = 2012, FashionHouse = fh5 };
            var c56 = new Collection() { Id = 56, Name = "Autumn-Winter", year = 2013, FashionHouse = fh5 };
            var c57 = new Collection() { Id = 57, Name = "Autumn-Winter", year = 2014, FashionHouse = fh5 };
            var c58 = new Collection() { Id = 58, Name = "Autumn-Winter", year = 2015, FashionHouse = fh5 };
            var c59 = new Collection() { Id = 59, Name = "Autumn-Winter", year = 2016, FashionHouse = fh5 };
            var c60 = new Collection() { Id = 60, Name = "Autumn-Winter", year = 2017, FashionHouse = fh5 };
            context.Collection.AddOrUpdate(
                c => c.Id,
                c1,
                c2,
                c3,
                c4,
                c5,
                c6,
                c7,
                c8,
                c9,
                c10,
                c11,
                 c12,
                c13,
                c14,
                c15,
                c16,
                c17,
                c18,
                c19,
                c20,
                c21,
                c22, 
                c23,
                c24,
                c25,
                c26,
                c27,
                c28,
                c29,
                c30,
                c31,
                c32,
                c33,
                 c34,
                c35,
                c36,
                c37,
                c38,
                c39,
                c40,
                c41,
                c42,
                c43,
                c44,
                c45,
                c46,
                c47,
                c48,
                c49,
                c50,
                c51,
                c52,
                c53,
                c54,
                c55,
                c56,
                c57,
                c58,
                c59,
                c60);

            context.Videos.AddOrUpdate(
                new Videos() { Id = 1, VideoUrl = "https://www.youtube.com/embed/RjcD-hyBPOk", Collection_Id = c1.Id },
                new Videos() { Id = 2, VideoUrl = "https://www.youtube.com/embed/waJjDVWGPPg", Collection_Id = c1.Id },
                new Videos() { Id = 3, VideoUrl = "https://www.youtube.com/embed/K4mqreVwBNA", Collection_Id = c1.Id },
                new Videos() { Id = 4, VideoUrl = "https://www.youtube.com/embed/7QoKyDBejFY", Collection_Id = c1.Id },
                new Videos() { Id = 5, VideoUrl = "https://www.youtube.com/embed/L5LKOIbXYgc", Collection_Id = c1.Id },
                new Videos() { Id = 6, VideoUrl = "https://www.youtube.com/embed/Kb4toDnZfvI", Collection_Id = c1.Id },
                new Videos() { Id = 7, VideoUrl = "https://www.youtube.com/embed/4zCSQ9X5Wk0", Collection_Id = c2.Id },
                new Videos() { Id = 8, VideoUrl = "https://www.youtube.com/embed/Gzf4iaO9_b0", Collection_Id = c2.Id },
                new Videos() { Id = 9, VideoUrl = "https://www.youtube.com/embed/CaClzdT-QpY", Collection_Id = c2.Id },
                new Videos() { Id = 10, VideoUrl = "https://www.youtube.com/embed/kDwcjnA0DbM", Collection_Id = c2.Id },
                new Videos() { Id = 11, VideoUrl = "https://www.youtube.com/embed/mu9MJeC6HdE", Collection_Id = c2.Id },
                new Videos() { Id = 12, VideoUrl = "https://www.youtube.com/embed/lQuvcob0e84", Collection_Id = c2.Id },
                 new Videos() { Id = 13, VideoUrl = "https://www.youtube.com/embed/H05yqaINJc8", Collection_Id = c3.Id },
                new Videos() { Id = 14, VideoUrl = "https://www.youtube.com/embed/dcapznGlGag", Collection_Id = c3.Id },
                new Videos() { Id = 15, VideoUrl = "https://www.youtube.com/embed/83KxO1wzjyw", Collection_Id = c3.Id },
                new Videos() { Id = 16, VideoUrl = "https://www.youtube.com/embed/_gRL7L7N2Pk", Collection_Id = c3.Id },
                new Videos() { Id = 17, VideoUrl = "https://www.youtube.com/embed/3GSq9ehBZOo", Collection_Id = c3.Id },
                new Videos() { Id = 18, VideoUrl = "https://www.youtube.com/embed/7Ni68ba194s", Collection_Id = c3.Id },
                 new Videos() { Id = 20, VideoUrl = "https://www.youtube.com/embed/SPwYzIZoYA8", Collection_Id = c4.Id },
                new Videos() { Id = 21, VideoUrl = "https://www.youtube.com/embed/HmPTucTXyyY", Collection_Id = c4.Id },
                new Videos() { Id = 22, VideoUrl = "https://www.youtube.com/embed/QGmJdnbW0hY", Collection_Id = c4.Id },
                new Videos() { Id = 23, VideoUrl = "https://www.youtube.com/embed/CQYLSf-PLCQ", Collection_Id = c4.Id },
                new Videos() { Id = 24, VideoUrl = "https://www.youtube.com/embed/TBzeL-PE8Os", Collection_Id = c4.Id },
                new Videos() { Id = 25, VideoUrl = "https://www.youtube.com/embed/yGlnOyc_CZY", Collection_Id = c4.Id },
                new Videos() { Id = 26, VideoUrl = "https://www.youtube.com/embed/B7LSdEndZ9k", Collection_Id = c5.Id },
                new Videos() { Id = 27, VideoUrl = "https://www.youtube.com/embed/EHmp8FJyIX0", Collection_Id = c5.Id },
                new Videos() { Id = 28, VideoUrl = "https://www.youtube.com/embed/XFZgWAC7tZc", Collection_Id = c5.Id },
                new Videos() { Id = 29, VideoUrl = "https://www.youtube.com/embed/bVkV60FCPp8", Collection_Id = c5.Id },
                new Videos() { Id = 30, VideoUrl = "https://www.youtube.com/embed/M3bz3E8lA7c", Collection_Id = c5.Id },
                new Videos() { Id = 31, VideoUrl = "https://www.youtube.com/embed/JLAb1cb9Z0o", Collection_Id = c5.Id },
                new Videos() { Id = 32, VideoUrl = "https://www.youtube.com/embed/WVkRePl_9OA", Collection_Id = c6.Id },
                new Videos() { Id = 33, VideoUrl = "https://www.youtube.com/embed/LBzCbYNZHwY", Collection_Id = c6.Id },
                new Videos() { Id = 34, VideoUrl = "https://www.youtube.com/embed/Bul1YthXAqo", Collection_Id = c6.Id },
                new Videos() { Id = 35, VideoUrl = "https://www.youtube.com/embed/gLoZYnsljEw", Collection_Id = c6.Id },
                new Videos() { Id = 36, VideoUrl = "https://www.youtube.com/embed/ZRonQmAInfo", Collection_Id = c6.Id },
                new Videos() { Id = 37, VideoUrl = "https://www.youtube.com/embed/lsQhmrVpjvc", Collection_Id = c6.Id },
                new Videos() { Id = 38, VideoUrl = "https://www.youtube.com/embed/tll6Ew3uNgw", Collection_Id = c7.Id },
                new Videos() { Id = 39, VideoUrl = " https://www.youtube.com/embed/-sbqyaw39RE", Collection_Id = c7.Id },
                new Videos() { Id = 40, VideoUrl = "https://www.youtube.com/embed/IUJRSCEr0dk", Collection_Id = c7.Id },
                new Videos() { Id = 41, VideoUrl = "https://www.youtube.com/embed/CBJn99YrGfo", Collection_Id = c7.Id },
                new Videos() { Id = 42, VideoUrl = "https://www.youtube.com/embed/IUxEQbtw6GU", Collection_Id = c7.Id },
                new Videos() { Id = 43, VideoUrl = "https://www.youtube.com/embed/l6SNxBqv07c", Collection_Id = c7.Id },
                new Videos() { Id = 44, VideoUrl = "https://www.youtube.com/embed/90Ky1s_bsVU", Collection_Id = c8.Id },
                new Videos() { Id = 45, VideoUrl = "https://www.youtube.com/embed/9tXAT-rfza4", Collection_Id = c8.Id },
                new Videos() { Id = 46, VideoUrl = "https://www.youtube.com/embed/oSZpOOZaRhs", Collection_Id = c8.Id },
                new Videos() { Id = 47, VideoUrl = "https://www.youtube.com/embed/88p0Nmpc7e0", Collection_Id = c8.Id },
                new Videos() { Id = 48, VideoUrl = "https://www.youtube.com/embed/J9Ul4ZPUnZY", Collection_Id = c8.Id },
                new Videos() { Id = 49, VideoUrl = "https://www.youtube.com/embed/T_HjzKK0Afc", Collection_Id = c8.Id },
                new Videos() { Id = 50, VideoUrl = "https://www.youtube.com/embed/3coQe5a1Hgc", Collection_Id = c9.Id },
                new Videos() { Id = 51, VideoUrl = "https://www.youtube.com/embed/BMOfP-uhaXY", Collection_Id = c9.Id },
                new Videos() { Id = 52, VideoUrl = "https://www.youtube.com/embed/CWTwdEgk0Ow", Collection_Id = c9.Id },
                new Videos() { Id = 53, VideoUrl = "https://www.youtube.com/embed/q-Oa__Eq_p8", Collection_Id = c9.Id },
                new Videos() { Id = 54, VideoUrl = "https://www.youtube.com/embed/Nl2avEetUMw", Collection_Id = c9.Id },
                new Videos() { Id = 55, VideoUrl = "https://www.youtube.com/embed/EsGnWoDetxk", Collection_Id = c9.Id },
                new Videos() { Id = 56, VideoUrl = "https://www.youtube.com/embed/dfqejXS-13M", Collection_Id = c10.Id },
                new Videos() { Id = 57, VideoUrl = "https://www.youtube.com/embed/q7m_EqVPWmQ", Collection_Id = c10.Id },
                new Videos() { Id = 58, VideoUrl = "https://www.youtube.com/embed/3amm8CrodU0", Collection_Id = c10.Id },
                new Videos() { Id = 59, VideoUrl = "https://www.youtube.com/embed/5JkAr8gBiNU", Collection_Id = c10.Id },
                new Videos() { Id = 60, VideoUrl = "https://www.youtube.com/embed/eraza9SmENw", Collection_Id = c10.Id },
                new Videos() { Id = 61, VideoUrl = "https://www.youtube.com/embed/snSRAsIgcnE", Collection_Id = c10.Id },
                new Videos() { Id = 62, VideoUrl = "https://www.youtube.com/embed/JPki6hI-1Mk", Collection_Id = c11.Id },
                new Videos() { Id = 63, VideoUrl = "https://www.youtube.com/embed/92NdZqyqnvw", Collection_Id = c11.Id },
                new Videos() { Id = 64, VideoUrl = "https://www.youtube.com/embed/WLqpJepdlYY", Collection_Id = c11.Id },
                new Videos() { Id = 65, VideoUrl = "https://www.youtube.com/embed/EYeUKJpLG6k", Collection_Id = c11.Id },
                new Videos() { Id = 66, VideoUrl = "https://www.youtube.com/embed/ZXDnIlGldLU", Collection_Id = c11.Id },
                new Videos() { Id = 67, VideoUrl = "https://www.youtube.com/embed/VD9eUq26x0o", Collection_Id = c11.Id },
                new Videos() { Id = 68, VideoUrl = "https://www.youtube.com/embed/nHMf2i2N54g", Collection_Id = c12.Id },
                new Videos() { Id = 69, VideoUrl = "https://www.youtube.com/embed/ZkMdDlrTLow", Collection_Id = c12.Id },
                new Videos() { Id = 70, VideoUrl = "https://www.youtube.com/embed/OKr_bz8kvSk", Collection_Id = c12.Id },
                new Videos() { Id = 71, VideoUrl = "https://www.youtube.com/embed/vQs1SQNVxY4", Collection_Id = c12.Id },
                new Videos() { Id = 72, VideoUrl = "https://www.youtube.com/embed/sPOYgewQMAo", Collection_Id = c12.Id },
                new Videos() { Id = 73, VideoUrl = "https://www.youtube.com/embed/OLtYsFcd_vg", Collection_Id = c12.Id },
                new Videos() { Id = 74, VideoUrl = "https://www.youtube.com/embed/xLw-hozWzpc", Collection_Id = c13.Id },
                new Videos() { Id = 75, VideoUrl = "https://www.youtube.com/embed/UD46l-xWDUA", Collection_Id = c13.Id },
                new Videos() { Id = 76, VideoUrl = "https://www.youtube.com/embed/OPkKjZGS8qs", Collection_Id = c13.Id },
                new Videos() { Id = 77, VideoUrl = "https://www.youtube.com/embed/i47fMFx9uB0", Collection_Id = c13.Id },
                new Videos() { Id = 78, VideoUrl = "https://www.youtube.com/embed/WCeA_WaXnjY", Collection_Id = c13.Id },
                new Videos() { Id = 79, VideoUrl = "https://www.youtube.com/embed/KHgy_kCk0Uk", Collection_Id = c13.Id },
                 new Videos() { Id = 80, VideoUrl = "https://www.youtube.com/embed/neJj_vF-tGg", Collection_Id = c14.Id },
                new Videos() { Id = 81, VideoUrl = "https://www.youtube.com/embed/8XqTkOpVuI4", Collection_Id = c14.Id },
                new Videos() { Id = 82, VideoUrl = "https://www.youtube.com/embed/f5T6iT3edLk", Collection_Id = c14.Id },
                new Videos() { Id = 83, VideoUrl = "https://www.youtube.com/embed/Jb9woNy2ZZM", Collection_Id = c14.Id },
                new Videos() { Id = 84, VideoUrl = "https://www.youtube.com/embed/XRAPjiN8GXU", Collection_Id = c14.Id },
                new Videos() { Id = 85, VideoUrl = "https://www.youtube.com/embed/gj6YYeECZwc", Collection_Id = c14.Id },
                new Videos() { Id = 86, VideoUrl = "https://www.youtube.com/embed/lnanfptXwPg", Collection_Id = c15.Id },
                new Videos() { Id = 87, VideoUrl = "https://www.youtube.com/embed/F444mqQwHBM", Collection_Id = c15.Id },
                new Videos() { Id = 88, VideoUrl = "https://www.youtube.com/embed/oimQuCk1J10", Collection_Id = c15.Id },
                new Videos() { Id = 89, VideoUrl = "https://www.youtube.com/embed/Ucva9Qf4-GM", Collection_Id = c15.Id },
                new Videos() { Id = 90, VideoUrl = "https://www.youtube.com/embed/_JAGt-qdHLI", Collection_Id = c15.Id },
                new Videos() { Id = 91, VideoUrl = "https://www.youtube.com/embed/bZ4CKUIguzg", Collection_Id = c15.Id },
                new Videos() { Id = 92, VideoUrl = "https://www.youtube.com/embed/emkZ5rVIv7Q", Collection_Id = c16.Id },
                new Videos() { Id = 93, VideoUrl = "https://www.youtube.com/embed/PiVxqpaRRVI", Collection_Id = c16.Id },
                new Videos() { Id = 94, VideoUrl = "https://www.youtube.com/embed/3cDhTzoMj_s", Collection_Id = c16.Id },
                new Videos() { Id = 95, VideoUrl = "https://www.youtube.com/embed/AEUxn8u9_wo", Collection_Id = c16.Id },
                new Videos() { Id = 96, VideoUrl = "https://www.youtube.com/embed/UX-5ML4z24g", Collection_Id = c16.Id },
                new Videos() { Id = 97, VideoUrl = "https://www.youtube.com/embed/LH_BOzTyyQ0", Collection_Id = c16.Id },
                new Videos() { Id = 98, VideoUrl = "https://www.youtube.com/embed/SJebP-toiUs", Collection_Id = c17.Id },
                new Videos() { Id = 99, VideoUrl = "https://www.youtube.com/embed/aV75FYR_0xs", Collection_Id = c17.Id },
                new Videos() { Id = 100, VideoUrl = "https://www.youtube.com/embed/myvGk1-WUgk", Collection_Id = c17.Id },
                new Videos() { Id = 101, VideoUrl = "https://www.youtube.com/embed/o6PEVrQNk4w", Collection_Id = c17.Id },
                new Videos() { Id = 102, VideoUrl = "https://www.youtube.com/embed/2LRL_DwI8yc", Collection_Id = c17.Id },
                new Videos() { Id = 103, VideoUrl = "https://www.youtube.com/embed/myvGk1-WUgk", Collection_Id = c17.Id },
                new Videos() { Id = 104, VideoUrl = "https://www.youtube.com/embed/t15ftuJ7Vl4", Collection_Id = c18.Id },
                new Videos() { Id = 105, VideoUrl = "https://www.youtube.com/embed/TB3KB5lX-W0", Collection_Id = c18.Id },
                new Videos() { Id = 106, VideoUrl = "https://www.youtube.com/embed/reVzAGYuyUY", Collection_Id = c18.Id },
                new Videos() { Id = 107, VideoUrl = "https://www.youtube.com/embed/mDZ9utxSOlE", Collection_Id = c18.Id },
                new Videos() { Id = 108, VideoUrl = "https://www.youtube.com/embed/KY6hgCzIY0A", Collection_Id = c18.Id },
                new Videos() { Id = 109, VideoUrl = "https://www.youtube.com/embed/2sfY6FcZ37A", Collection_Id = c18.Id },
                new Videos() { Id = 110, VideoUrl = "https://www.youtube.com/embed/--vB3yMS-jw", Collection_Id = c19.Id },
                new Videos() { Id = 111, VideoUrl = "https://www.youtube.com/embed/C4q7E6GHQMw", Collection_Id = c19.Id },
                new Videos() { Id = 112, VideoUrl = "https://www.youtube.com/embed/4_IxRGRbs24", Collection_Id = c19.Id },
                new Videos() { Id = 113, VideoUrl = "https://www.youtube.com/embed/yGKlTjeh__4", Collection_Id = c19.Id },
                new Videos() { Id = 114, VideoUrl = "https://www.youtube.com/embed/yPtUNwOdfNE", Collection_Id = c19.Id },
                new Videos() { Id = 115, VideoUrl = "https://www.youtube.com/embed/CjJycC03Xc", Collection_Id = c19.Id },
                new Videos() { Id = 116, VideoUrl = "https://www.youtube.com/embed/_zpXReTyjdo", Collection_Id = c20.Id },
                new Videos() { Id = 117, VideoUrl = "https://www.youtube.com/embed/9KdjKGwjVyI", Collection_Id = c20.Id },
                new Videos() { Id = 118, VideoUrl = "https://www.youtube.com/embed/t53oO9_GYLM", Collection_Id = c20.Id },
                new Videos() { Id = 119, VideoUrl = "https://www.youtube.com/embed/hr1YJjq0zGI", Collection_Id = c20.Id },
                new Videos() { Id = 120, VideoUrl = "https://www.youtube.com/embed/YuaWRmnRZUg", Collection_Id = c20.Id },
                new Videos() { Id = 121, VideoUrl = "https://www.youtube.com/embed/IAQ5aFuPat0", Collection_Id = c20.Id },
                new Videos() { Id = 122, VideoUrl = "https://www.youtube.com/embed/YLDUXZ4X5b8", Collection_Id = c21.Id },
                new Videos() { Id = 123, VideoUrl = "https://www.youtube.com/embed/Ggm5v9Kp284", Collection_Id = c21.Id },
                new Videos() { Id = 124, VideoUrl = "https://www.youtube.com/embed/ry8h_wLwAPE", Collection_Id = c21.Id },
                new Videos() { Id = 125, VideoUrl = "https://www.youtube.com/embed/M_WUvsFY9-4", Collection_Id = c21.Id },
                new Videos() { Id = 126, VideoUrl = "https://www.youtube.com/embed/EoZZdc67nIM", Collection_Id = c21.Id },
                new Videos() { Id = 127, VideoUrl = "https://www.youtube.com/embed/EUXkJivPPPM", Collection_Id = c21.Id },
                new Videos() { Id = 128, VideoUrl = "https://www.youtube.com/embed/eKPRfbxUNXQ", Collection_Id = c22.Id },
                new Videos() { Id = 129, VideoUrl = "https://www.youtube.com/embed/cjH6VC87xKo", Collection_Id = c22.Id },
                new Videos() { Id = 130, VideoUrl = "https://www.youtube.com/embed/7xndO1o6cSM", Collection_Id = c22.Id },
                new Videos() { Id = 131, VideoUrl = "https://www.youtube.com/embed/RRig6UET7RE", Collection_Id = c22.Id },
                new Videos() { Id = 132, VideoUrl = "https://www.youtube.com/embed/fKbRCv-do7M", Collection_Id = c22.Id },
                new Videos() { Id = 133, VideoUrl = "https://www.youtube.com/embed/06FBO8ooUiE", Collection_Id = c22.Id },
                new Videos() { Id = 134, VideoUrl = "https://www.youtube.com/embed/MpglcX70uO0", Collection_Id = c23.Id },
                new Videos() { Id = 135, VideoUrl = "https://www.youtube.com/embed/OW07pvev4Ts", Collection_Id = c23.Id },
                new Videos() { Id = 136, VideoUrl = "https://www.youtube.com/embed/-kmPNmx0AB8", Collection_Id = c23.Id },
                new Videos() { Id = 137, VideoUrl = "https://www.youtube.com/embed/QpLFXD3ocus", Collection_Id = c23.Id },
                new Videos() { Id = 138, VideoUrl = "https://www.youtube.com/embed/R4e3A68ocSc", Collection_Id = c23.Id },
                new Videos() { Id = 139, VideoUrl = "https://www.youtube.com/embed/A3xE5Ri72Jk", Collection_Id = c23.Id },
                new Videos() { Id = 140, VideoUrl = "https://www.youtube.com/embed/qHzam_SGlJo", Collection_Id = c24.Id },
                new Videos() { Id = 141, VideoUrl = "https://www.youtube.com/embed/C89jkwr_wXk", Collection_Id = c24.Id },
                new Videos() { Id = 142, VideoUrl = "https://www.youtube.com/embed/Czad12InxjM", Collection_Id = c24.Id },
                new Videos() { Id = 143, VideoUrl = "https://www.youtube.com/embed/LgQBa3t_Yag", Collection_Id = c24.Id },
                new Videos() { Id = 144, VideoUrl = "https://www.youtube.com/embed/bLioTHjXwBc", Collection_Id = c24.Id },
                new Videos() { Id = 145, VideoUrl = "https://www.youtube.com/embed/BrL6zUAI1HY", Collection_Id = c24.Id },
                new Videos() { Id = 146, VideoUrl = "https://www.youtube.com/embed/UbRCn-VM96E", Collection_Id = c25.Id },
                new Videos() { Id = 147, VideoUrl = "https://www.youtube.com/embed/R0zEYGtLxI0", Collection_Id = c25.Id },
                new Videos() { Id = 148, VideoUrl = "https://www.youtube.com/embed/ciRMSqVobeU", Collection_Id = c25.Id },
                new Videos() { Id = 149, VideoUrl = "https://www.youtube.com/embed/oszhrG-3-bI", Collection_Id = c25.Id },
                new Videos() { Id = 150, VideoUrl = "https://www.youtube.com/embed/Np3IYyCWaJU", Collection_Id = c25.Id },
                new Videos() { Id = 151, VideoUrl = "https://www.youtube.com/embed/gOXNK_lK56I", Collection_Id = c25.Id },
                new Videos() { Id = 152, VideoUrl = "https://www.youtube.com/embed/byr9kwkQtw8", Collection_Id = c26.Id },
                new Videos() { Id = 153, VideoUrl = "https://www.youtube.com/embed/WBdmqTCIWw0", Collection_Id = c26.Id },
                new Videos() { Id = 154, VideoUrl = "https://www.youtube.com/embed/QpmSCj6mGtQ", Collection_Id = c26.Id },
                new Videos() { Id = 155, VideoUrl = "https://www.youtube.com/embed/45Mt7jn0FpI", Collection_Id = c26.Id },
                new Videos() { Id = 156, VideoUrl = "https://www.youtube.com/embed/k-EuvYedWUw", Collection_Id = c26.Id },
                new Videos() { Id = 157, VideoUrl = "https://www.youtube.com/embed/PatcHulofTk", Collection_Id = c26.Id },
                new Videos() { Id = 158, VideoUrl = "https://www.youtube.com/embed/nmf2vpeG9Kc", Collection_Id = c27.Id },
                new Videos() { Id = 159, VideoUrl = "https://www.youtube.com/embed/NfwK0yAnJ4g", Collection_Id = c27.Id },
                new Videos() { Id = 160, VideoUrl = "https://www.youtube.com/embed/eE_f4hZxXnQ", Collection_Id = c27.Id },
                new Videos() { Id = 161, VideoUrl = "https://www.youtube.com/embed/NAl0B5RW5Vo", Collection_Id = c27.Id },
                new Videos() { Id = 162, VideoUrl = "https://www.youtube.com/embed/2H-MPhfGXgs", Collection_Id = c27.Id },
                new Videos() { Id = 163, VideoUrl = "https://www.youtube.com/embed/HwKO_9r5WTI", Collection_Id = c27.Id },
                new Videos() { Id = 164, VideoUrl = "https://www.youtube.com/embed/TZYJ0gCKdh8", Collection_Id = c28.Id },
                new Videos() { Id = 165, VideoUrl = "https://www.youtube.com/embed/kt3QFM7dvos", Collection_Id = c28.Id },
                new Videos() { Id = 166, VideoUrl = "https://www.youtube.com/embed/zkPb1eRC8SM", Collection_Id = c28.Id },
                new Videos() { Id = 167, VideoUrl = "https://www.youtube.com/embed/Ku4ZsHIE4zg", Collection_Id = c28.Id },
                new Videos() { Id = 168, VideoUrl = "https://www.youtube.com/embed/duIgnPqPlwA", Collection_Id = c28.Id },
                new Videos() { Id = 169, VideoUrl = "https://www.youtube.com/embed/sw6Z3jfkg6k", Collection_Id = c28.Id },
                new Videos() { Id = 170, VideoUrl = "https://www.youtube.com/embed/Cioa-jes2Ls", Collection_Id = c29.Id },
                new Videos() { Id = 171, VideoUrl = "https://www.youtube.com/embed/l9b5jym0ig8", Collection_Id = c29.Id },
                new Videos() { Id = 172, VideoUrl = "https://www.youtube.com/embed/gmQxKps7iRM", Collection_Id = c29.Id },
                new Videos() { Id = 173, VideoUrl = "https://www.youtube.com/embed/vQJm8JW4moM", Collection_Id = c29.Id },
                new Videos() { Id = 174, VideoUrl = "https://www.youtube.com/embed/plQi_TR-fCQ", Collection_Id = c29.Id },
                new Videos() { Id = 175, VideoUrl = "https://www.youtube.com/embed/vp7O2JWS6QE", Collection_Id = c29.Id },
                new Videos() { Id = 176, VideoUrl = "https://www.youtube.com/embed/KpKUmZcUKRA", Collection_Id = c30.Id },
                new Videos() { Id = 177, VideoUrl = "https://www.youtube.com/embed/MlC5NT6HGBU", Collection_Id = c30.Id },
                new Videos() { Id = 178, VideoUrl = "https://www.youtube.com/embed/VQszVWxYjSw", Collection_Id = c30.Id },
                new Videos() { Id = 179, VideoUrl = "https://www.youtube.com/embed/aRS0cEaAT5Q", Collection_Id = c30.Id },
                new Videos() { Id = 180, VideoUrl = "https://www.youtube.com/embed/0XbBt1xrD_c", Collection_Id = c30.Id },
                new Videos() { Id = 181, VideoUrl = "https://www.youtube.com/embed/e-p5V7eyWAY", Collection_Id = c30.Id },
                 new Videos() { Id = 182, VideoUrl = "https://www.youtube.com/embed/h1isWKeYwwc", Collection_Id = c31.Id },
                new Videos() { Id = 183, VideoUrl = "https://www.youtube.com/embed/FvanMst64MU", Collection_Id = c31.Id },
                new Videos() { Id = 184, VideoUrl = "https://www.youtube.com/embed/LjAi-EXDc2g", Collection_Id = c31.Id },
                new Videos() { Id = 185, VideoUrl = "https://www.youtube.com/embed/7ka4FnWRXq0", Collection_Id = c31.Id },
                new Videos() { Id = 186, VideoUrl = "https://www.youtube.com/embed/IKBzXBxWV60", Collection_Id = c31.Id },
                new Videos() { Id = 187, VideoUrl = "https://www.youtube.com/embed/DfMAoCnIDxw", Collection_Id = c31.Id },
                new Videos() { Id = 188, VideoUrl = "https://www.youtube.com/embed/tpl3IZ9aRGE", Collection_Id = c32.Id },
                new Videos() { Id = 189, VideoUrl = "https://www.youtube.com/embed/CUCQdm4Ycgw", Collection_Id = c32.Id },
                new Videos() { Id = 190, VideoUrl = "https://www.youtube.com/embed/7pwUvDtZnQs", Collection_Id = c32.Id },
                new Videos() { Id = 191, VideoUrl = "https://www.youtube.com/embed/cuZgJ77J8Bw", Collection_Id = c32.Id },
                new Videos() { Id = 192, VideoUrl = "https://www.youtube.com/embed/N3j_y4mfruI", Collection_Id = c32.Id },
                new Videos() { Id = 193, VideoUrl = "https://www.youtube.com/embed/PlOxesXmYT0", Collection_Id = c32.Id },
                new Videos() { Id = 194, VideoUrl = "https://www.youtube.com/embed/yfGd_y2ydGA", Collection_Id = c33.Id },
                new Videos() { Id = 195, VideoUrl = "https://www.youtube.com/embed/P2tR02yn5oU", Collection_Id = c33.Id },
                new Videos() { Id = 196, VideoUrl = "https://www.youtube.com/embed/xROv7oksbWo", Collection_Id = c33.Id },
                new Videos() { Id = 197, VideoUrl = "https://www.youtube.com/embed/IBpWqfT8uk4", Collection_Id = c33.Id },
                new Videos() { Id = 198, VideoUrl = "https://www.youtube.com/embed/u6DYJypGG5w", Collection_Id = c33.Id },
                new Videos() { Id = 199, VideoUrl = "https://www.youtube.com/embed/tQGj1pDHhE4", Collection_Id = c33.Id },
                new Videos() { Id = 200, VideoUrl = "https://www.youtube.com/embed/mZXkhXcZ3AQ", Collection_Id = c34.Id },
                new Videos() { Id = 201, VideoUrl = "https://www.youtube.com/embed/UkPEMv4CdIE", Collection_Id = c34.Id },
                new Videos() { Id = 202, VideoUrl = "https://www.youtube.com/embed/X1W6Ce6Mjj4", Collection_Id = c34.Id },
                new Videos() { Id = 203, VideoUrl = "https://www.youtube.com/embed/WtSTkLZGxJQ", Collection_Id = c34.Id },
                new Videos() { Id = 204, VideoUrl = "https://www.youtube.com/embed/YcJpyaZ8N8M", Collection_Id = c34.Id },
                new Videos() { Id = 205, VideoUrl = "https://www.youtube.com/embed/NNXOr5D6NAM", Collection_Id = c34.Id },
                 new Videos() { Id = 206, VideoUrl = "https://www.youtube.com/embed/YucJfazpfoU", Collection_Id = c35.Id },
                new Videos() { Id = 207, VideoUrl = "https://www.youtube.com/embed/zp1l2NbvKx8", Collection_Id = c35.Id },
                new Videos() { Id = 208, VideoUrl = "https://www.youtube.com/embed/z9lHqFpO7CQ", Collection_Id = c35.Id },
                new Videos() { Id = 209, VideoUrl = "https://www.youtube.com/embed/uD7wGLEfor4", Collection_Id = c35.Id },
                new Videos() { Id = 210, VideoUrl = "https://www.youtube.com/embed/b_0yhNR5M4I", Collection_Id = c35.Id },
                new Videos() { Id = 211, VideoUrl = "https://www.youtube.com/embed/sNcwD4LtPi4", Collection_Id = c35.Id },
                new Videos() { Id = 212, VideoUrl = "https://www.youtube.com/embed/FGW_8dMpxIU", Collection_Id = c36.Id },
                new Videos() { Id = 213, VideoUrl = "https://www.youtube.com/embed/ydWM9nxtn3c", Collection_Id = c36.Id },
                new Videos() { Id = 214, VideoUrl = "https://www.youtube.com/embed/I0KWX7ncUBA", Collection_Id = c36.Id },
                new Videos() { Id = 215, VideoUrl = "https://www.youtube.com/embed/yrinl3P0U5M", Collection_Id = c36.Id },
                new Videos() { Id = 216, VideoUrl = "https://www.youtube.com/embed/DsYmQRXPXk8", Collection_Id = c36.Id },
                new Videos() { Id = 217, VideoUrl = "https://www.youtube.com/embed/CZUJD5UdVzU", Collection_Id = c36.Id },
                new Videos() { Id = 218, VideoUrl = "https://www.youtube.com/embed/CeLMzSLTLmU", Collection_Id = c37.Id },
                new Videos() { Id = 219, VideoUrl = "https://www.youtube.com/embed/t4mI2Pec8Uo", Collection_Id = c37.Id },
                new Videos() { Id = 220, VideoUrl = "https://www.youtube.com/embed/zTTM_BogNfc", Collection_Id = c37.Id },
                new Videos() { Id = 221, VideoUrl = "https://www.youtube.com/embed/TEqUuAyq2rI", Collection_Id = c37.Id },
                new Videos() { Id = 222, VideoUrl = "https://www.youtube.com/embed/lu6apyi2rGk", Collection_Id = c37.Id },
                new Videos() { Id = 223, VideoUrl = "https://www.youtube.com/embed/wLD0PG1B__4", Collection_Id = c37.Id },
                new Videos() { Id = 224, VideoUrl = "https://www.youtube.com/embed/EG61c_-gSWo", Collection_Id = c38.Id },
                new Videos() { Id = 225, VideoUrl = "https://www.youtube.com/embed/wSl3Mijmg3I", Collection_Id = c38.Id },
                new Videos() { Id = 226, VideoUrl = "https://www.youtube.com/embed/mqAzgyVmb2w", Collection_Id = c38.Id },
                new Videos() { Id = 227, VideoUrl = "https://www.youtube.com/embed/s9sJDqxFGJM", Collection_Id = c38.Id },
                new Videos() { Id = 228, VideoUrl = "https://www.youtube.com/embed/tC8Q1MIJuAg", Collection_Id = c38.Id },
                new Videos() { Id = 229, VideoUrl = "https://www.youtube.com/embed/JjHzpSOuJt8", Collection_Id = c38.Id },
                 new Videos() { Id = 230, VideoUrl = "https://www.youtube.com/embed/kkiOwDEQxCs", Collection_Id = c39.Id },
                new Videos() { Id = 231, VideoUrl = "https://www.youtube.com/embed/6Egmu7GN5s8", Collection_Id = c39.Id },
                new Videos() { Id = 232, VideoUrl = "https://www.youtube.com/embed/46cFnvul3Hw", Collection_Id = c39.Id },
                new Videos() { Id = 233, VideoUrl = "https://www.youtube.com/embed/aG-5OCmvHoY", Collection_Id = c39.Id },
                new Videos() { Id = 234, VideoUrl = "https://www.youtube.com/embed/BxofyOkVyqA", Collection_Id = c39.Id },
                new Videos() { Id = 235, VideoUrl = "https://www.youtube.com/embed/7jk8q0TZTxU", Collection_Id = c39.Id },
                new Videos() { Id = 236, VideoUrl = "https://www.youtube.com/embed/_UIF7f6_2jo", Collection_Id = c40.Id },
                new Videos() { Id = 237, VideoUrl = "https://www.youtube.com/embed/SrugNpFB3Ps", Collection_Id = c40.Id },
                new Videos() { Id = 238, VideoUrl = "https://www.youtube.com/embed/13ednlM3HHs", Collection_Id = c40.Id },
                new Videos() { Id = 239, VideoUrl = "https://www.youtube.com/embed/Td6Vch3ZM3k", Collection_Id = c40.Id },
                new Videos() { Id = 240, VideoUrl = "https://www.youtube.com/embed/AJiD2_BoAE8", Collection_Id = c40.Id },
                new Videos() { Id = 241, VideoUrl = "https://www.youtube.com/embed/K0t-aBAYym8", Collection_Id = c40.Id },
                new Videos() { Id = 242, VideoUrl = "https://www.youtube.com/embed/Hy2gena6tdw", Collection_Id = c41.Id },
                new Videos() { Id = 243, VideoUrl = "https://www.youtube.com/embed/5Ygm2XrFxmU", Collection_Id = c41.Id },
                new Videos() { Id = 244, VideoUrl = "https://www.youtube.com/embed/jTlg3gNCEkE", Collection_Id = c41.Id },
                new Videos() { Id = 245, VideoUrl = "https://www.youtube.com/embed/1kaWl2g6boQ", Collection_Id = c41.Id },
                new Videos() { Id = 246, VideoUrl = "https://www.youtube.com/embed/kARayzvIFpY", Collection_Id = c41.Id },
                new Videos() { Id = 247, VideoUrl = "https://www.youtube.com/embed/sFdtoRj17O8", Collection_Id = c41.Id },
                new Videos() { Id = 248, VideoUrl = "https://www.youtube.com/embed/ctADLL1Qo9g", Collection_Id = c42.Id },
                new Videos() { Id = 249, VideoUrl = "https://www.youtube.com/embed/6R2ScktVuHs", Collection_Id = c42.Id },
                new Videos() { Id = 250, VideoUrl = "https://www.youtube.com/embed/Hy2gena6tdw", Collection_Id = c42.Id },
                new Videos() { Id = 251, VideoUrl = "https://www.youtube.com/embed/Vb4gt7ehZo8", Collection_Id = c42.Id },
                new Videos() { Id = 252, VideoUrl = "https://www.youtube.com/embed/kARayzvIFpY", Collection_Id = c42.Id },
                new Videos() { Id = 253, VideoUrl = "https://www.youtube.com/embed/YZK5UHzzU1A", Collection_Id = c42.Id },
                new Videos() { Id = 254, VideoUrl = "https://www.youtube.com/embed/SVGiSBkJujQ", Collection_Id = c43.Id },
                new Videos() { Id = 255, VideoUrl = "https://www.youtube.com/embed/2G6mMvIyiUA", Collection_Id = c43.Id },
                new Videos() { Id = 256, VideoUrl = "https://www.youtube.com/embed/rJEYMY3UBJA", Collection_Id = c43.Id },
                new Videos() { Id = 257, VideoUrl = "https://www.youtube.com/embed/OWx3X6OXRiU", Collection_Id = c43.Id },
                new Videos() { Id = 258, VideoUrl = "https://www.youtube.com/embed/0UpzQZ60F6k", Collection_Id = c43.Id },
                new Videos() { Id = 259, VideoUrl = "https://www.youtube.com/embed/rvs1VdJ4FUA", Collection_Id = c43.Id },
                new Videos() { Id = 260, VideoUrl = "https://www.youtube.com/embed/_cH9kpSgw3U", Collection_Id = c44.Id },
                new Videos() { Id = 261, VideoUrl = "https://www.youtube.com/embed/WOvJmBocjrc", Collection_Id = c44.Id },
                new Videos() { Id = 262, VideoUrl = "https://www.youtube.com/embed/F3X807nde1Q", Collection_Id = c44.Id },
                new Videos() { Id = 263, VideoUrl = "https://www.youtube.com/embed/39fNJ8smics", Collection_Id = c44.Id },
                new Videos() { Id = 264, VideoUrl = "https://www.youtube.com/embed/-2FZfavyCZE", Collection_Id = c44.Id },
                new Videos() { Id = 265, VideoUrl = "https://www.youtube.com/embed/jm_Z8WymNcg", Collection_Id = c44.Id },
                new Videos() { Id = 266, VideoUrl = "https://www.youtube.com/embed/8O1atikuF3Q", Collection_Id = c45.Id },
                new Videos() { Id = 267, VideoUrl = "https://www.youtube.com/embed/ffC2Eveua4g", Collection_Id = c45.Id },
                new Videos() { Id = 268, VideoUrl = "https://www.youtube.com/embed/4hbMl7h_73w", Collection_Id = c45.Id },
                new Videos() { Id = 269, VideoUrl = "https://www.youtube.com/embed/ov6y2gaovLo", Collection_Id = c45.Id },
                new Videos() { Id = 270, VideoUrl = "https://www.youtube.com/embed/_CxNuvSW1Qk", Collection_Id = c45.Id },
                new Videos() { Id = 271, VideoUrl = "https://www.youtube.com/embed/lPan_86WIDQ", Collection_Id = c45.Id },
                new Videos() { Id = 272, VideoUrl = "https://www.youtube.com/embed/yiSgqph6TPA", Collection_Id = c46.Id },
                new Videos() { Id = 273, VideoUrl = "https://www.youtube.com/embed/q3CjFZiCHhw", Collection_Id = c46.Id },
                new Videos() { Id = 274, VideoUrl = "https://www.youtube.com/embed/vXG5HMpIGCA", Collection_Id = c46.Id },
                new Videos() { Id = 275, VideoUrl = "https://www.youtube.com/embed/pRL1HjOn_H4", Collection_Id = c46.Id },
                new Videos() { Id = 276, VideoUrl = "https://www.youtube.com/embed/1GpleB9SFlY", Collection_Id = c46.Id },
                new Videos() { Id = 277, VideoUrl = "https://www.youtube.com/embed/M4k_UEuQgeA", Collection_Id = c46.Id },
                new Videos() { Id = 278, VideoUrl = "https://www.youtube.com/embed/8Qc-T2fq5k4", Collection_Id = c47.Id },
                new Videos() { Id = 279, VideoUrl = "https://www.youtube.com/embed/CMn9fAOVXws", Collection_Id = c47.Id },
                new Videos() { Id = 280, VideoUrl = "https://www.youtube.com/embed/HMRbSI6QAWs", Collection_Id = c47.Id },
                new Videos() { Id = 281, VideoUrl = "https://www.youtube.com/embed/DtsNy3AetEs", Collection_Id = c47.Id },
                new Videos() { Id = 282, VideoUrl = "https://www.youtube.com/embed/9KB7bEr_CPU", Collection_Id = c47.Id },
                new Videos() { Id = 283, VideoUrl = "https://www.youtube.com/embed/J-CSdrmdG2c", Collection_Id = c47.Id },
                new Videos() { Id = 284, VideoUrl = "https://www.youtube.com/embed/wtRBQEYfIy0", Collection_Id = c48.Id },
                new Videos() { Id = 285, VideoUrl = "https://www.youtube.com/embed/P-jK-CgPW4Q", Collection_Id = c48.Id },
                new Videos() { Id = 286, VideoUrl = "https://www.youtube.com/embed/TUxnUD5pWRQ", Collection_Id = c48.Id },
                new Videos() { Id = 287, VideoUrl = "https://www.youtube.com/embed/fEPKPsZJH0Y", Collection_Id = c48.Id },
                new Videos() { Id = 288, VideoUrl = "https://www.youtube.com/embed/uwFwPmlULy0", Collection_Id = c48.Id },
                new Videos() { Id = 289, VideoUrl = "https://www.youtube.com/embed/jZc86I0E5X0", Collection_Id = c48.Id },
                new Videos() { Id = 290, VideoUrl = "https://www.youtube.com/embed/Ka0XKBPtA8Q", Collection_Id = c49.Id },
                new Videos() { Id = 291, VideoUrl = "https://www.youtube.com/embed/BKlZBVFWrqk", Collection_Id = c49.Id },
                new Videos() { Id = 292, VideoUrl = "https://www.youtube.com/embed/37WGWpI0uEw", Collection_Id = c49.Id },
                new Videos() { Id = 293, VideoUrl = "https://www.youtube.com/embed/nvL3fQSMqcI", Collection_Id = c49.Id },
                new Videos() { Id = 294, VideoUrl = "https://www.youtube.com/embed/iNQIm5VRGxU", Collection_Id = c49.Id },
                new Videos() { Id = 295, VideoUrl = "https://www.youtube.com/embed/y1kwtOB8ubc", Collection_Id = c50.Id },
                new Videos() { Id = 296, VideoUrl = "https://www.youtube.com/embed/uEMpGgs8-VM", Collection_Id = c50.Id },
                new Videos() { Id = 297, VideoUrl = "https://www.youtube.com/embed/HmuUhDBDYZw", Collection_Id = c50.Id },
                new Videos() { Id = 298, VideoUrl = "https://www.youtube.com/embed/LV9f3YeAZ1s", Collection_Id = c50.Id },
                new Videos() { Id = 299, VideoUrl = "https://www.youtube.com/embed/UF1M3Vut_1A", Collection_Id = c50.Id },
                new Videos() { Id = 300, VideoUrl = "https://www.youtube.com/embed/BqgX5C_k8Ps", Collection_Id = c51.Id },
                new Videos() { Id = 301, VideoUrl = "https://www.youtube.com/embed/kKOWahXhH8w", Collection_Id = c51.Id },
                new Videos() { Id = 302, VideoUrl = "https://www.youtube.com/embed/MkQSZbY5G8U", Collection_Id = c51.Id },
                new Videos() { Id = 303, VideoUrl = "https://www.youtube.com/embed/5HH1sUDaATQ", Collection_Id = c51.Id },
                new Videos() { Id = 304, VideoUrl = "https://www.youtube.com/embed/FqN28V6LNJg", Collection_Id = c51.Id },
                new Videos() { Id = 305, VideoUrl = "https://www.youtube.com/embed/N1iCL5RTQN4", Collection_Id = c51.Id },
                new Videos() { Id = 306, VideoUrl = "https://www.youtube.com/embed/yI8xj5vTrJA", Collection_Id = c52.Id },
                new Videos() { Id = 307, VideoUrl = "https://www.youtube.com/embed/ylyoVtQ4uLk", Collection_Id = c52.Id },
                new Videos() { Id = 308, VideoUrl = "https://www.youtube.com/embed/cm-kBiBF_wE", Collection_Id = c52.Id },
                new Videos() { Id = 309, VideoUrl = "https://www.youtube.com/embed/4fu60sCCqqo", Collection_Id = c52.Id },
                new Videos() { Id = 310, VideoUrl = "https://www.youtube.com/embed/LEkzEPQhBt8", Collection_Id = c52.Id },
                new Videos() { Id = 311, VideoUrl = "https://www.youtube.com/embed/VMBKlxDUuBs", Collection_Id = c52.Id },
                new Videos() { Id = 312, VideoUrl = "https://www.youtube.com/embed/i1D1HzlxDzM", Collection_Id = c53.Id },
                new Videos() { Id = 313, VideoUrl = "https://www.youtube.com/embed/VMBKlxDUuBs", Collection_Id = c53.Id },
                new Videos() { Id = 314, VideoUrl = "https://www.youtube.com/embed/BgSUGQ1Hwfo", Collection_Id = c53.Id },
                new Videos() { Id = 315, VideoUrl = "https://www.youtube.com/embed/p2btE5K_3xU", Collection_Id = c53.Id },
                new Videos() { Id = 316, VideoUrl = "https://www.youtube.com/embed/58djxDcQRHk", Collection_Id = c53.Id },
                new Videos() { Id = 317, VideoUrl = "https://www.youtube.com/embed/1WpU0yNm-dA", Collection_Id = c53.Id },
                 new Videos() { Id = 318, VideoUrl = "https://www.youtube.com/embed/K8kZCsrVNQs", Collection_Id = c54.Id },
                new Videos() { Id = 319, VideoUrl = "https://www.youtube.com/embed/P8AQ5xvSp2A", Collection_Id = c54.Id },
                new Videos() { Id = 320, VideoUrl = "https://www.youtube.com/embed/3KSO795lr14", Collection_Id = c54.Id },
                new Videos() { Id = 321, VideoUrl = "https://www.youtube.com/embed/YH8Bhd2Y0Lk", Collection_Id = c54.Id },
                new Videos() { Id = 322, VideoUrl = "https://www.youtube.com/embed/fm5ZovL5Zk0", Collection_Id = c54.Id },
                new Videos() { Id = 323, VideoUrl = "https://www.youtube.com/embed/x1wG0mZjIKQ", Collection_Id = c54.Id },
                 new Videos() { Id = 324, VideoUrl = "https://www.youtube.com/embed/KUUOxZIiR40", Collection_Id = c55.Id },
                new Videos() { Id = 325, VideoUrl = "https://www.youtube.com/embed/VTcbuea2S14", Collection_Id = c55.Id },
                new Videos() { Id = 326, VideoUrl = "https://www.youtube.com/embed/64ihuzio_GM", Collection_Id = c55.Id },
                new Videos() { Id = 327, VideoUrl = "https://www.youtube.com/embed/zViCvrLtvAE", Collection_Id = c55.Id },
                new Videos() { Id = 328, VideoUrl = "https://www.youtube.com/embed/EllHcMb1rO0", Collection_Id = c55.Id },
                new Videos() { Id = 329, VideoUrl = "https://www.youtube.com/embed/dmjnACfBmSo", Collection_Id = c55.Id },
                new Videos() { Id = 330, VideoUrl = "https://www.youtube.com/embed/d4l8aWZQfOk", Collection_Id = c56.Id },
                new Videos() { Id = 331, VideoUrl = "https://www.youtube.com/embed/64ihuzio_GM", Collection_Id = c56.Id },
                new Videos() { Id = 332, VideoUrl = "https://www.youtube.com/embed/VYlhz2bYDwo", Collection_Id = c56.Id },
                new Videos() { Id = 333, VideoUrl = "https://www.youtube.com/embed/1To_SPXj1Og", Collection_Id = c56.Id },
                new Videos() { Id = 334, VideoUrl = "https://www.youtube.com/embed/KlOYAiIzqBo", Collection_Id = c56.Id },
                new Videos() { Id = 335, VideoUrl = "https://www.youtube.com/embed/Ud77cIZiNsE", Collection_Id = c57.Id },
                new Videos() { Id = 336, VideoUrl = "https://www.youtube.com/embed/XR0WpIyzgaw", Collection_Id = c57.Id },
                new Videos() { Id = 337, VideoUrl = "https://www.youtube.com/embed/mrhghr55ENM", Collection_Id = c57.Id },
                new Videos() { Id = 338, VideoUrl = "https://www.youtube.com/embed/h_ald7o2R58", Collection_Id = c57.Id },
                new Videos() { Id = 339, VideoUrl = "https://www.youtube.com/embed/i-8hoN84PHk", Collection_Id = c57.Id },
                 new Videos() { Id = 340, VideoUrl = "https://www.youtube.com/embed/RHg59JR31ho", Collection_Id = c58.Id },
                new Videos() { Id = 341, VideoUrl = "https://www.youtube.com/embed/U5HjdHR0avY", Collection_Id = c58.Id },
                new Videos() { Id = 342, VideoUrl = "https://www.youtube.com/embed/1KkBN08Yy38", Collection_Id = c58.Id },
                new Videos() { Id = 343, VideoUrl = "https://www.youtube.com/embed/nudwI0UMFpg", Collection_Id = c58.Id },
                new Videos() { Id = 344, VideoUrl = "https://www.youtube.com/embed/_4jn8tsXOfw", Collection_Id = c58.Id },
                new Videos() { Id = 345, VideoUrl = "https://www.youtube.com/embed/7Mf8LR7BY0A", Collection_Id = c59.Id },
                new Videos() { Id = 346, VideoUrl = "https://www.youtube.com/embed/8SnbOrMGre4", Collection_Id = c59.Id },
                new Videos() { Id = 347, VideoUrl = "https://www.youtube.com/embed/CLizfyRn9pI", Collection_Id = c59.Id },
                new Videos() { Id = 348, VideoUrl = "https://www.youtube.com/embed/CEDFdXcPHeU", Collection_Id = c59.Id },
                new Videos() { Id = 349, VideoUrl = "https://www.youtube.com/embed/qd87arcGCVU", Collection_Id = c59.Id },
                new Videos() { Id = 350, VideoUrl = "https://www.youtube.com/embed/u-021_XpUQk", Collection_Id = c60.Id },
                new Videos() { Id = 351, VideoUrl = "https://www.youtube.com/embed/RgcG74tP0qw", Collection_Id = c60.Id },
                new Videos() { Id = 352, VideoUrl = "https://www.youtube.com/embed/2dNhSWQS7Kg", Collection_Id = c60.Id },
                new Videos() { Id = 353, VideoUrl = "https://www.youtube.com/embed/xJDBSuMxW-Q", Collection_Id = c60.Id },
                new Videos() { Id = 354, VideoUrl = "https://www.youtube.com/embed/L_NVxiDgcew", Collection_Id = c60.Id }

                );





            context.SaveChanges(); 
            base.Seed(context);
            //
        }
    }
}
 