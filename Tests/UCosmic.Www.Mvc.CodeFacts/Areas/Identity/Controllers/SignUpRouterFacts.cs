﻿using System;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcContrib.TestHelper;
using Should;

namespace UCosmic.Www.Mvc.Areas.Identity.Controllers
{
    public static class SignUpRouterFacts
    {
        private static readonly string AreaName = MVC.Identity.Name;

        [TestClass]
        public class TheGetRoute
        {
            [TestMethod]
            public void Inbound_WithGet_AndEmptyReturnUrl_MapsToAction()
            {
                FormatRoute().WithMethod(HttpVerbs.Get)
                    .ShouldMapTo(Action(null));
            }

            [TestMethod]
            public void Outbound_WithGet_AndEmptyReturnUrl_MapsToUrl()
            {
                OutBoundRoute.Of(Action(null)).InArea(AreaName)
                    .WithMethod(HttpVerbs.Get).AppRelativeUrl()
                    .ShouldEqual(FormatRoute());
            }

            //[TestMethod]
            //public void Inbound_WithGet_AndNonEmptyReturnUrl_MapsToAction()
            //{
            //    const string returnUrl = "/path/to/return/to";
            //    var formattedRoute = FormatRoute(returnUrl);
            //    var withMethod = formattedRoute.WithMethod(HttpVerbs.Get);
            //    withMethod.ShouldMapTo(Action(returnUrl));
            //    FormatRoute(returnUrl).WithMethod(HttpVerbs.Get)
            //        .ShouldMapTo(Action(returnUrl));
            //}

            [TestMethod]
            public void Outbound_WithGet_AndNonEmptyReturnUrl_MapsToUrl()
            {
                const string returnUrl = "/path/to/return/to";
                OutBoundRoute.Of(Action(returnUrl)).InArea(AreaName)
                    .WithMethod(HttpVerbs.Get).AppRelativeUrl()
                    .ShouldEqual(FormatRoute(returnUrl), new CaseInsensitiveStringComparer());
            }

            private static readonly string Route = new SignUpRouter.GetRoute().Url;

            private static Expression<Func<SignUpController, ActionResult>> Action(string returnUrl)
            {
                Expression<Func<SignUpController, ActionResult>> action =
                    controller => controller.Get(returnUrl);
                return action;
            }

            private static string FormatRoute(string returnUrl = null)
            {
                var route = Route.ToAppRelativeUrl().WithoutTrailingSlash();
                if (!string.IsNullOrWhiteSpace(returnUrl))
                    route = string.Format("{0}?returnUrl={1}", route, HttpUtility.UrlEncode(returnUrl));
                return route;
            }
        }

        [TestClass]
        public class ThePostRoute
        {
            [TestMethod]
            public void Inbound_WithPost_MapsToAction()
            {
                FormatRoute().WithMethod(HttpVerbs.Post)
                    .ShouldMapTo(Action);
            }

            [TestMethod]
            public void Outbound_WithPost_MapsToUrl()
            {
                OutBoundRoute.Of(Action).InArea(AreaName).WithMethod(HttpVerbs.Post)
                    .AppRelativeUrl().ShouldEqual(FormatRoute());
            }

            [TestMethod]
            public void Inbound_WithNonGetOrPost_MapsToNothing()
            {
                FormatRoute().WithMethodsExcept(HttpVerbs.Post, HttpVerbs.Get)
                    .ShouldMapToNothing();
            }

            [TestMethod]
            public void Outbound_WithPut_MapsToNothing()
            {
                OutBoundRoute.Of(Action).InArea(AreaName)
                    .WithMethod(HttpVerbs.Put)
                    .AppRelativeUrl().ShouldBeNull();
            }

            private static readonly string Route = new SignUpRouter.PostRoute().Url;
            private static readonly Expression<Func<SignUpController, ActionResult>>
                Action = controller => controller.Post(null);

            private static string FormatRoute()
            {
                return Route.ToAppRelativeUrl().WithoutTrailingSlash();
            }
        }
    }
}
