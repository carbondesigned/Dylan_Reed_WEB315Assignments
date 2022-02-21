using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using web3.Data;

namespace web3.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CompanyContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CompanyContext>>()))
            {
                if (context.Company.Any())
                {
                    return;   // DB has been seeded
                }

                context.Company.AddRange(
                    new Company
                    {
                        Name = "Ford",
                        Description = "Ford Motor Company is an American multinational automobile manufacturer headquartered in Dearborn, Michigan, United States. It was founded by Henry Ford and incorporated on June 16, 1903. The company sells automobiles and commercial vehicles under the Ford brand, and luxury cars under its Lincoln luxury brand.",
                        Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Ford_logo_flat.svg/800px-Ford_logo_flat.svg.png",
                        InterestDate = DateTime.Parse("2021-09-01")
                    },
                    new Company
                    {
                        Name = "Tesla",
                        Description = "Tesla, Inc. is an American electric vehicle and clean energy company based in Austin, Texas. Tesla designs and manufactures electric cars, battery energy storage from home to grid-scale, solar panels and solar roof tiles, and related products and services.",
                        Image = "https://www.carlogos.org/car-logos/tesla-logo-2200x2800.png",
                        InterestDate = DateTime.Parse("2021-04-01")
                    },
                    new Company
                    {
                        Name = "Nvidia",
                        Description = "Nvidia Corporation is an American multinational technology company incorporated in Delaware and based in Santa Clara, California. It designs graphics processing units for the gaming and professional markets, as well as system on a chip units for the mobile computing and automotive market.",
                        Image = "https://yt3.ggpht.com/ytc/AKedOLRy4UNsg6Ytvoi8Pn-r82YxUmkMsaSm49_rqI8Z6lk=s900-c-k-c0x00ffffff-no-rj",
                        InterestDate = DateTime.Parse("2020-04-01")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}