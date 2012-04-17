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
    public partial class SelfController {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected SelfController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult EditAffiliation() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.EditAffiliation);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult AutoCompleteNameSalutations() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.AutoCompleteNameSalutations);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult AutoCompleteNameSuffixes() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.AutoCompleteNameSuffixes);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult AutoCompletePersonName() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.AutoCompletePersonName);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult PersonInfoById() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.PersonInfoById);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult PersonInfoByEmail() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.PersonInfoByEmail);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult DeriveDisplayName() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.DeriveDisplayName);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public SelfController Actions { get { return MVC.Identity.Self; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "Identity";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Self";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Self";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass {
            public readonly string Me = "me";
            public readonly string EditAffiliation = "edit-affiliation";
            public readonly string AutoCompleteNameSalutations = "autocomplete-name-salutations";
            public readonly string AutoCompleteNameSuffixes = "autocomplete-name-suffixes";
            public readonly string AutoCompletePersonName = "autocomplete-name";
            public readonly string PersonInfoById = "person-info-by-id";
            public readonly string PersonInfoByEmail = "person-info-by-email";
            public readonly string DeriveDisplayName = "derive-display-name";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants {
            public const string Me = "me";
            public const string EditAffiliation = "edit-affiliation";
            public const string AutoCompleteNameSalutations = "autocomplete-name-salutations";
            public const string AutoCompleteNameSuffixes = "autocomplete-name-suffixes";
            public const string AutoCompletePersonName = "autocomplete-name";
            public const string PersonInfoById = "person-info-by-id";
            public const string PersonInfoByEmail = "person-info-by-email";
            public const string DeriveDisplayName = "derive-display-name";
        }


        static readonly ViewNames s_views = new ViewNames();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewNames Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewNames {
            public readonly string edit_affiliation = "~/Areas/Identity/Views/Self/edit-affiliation.cshtml";
            public readonly string me = "~/Areas/Identity/Views/Self/me.cshtml";
            static readonly _DisplayTemplates s_DisplayTemplates = new _DisplayTemplates();
            public _DisplayTemplates DisplayTemplates { get { return s_DisplayTemplates; } }
            public partial class _DisplayTemplates{
                public readonly string AffiliationInfo = "AffiliationInfo";
                public readonly string EmailInfo = "EmailInfo";
            }
            static readonly _EditorTemplates s_EditorTemplates = new _EditorTemplates();
            public _EditorTemplates EditorTemplates { get { return s_EditorTemplates; } }
            public partial class _EditorTemplates{
                public readonly string AffiliationForm = "AffiliationForm";
                public readonly string PersonForm = "PersonForm";
            }
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class T4MVC_SelfController: UCosmic.Www.Mvc.Areas.Identity.Controllers.SelfController {
        public T4MVC_SelfController() : base(Dummy.Instance) { }

        public override System.Web.Mvc.ActionResult Me() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Me);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Me(UCosmic.Www.Mvc.Areas.Identity.Models.Self.PersonForm model) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Me);
            callInfo.RouteValueDictionary.Add("model", model);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult EditAffiliation(System.Guid? entityId) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.EditAffiliation);
            callInfo.RouteValueDictionary.Add("entityId", entityId);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult EditAffiliation(UCosmic.Www.Mvc.Areas.Identity.Models.Self.AffiliationForm model) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.EditAffiliation);
            callInfo.RouteValueDictionary.Add("model", model);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult AutoCompleteNameSalutations(string term) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.AutoCompleteNameSalutations);
            callInfo.RouteValueDictionary.Add("term", term);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult AutoCompleteNameSuffixes(string term) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.AutoCompleteNameSuffixes);
            callInfo.RouteValueDictionary.Add("term", term);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult AutoCompletePersonName(string term, UCosmic.Www.Mvc.Areas.Identity.Controllers.SelfController.PersonNameProperty termTarget, UCosmic.Www.Mvc.Areas.Identity.Controllers.SelfController.PersonNameProperty? orderTarget) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.AutoCompletePersonName);
            callInfo.RouteValueDictionary.Add("term", term);
            callInfo.RouteValueDictionary.Add("termTarget", termTarget);
            callInfo.RouteValueDictionary.Add("orderTarget", orderTarget);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult PersonInfoById(System.Guid personId) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.PersonInfoById);
            callInfo.RouteValueDictionary.Add("personId", personId);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult PersonInfoByEmail(string email) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.PersonInfoByEmail);
            callInfo.RouteValueDictionary.Add("email", email);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult DeriveDisplayName(UCosmic.Www.Mvc.Areas.Identity.Models.Self.PersonForm model) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.DeriveDisplayName);
            callInfo.RouteValueDictionary.Add("model", model);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
