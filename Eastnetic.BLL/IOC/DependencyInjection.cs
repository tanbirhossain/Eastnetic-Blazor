using Eastnetic.BLL.Services;
using Eastnetic.BLL.Services.Interfaces;
using Eastnetic.DAL.Domain;
using Eastnetic.DAL.Repositories;
using Eastnetic.DAL.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eastnetic.BLL.IOC
{
    public static class DependencyInjection
    {
        
        public static void IOC(this IServiceCollection services)
        {


            #region Services
            services.AddTransient<IOrderService,OrderService>();
            services.AddTransient<IWindowService,WindowService>();
            services.AddTransient<IElementService,ElementService>();

            #endregion


            #region Repositories
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IWindowRepository, WindowRepository>();
            services.AddTransient<IElementRepository, ElementRepository>();
            services.AddDbContext<EastneticDbContext>();
            #endregion
        }
    }
}
