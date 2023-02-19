using Eastnetic.DAL.Domain;
using Eastnetic.DAL.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eastnetic.DAL
{
    public static class DbInitializer
    {
        public static void Initialize(EastneticDbContext context)
        {


            try
            {
                context.Database.EnsureCreated();

                // orders
                context.Orders.Add(
                    new Order
                    {
                        Name = "New York Building 1",
                        State = "NY",
                        Windows = new List<Window> {
                            new Window {
                                Name = "A51" ,
                                QuantityOfWindows= 4 ,
                                SubElements = new List<SubElement>{
                                 new SubElement{ Element = 1, Type = "Doors",Width = 1200, Height= 1850},
                                 new SubElement{ Element = 2, Type = "Window",Width = 800, Height= 1850},
                                 new SubElement{ Element = 3, Type = "Window",Width = 700, Height= 1850}
                                }
                            },
                            new Window {
                                 Name = "C Zone 5" ,
                                 QuantityOfWindows= 2,
                                 SubElements = new List<SubElement>
                                 {
                                      new SubElement{ Element = 1, Type = "Window",Width = 1500, Height= 2000}
                                 }
                            },
                        }
                    });

                //2
                context.Orders.Add(
                   new Order
                   {
                       Name = "California Hotel AJK",
                       State = "CA",
                       Windows = new List<Window> {
                            new Window {
                                Name = "GLB" ,
                                QuantityOfWindows= 3 ,
                                SubElements = new List<SubElement>{
                                 new SubElement{ Element = 1, Type = "Doors",Width = 1400, Height= 2200},
                                 new SubElement{ Element = 2, Type = "Window",Width = 600, Height= 2200},
                                }
                            },
                            new Window {
                                 Name = "OHF" ,
                                 QuantityOfWindows= 10,
                                 SubElements = new List<SubElement>
                                 {
                                      new SubElement{ Element = 1, Type = "Window",Width = 1500, Height= 2000},
                                      new SubElement{ Element = 1, Type = "Window",Width = 1500, Height= 2000}
                                 }
                            },
                       }
                   });

                 context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(" >>>>  Exception Seed  <<<<<" + ex);
                throw new Exception(" >>>>  Exception Seed  <<<<<");
            }
        }
    }
}
