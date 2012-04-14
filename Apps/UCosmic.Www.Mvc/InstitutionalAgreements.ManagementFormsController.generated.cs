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
namespace UCosmic.Www.Mvc.Areas.InstitutionalAgreements.Controllers {
    public partial class ManagementFormsController {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected ManagementFormsController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Post() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.Post);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult AddParticipant() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.AddParticipant);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult AttachFile() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.AttachFile);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult AddContact() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.AddContact);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult DeriveTitle() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.DeriveTitle);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult AutoCompleteEstablishmentNames() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.AutoCompleteEstablishmentNames);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ManagementFormsController Actions { get { return MVC.InstitutionalAgreements.ManagementForms; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "InstitutionalAgreements";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "ManagementForms";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "ManagementForms";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass {
            public readonly string Browse = "browse";
            public readonly string Post = "post";
            public readonly string AddParticipant = "add-participant";
            public readonly string AttachFile = "attach-file";
            public readonly string AddContact = "add-contact";
            public readonly string DeriveTitle = "derive-title";
            public readonly string AutoCompleteEstablishmentNames = "autocomplete-establishment-names";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants {
            public const string Browse = "browse";
            public const string Post = "post";
            public const string AddParticipant = "add-participant";
            public const string AttachFile = "attach-file";
            public const string AddContact = "add-contact";
            public const string DeriveTitle = "derive-title";
            public const string AutoCompleteEstablishmentNames = "autocomplete-establishment-names";
        }


        static readonly ViewNames s_views = new ViewNames();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewNames Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewNames {
            public readonly string _browse_by_map = "~/Areas/InstitutionalAgreements/Views/ManagementForms/_browse-by-map.cshtml";
            public readonly string _browse = "~/Areas/InstitutionalAgreements/Views/ManagementForms/_browse.cshtml";
            public readonly string add_contact = "~/Areas/InstitutionalAgreements/Views/ManagementForms/add-contact.cshtml";
            public readonly string browse = "~/Areas/InstitutionalAgreements/Views/ManagementForms/browse.cshtml";
            public readonly string edit = "~/Areas/InstitutionalAgreements/Views/ManagementForms/edit.cshtml";
            public readonly string expires_on_help = "~/Areas/InstitutionalAgreements/Views/ManagementForms/expires-on-help.cshtml";
            public readonly string form_custom_css = "~/Areas/InstitutionalAgreements/Views/ManagementForms/form-custom-css.cshtml";
            public readonly string post = "~/Areas/InstitutionalAgreements/Views/ManagementForms/post.cshtml";
            static readonly _EditorTemplates s_EditorTemplates = new _EditorTemplates();
            public _EditorTemplates EditorTemplates { get { return s_EditorTemplates; } }
            public partial class _EditorTemplates{
                public readonly string InstitutionalAgreementContactForm = "InstitutionalAgreementContactForm";
                public readonly string InstitutionalAgreementFileForm = "InstitutionalAgreementFileForm";
                public readonly string InstitutionalAgreementForm = "InstitutionalAgreementForm";
                public readonly string InstitutionalAgreementParticipantForm = "InstitutionalAgreementParticipantForm";
            }
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class T4MVC_ManagementFormsController: UCosmic.Www.Mvc.Areas.InstitutionalAgreements.Controllers.ManagementFormsController {
        public T4MVC_ManagementFormsController() : base(Dummy.Instance) { }

        public override System.Web.Mvc.ActionResult Browse() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Browse);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Post(System.Guid? entityId) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Post);
            callInfo.RouteValueDictionary.Add("entityId", entityId);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Post(UCosmic.Www.Mvc.Areas.InstitutionalAgreements.Models.ManagementForms.InstitutionalAgreementForm model) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Post);
            callInfo.RouteValueDictionary.Add("model", model);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult AddParticipant(int agreementId, System.Guid establishmentId) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.AddParticipant);
            callInfo.RouteValueDictionary.Add("agreementId", agreementId);
            callInfo.RouteValueDictionary.Add("establishmentId", establishmentId);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult AttachFile(int? agreementId) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.AttachFile);
            callInfo.RouteValueDictionary.Add("agreementId", agreementId);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult AddContact(int? agreementId) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.AddContact);
            callInfo.RouteValueDictionary.Add("agreementId", agreementId);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult AddContact(UCosmic.Www.Mvc.Areas.InstitutionalAgreements.Models.ManagementForms.InstitutionalAgreementContactForm model) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.AddContact);
            callInfo.RouteValueDictionary.Add("model", model);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult DeriveTitle(UCosmic.Www.Mvc.Areas.InstitutionalAgreements.Models.ManagementForms.InstitutionalAgreementDeriveTitleInput model) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.DeriveTitle);
            callInfo.RouteValueDictionary.Add("model", model);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult AutoCompleteEstablishmentNames(string term, System.Collections.Generic.List<System.Guid> excludeEstablishmentIds) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.AutoCompleteEstablishmentNames);
            callInfo.RouteValueDictionary.Add("term", term);
            callInfo.RouteValueDictionary.Add("excludeEstablishmentIds", excludeEstablishmentIds);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591