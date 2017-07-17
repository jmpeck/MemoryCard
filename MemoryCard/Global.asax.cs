using MemoryCard.DAL;
using MemoryCard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace MemoryCard
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            using (var context = new MemoryCardContext())
            {
                //var pack1 = new Pack()
                //{
                //    PackID = 1,
                //    Name = "Spanish 101",
                //    Subject = Subject.Spanish,

                //};

                //var pack2 = new Pack()
                //{
                //    PackID = 2,
                //    Name = "Calculus 101",
                //    Subject = Subject.Calculus,
                //};

                //var pack3 = new Pack()
                //{
                //    PackID = 3,
                //    Name = "Fullstack Javascript",
                //    Subject = Subject.Programming,
                //};
                //context.Packs.Add(pack1);
                //context.Packs.Add(pack2);
                //context.Packs.Add(pack3);

                //context.SaveChanges();
            }
        }
    }
}
