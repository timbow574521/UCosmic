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
    public partial class SignInController {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected SignInController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Get() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.Get);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.JsonResult ValidatePassword() {
            return new T4MVC_JsonResult(Area, Name, ActionNames.ValidatePassword);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Post() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.Post);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public SignInController Actions { get { return MVC.Identity.SignIn; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "Identity";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "SignIn";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "SignIn";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass {
            public readonly string Get = "sign-in";
            public readonly string ValidatePassword = "ValidatePassword";
            public readonly string Post = "sign-in";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants {
            public const string Get = "sign-in";
            public const string ValidatePassword = "ValidatePassword";
            public const string Post = "sign-in";
        }


        static readonly ActionParamsClass_Get s_params_Get = new ActionParamsClass_Get();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Get GetParams { get { return s_params_Get; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Get {
            public readonly string returnUrl = "returnUrl";
        }
        static readonly ActionParamsClass_ValidatePassword s_params_ValidatePassword = new ActionParamsClass_ValidatePassword();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ValidatePassword ValidatePasswordParams { get { return s_params_ValidatePassword; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ValidatePassword {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_Post s_params_Post = new ActionParamsClass_Post();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Post PostParams { get { return s_params_Post; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Post {
            public readonly string model = "model";
        }
        static readonly ViewNames s_views = new ViewNames();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewNames Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewNames {
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class T4MVC_SignInController: UCosmic.Www.Mvc.Areas.Identity.Controllers.SignInController {
        public T4MVC_SignInController() : base(Dummy.Instance) { }

        public override System.Web.Mvc.ActionResult Get(string returnUrl) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Get);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "returnUrl", returnUrl);
            return callInfo;
        }

        public override System.Web.Mvc.JsonResult ValidatePassword(UCosmic.Www.Mvc.Areas.Identity.Models.SignInForm model) {
            var callInfo = new T4MVC_JsonResult(Area, Name, ActionNames.ValidatePassword);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Post(UCosmic.Www.Mvc.Areas.Identity.Models.SignInForm model) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Post);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
