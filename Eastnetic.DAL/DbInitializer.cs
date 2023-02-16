//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Eastnetic.DAL
//{
//    public static class DbInitializer
//    {
//        public static void Initialize(BilbaytContext context)
//        {


//            try
//            {
//                //context.Database.EnsureDeleted();
//                context.Database.EnsureCreated();

//                // client 
//                // pass: 1234
//                var client = new Client
//                {

//                    Id = Guid.NewGuid().ToString(),
//                    FullName = "Mohammed Tanbir",
//                    Email = "ovibhuiyan43@gmail.com",
//                    Password = "57a0f401fbbe2df3bd258d89e5a73808fa51a10d6a8188f90aab1a988770e4b7ef533198adb539547df8887bc743d6bc76fb6ab5a8ee67929834b4066d70df8e",

//                };

//                context.Client.Add(client);
//                context.SaveChanges();
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(" >>>>  Exception Seed  <<<<<" + ex);
//                throw new Exception(" >>>>  Exception Seed  <<<<<");
//            }
//        }
//    }
//}
