﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using UCosmic.Www.Mvc.Areas.Common.Mappers;
using UCosmic.Www.Mvc.Areas.Common.Models.Features;
using UCosmic.Www.Mvc.Controllers;

namespace UCosmic.Www.Mvc.Areas.Common.Controllers
{
    public partial class FeaturesController : Controller
    {
        [ActionName("releases")]
        [OpenTopTab(TopTabName.Home)]
        public virtual ActionResult Releases(string version = FeaturesRouteMapper.Releases.CurrentVersion)
        {
            var allowedVersions = new Dictionary<string, string>
            {
                { "preview-1",                   "UCosmic Preview 1 Feature Summary"},
                { "preview-2",                   "UCosmic Preview 2 Feature Summary" },
                { "preview-3",                   "UCosmic Preview 3 Feature Summary" }, 
                { "preview-4",                   "UCosmic Preview 4 Feature Summary" },
                { "december-2011-preview-1",     "December 2011 Preview 1 Feature Summary" },
                { "december-2011-preview-2",     "December 2011 Preview 2 Feature Summary" },
                { "february-2012-preview-1",     "February 2012 Preview 1 Feature Summary" },
                { "february-2012-preview-2",     "February 2012 Preview 2 Feature Summary" },
            };
            if (allowedVersions.ContainsKey(version.ToLower()))
            {
                ViewBag.ViewName = version;
                ViewBag.Title = allowedVersions[version];
                return View();
            }
            return HttpNotFound();
        }

        [ChildActionOnly]
        [ActionName("releases-nav")]
        public virtual PartialViewResult ReleasesNav()
        {
            var currentVersion = FeaturesRouteMapper.Releases.CurrentVersion;
            var routeValues = RouteData.Values;
            const string routeKey = "version";

            if (routeValues.ContainsKey(routeKey) && routeValues[routeKey] != null)
                currentVersion = routeValues[routeKey].ToString();
            var model = new List<FeaturePreview>();
            string version;
            for (var i = 1; i <= 4; i++)
            {
                version = string.Format("preview-{0}", i);
                model.Add(new FeaturePreview
                {
                    Name = string.Format("UCosmic Preview {0}", i),
                    Version = version,
                    IsCurrentlyViewed = (version == currentVersion),
                });
            }

            version = "december-2011-preview-1";
            model.Add(new FeaturePreview
            {
                Name = "UCosmic December 2011 Preview 1",
                Version = version,
                IsCurrentlyViewed = (version == currentVersion),
            });

            version = "december-2011-preview-2";
            model.Add(new FeaturePreview
            {
                Name = "UCosmic December 2011 Preview 2",
                Version = version,
                IsCurrentlyViewed = (version == currentVersion),
            });

            version = "february-2012-preview-1";
            model.Add(new FeaturePreview
            {
                Name = "UCosmic February 2012 Preview 1",
                Version = version,
                IsCurrentlyViewed = (version == currentVersion),
            });

            version = "february-2012-preview-2";
            model.Add(new FeaturePreview
            {
                Name = "UCosmic February 2012 Preview 2",
                Version = version,
                IsCurrentlyViewed = (version == currentVersion),
            });

            model.Last().IsLatest = true;
            model.Reverse();
            return PartialView(model);
        }

        [ActionName("requirements")]
        public virtual ActionResult Requirements(string module = null)
        {
            var allowedModules = new Dictionary<string, string>
            {
                { "faculty-staff",         TopTabName.FacultyStaff },
                { "alumni",                TopTabName.Alumni },
                { "students",              TopTabName.Students },
                { "representatives",       TopTabName.Representatives },
                { "travel",                TopTabName.Travel },
                { "corporate-engagement",  TopTabName.CorporateEngagement },
                { "global-press",          TopTabName.GlobalPress },
            };
            if (string.IsNullOrWhiteSpace(module))
            {
                ViewBag.ViewName = "gherkin";
                OpenTopTabAttribute.OpenTopTab(ViewData, TopTabName.Home);
                return View();
            }
            if (allowedModules.ContainsKey(module.ToLower()))
            {
                ViewBag.ViewName = string.Format("{0}-module", module);
                OpenTopTabAttribute.OpenTopTab(ViewData, allowedModules[module]);
                return View();
            }
            return HttpNotFound();
        }

    }
}