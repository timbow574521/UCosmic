﻿using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using Elmah.Contrib.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using UCosmic.Www.Mvc.Areas.Common;
using UCosmic.Www.Mvc.Areas.Establishments;
using UCosmic.Www.Mvc.Areas.Identity;
using UCosmic.Www.Mvc.Areas.InstitutionalAgreements;
using UCosmic.Www.Mvc.Areas.RecruitmentAgencies;
using UCosmic.Www.Mvc.Mappers;

namespace UCosmic.Www.Mvc
{
    [TestClass]
    public static class GlobalAsaxFacts
    {
        [TestClass]
        public class RegisterGlobalFilters_Method
        {
            [TestMethod]
            public void Registers_ElmahHandleErrorAttribute()
            {
                var filters = new GlobalFilterCollection();
                MvcApplication.RegisterGlobalFilters(filters);

                filters.ShouldNotBeNull();
                filters.Count.ShouldBeInRange(1, int.MaxValue);

                var expectedFilter = filters.SingleOrDefault(filter => 
                    typeof(ElmahHandleErrorAttribute) == filter.Instance.GetType());
                expectedFilter.ShouldNotBeNull();
            }
        }

        [AssemblyInitialize]
        public static void RegisterAllRoutes(TestContext testContext)
        {
            // register routes once when the test suite begins
            RouteTable.Routes.Clear();
            AreaRegistration.RegisterAllAreas();
            MvcApplication.RegisterRoutes(RouteTable.Routes);
            AutoMapperConfig.Configure();
        }
        private static class AreaRegistration
        {
            private static void RegisterArea(System.Web.Mvc.AreaRegistration area, RouteCollection routes)
            {
                var context = new AreaRegistrationContext(area.AreaName, routes);
                context.Namespaces.Add(area.GetType().Namespace);
                area.RegisterArea(context);
            }

            public static void RegisterAllAreas()
            {
                new System.Web.Mvc.AreaRegistration[]
                {
                    new CommonAreaRegistration(), 
                    new EstablishmentsAreaRegistration(), 
                    new IdentityAreaRegistration(), 
                    new InstitutionalAgreementsAreaRegistration(), 
                    new RecruitmentAgenciesAreaRegistration(), 

                }.ToList().ForEach(area => RegisterArea(area, RouteTable.Routes));
            }
        }
    }
}