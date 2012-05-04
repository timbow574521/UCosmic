// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace UCosmic.Www.Mvc.Areas.Identity.Controllers {
    public partial class ForgotPasswordController {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected ForgotPasswordController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.JsonResult ValidateEmailAddress() {
            return new T4MVC_JsonResult(Area, Name, ActionNames.ValidateEmailAddress);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Post() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.Post);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ForgotPasswordController Actions { get { return MVC.Identity.ForgotPassword; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "Identity";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "ForgotPassword";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "ForgotPassword";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass {
            public readonly string Get = "forgot-password";
            public readonly string ValidateEmailAddress = "ValidateEmailAddress";
            public readonly string Post = "forgot-password";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants {
            public const string Get = "forgot-password";
            public const string ValidateEmailAddress = "ValidateEmailAddress";
            public const string Post = "forgot-password";
        }


        static readonly ViewNames s_views = new ViewNames();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewNames Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewNames {
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class T4MVC_ForgotPasswordController: UCosmic.Www.Mvc.Areas.Identity.Controllers.ForgotPasswordController {
        public T4MVC_ForgotPasswordController() : base(Dummy.Instance) { }

        public override System.Web.Mvc.PartialViewResult Get() {
            var callInfo = new T4MVC_PartialViewResult(Area, Name, ActionNames.Get);
            return callInfo;
        }

        public override System.Web.Mvc.JsonResult ValidateEmailAddress(UCosmic.Www.Mvc.Areas.Identity.Models.ForgotPasswordForm model) {
            var callInfo = new T4MVC_JsonResult(Area, Name, ActionNames.ValidateEmailAddress);
            callInfo.RouteValueDictionary.Add("model", model);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Post(UCosmic.Www.Mvc.Areas.Identity.Models.ForgotPasswordForm model) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Post);
            callInfo.RouteValueDictionary.Add("model", model);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591