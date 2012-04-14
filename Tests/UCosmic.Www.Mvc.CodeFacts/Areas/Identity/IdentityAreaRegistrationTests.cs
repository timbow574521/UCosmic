﻿using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcContrib.TestHelper;
using Should;
using UCosmic.Www.Mvc.Areas.Identity.Controllers;
using UCosmic.Www.Mvc.Areas.Identity.Models.Self;
using UCosmic.Www.Mvc.Areas.Identity.Models.SignIn;

namespace UCosmic.Www.Mvc.Areas.Identity
{
    [TestClass]
    public class IdentityAreaRegistrationTests
    {
        [TestMethod]
        public void AreaRegistration_Identity_HasCorrectAreaName()
        {
            var areaRegistration = new IdentityAreaRegistration();
            areaRegistration.AreaName.ShouldEqual("identity");

            MVC.Identity.Name.DefaultAreaRoutes().ShouldMapToNothing();
            MVC.Identity.Name.DefaultAreaRoutes(MVC.Identity.SignIn.Name).ShouldMapToNothing();
            MVC.Identity.Name.DefaultAreaRoutes(MVC.Identity.Roles.Name).ShouldMapToNothing();
            MVC.Identity.Name.DefaultAreaRoutes(MVC.Identity.EmailConfirmation.Name).ShouldMapToNothing();
            MVC.Identity.Name.DefaultAreaRoutes(MVC.Identity.Password.Name).ShouldMapToNothing();
            MVC.Identity.Name.DefaultAreaRoutes(MVC.Identity.Self.Name).ShouldMapToNothing();
            MVC.Identity.Name.DefaultAreaRoutes(MVC.Identity.SignUp.Name).ShouldMapToNothing();
        }

        #region Authentication

        [TestMethod]
        public void Route_Identity_Authentication_SignIn_IsSetUp()
        {
            Expression<Func<SignInController, ActionResult>> actionForGet = 
                controller => controller.SignIn(null as string);
            Expression<Func<SignInController, ActionResult>> actionForPost =
                controller => controller.SignIn(null as SignInForm);
            const string routeUrl = "sign-in";
            var url = routeUrl.ToAppRelativeUrl();

            url.WithMethods(HttpVerbs.Get).ShouldMapTo(actionForGet);
            url.WithMethods(HttpVerbs.Post).ShouldMapTo(actionForPost);
            url.WithMethodsExcept(HttpVerbs.Get, HttpVerbs.Post).ShouldMapToNothing();
            actionForGet.DefaultAreaRoutes(MVC.Identity.Name).ShouldMapToNothing();
            actionForPost.DefaultAreaRoutes(MVC.Identity.Name).ShouldMapToNothing();
        }

        [TestMethod]
        public void Route_Identity_Authentication_SignOut_IsSetUp()
        {
            Expression<Func<SignInController, ActionResult>> action = 
                controller => controller.SignOut(null);
            const string routeUrl = "sign-out";
            var url = routeUrl.ToAppRelativeUrl();

            url.WithMethod(HttpVerbs.Get).ShouldMapTo(action);
            url.WithMethodsExcept(HttpVerbs.Get).ShouldMapToNothing();
            action.DefaultAreaRoutes(MVC.Identity.Name).ShouldMapToNothing();
        }

        #endregion
        #region Email Confirmation

        [TestMethod]
        public void Route_Identity_EmailConfirmation_ConfirmForPasswordReset_GET_IsSetUp()
        {
            const string routeUrlA = "confirm-password-reset/t-{token}.html";
            const string tokenParam = "token";
            var urlFormatA = routeUrlA.Replace(tokenParam, "0").ToAppRelativeUrl();
            var token = Guid.NewGuid();
            Expression<Func<EmailConfirmationController, ActionResult>> action1 = 
                controller => controller.ConfirmForPasswordReset(token, null);

            var url1 = string.Format(urlFormatA, token);
            url1.WithMethod(HttpVerbs.Get).ShouldMapTo(action1);
            url1.WithMethodsExcept(HttpVerbs.Get).ShouldMapToNothing();
            action1.DefaultAreaRoutes(MVC.Identity.Name);

            var url2 = string.Format(urlFormatA, "not a Guid");
            url2.WithAnyMethod().ShouldMapToNothing();

            var url3 = string.Format(urlFormatA, Guid.Empty);
            url3.WithAnyMethod().ShouldMapToNothing();

            const string routeUrlB = "confirm-password-reset/t-{token}/{secretCode}";
            const string secretCodeParam = "secretCode";
            const string secretCodeValue = "its a secret";
            var urlFormatB = routeUrlB.Replace(tokenParam, "0").Replace(secretCodeParam, "1").ToAppRelativeUrl();
            Expression<Func<EmailConfirmationController, ActionResult>> action2 =
                controller => controller.ConfirmForPasswordReset(token, secretCodeValue);

            var url4 = string.Format(urlFormatB, token, secretCodeValue);
            url4.WithMethod(HttpVerbs.Get).ShouldMapTo(action2);
            url4.WithMethodsExcept(HttpVerbs.Get).ShouldMapToNothing();
            action2.DefaultAreaRoutes(MVC.Identity.Name).ShouldMapToNothing();

            var url5 = string.Format(urlFormatB, "not a Guid", secretCodeValue);
            url5.WithAnyMethod().ShouldMapToNothing();

            var url6 = string.Format(urlFormatB, Guid.Empty, secretCodeValue);
            url6.WithAnyMethod().ShouldMapToNothing();
        }

        [TestMethod]
        public void Route_Identity_EmailConfirmation_ConfirmForPasswordReset_POST_IsSetUp()
        {
            Expression<Func<EmailConfirmationController, ActionResult>> action = 
                controller => controller.ConfirmForPasswordReset(null);
            const string url = "confirm-password-reset.html";

            url.ToAppRelativeUrl().WithMethod(HttpVerbs.Post).ShouldMapTo(action);
            url.ToAppRelativeUrl().WithMethodsExcept(HttpVerbs.Post).ShouldMapToNothing();
            action.DefaultAreaRoutes(MVC.Identity.Name).ShouldMapToNothing();
        }

        #endregion
        #region Password

        [TestMethod]
        public void Route_Identity_Password_ChangePassword_IsSetUp()
        {
            Expression<Func<PasswordController, ActionResult>> actionForGet = 
                controller => controller.ChangePassword();
            Expression<Func<PasswordController, ActionResult>> actionForPost =
                controller => controller.ChangePassword(null);
            const string url = "me/change-password.html";

            url.ToAppRelativeUrl().WithMethods(HttpVerbs.Get).ShouldMapTo(actionForGet);
            url.ToAppRelativeUrl().WithMethods(HttpVerbs.Post).ShouldMapTo(actionForPost);
            url.ToAppRelativeUrl().WithMethodsExcept(HttpVerbs.Get, HttpVerbs.Post).ShouldMapToNothing();
            actionForGet.DefaultAreaRoutes(MVC.Identity.Name).ShouldMapToNothing();
            actionForPost.DefaultAreaRoutes(MVC.Identity.Name).ShouldMapToNothing();
        }

        [TestMethod]
        public void Route_Identity_Password_ForgotPassword_IsSetUp()
        {
            Expression<Func<PasswordController, ActionResult>> actionForGet = 
                controller => controller.ForgotPassword();
            Expression<Func<PasswordController, ActionResult>> actionForPost =
                controller => controller.ForgotPassword(null);
            const string url = "i-forgot-my-password";

            url.ToAppRelativeUrl().WithMethod(HttpVerbs.Get).ShouldMapTo(actionForGet);
            url.ToAppRelativeUrl().WithMethod(HttpVerbs.Post).ShouldMapTo(actionForPost);
            url.ToAppRelativeUrl().WithMethodsExcept(HttpVerbs.Get, HttpVerbs.Post).ShouldMapToNothing();
            actionForGet.DefaultAreaRoutes(MVC.Identity.Name).ShouldMapToNothing();
            actionForPost.DefaultAreaRoutes(MVC.Identity.Name).ShouldMapToNothing();
        }

        [TestMethod]
        public void Route_Identity_Password_ResetPassword_IsSetUp()
        {
            Expression<Func<PasswordController, ActionResult>> actionForGet = 
                controller => controller.ResetPassword();
            Expression<Func<PasswordController, ActionResult>> actionForPost =
                controller => controller.ResetPassword(null);
            const string url = "reset-password";

            url.ToAppRelativeUrl().WithMethod(HttpVerbs.Get).ShouldMapTo(actionForGet);
            url.ToAppRelativeUrl().WithMethod(HttpVerbs.Post).ShouldMapTo(actionForPost);
            url.ToAppRelativeUrl().WithMethodsExcept(HttpVerbs.Get, HttpVerbs.Post).ShouldMapToNothing();
            actionForGet.DefaultAreaRoutes(MVC.Identity.Name).ShouldMapToNothing();
            actionForPost.DefaultAreaRoutes(MVC.Identity.Name).ShouldMapToNothing();
        }

        #endregion
        #region Self

        [TestMethod]
        public void Route_Identity_Self_Me_IsSetUp()
        {
            Expression<Func<SelfController, ActionResult>> actionForGet =
                controller => controller.Me();
            Expression<Func<SelfController, ActionResult>> actionForPost =
                controller => controller.Me(null);
            const string url = "my/profile";

            url.ToAppRelativeUrl().WithMethod(HttpVerbs.Get).ShouldMapTo(actionForGet);
            url.ToAppRelativeUrl().WithMethod(HttpVerbs.Post).ShouldMapTo(actionForPost);
            url.ToAppRelativeUrl().WithMethodsExcept(HttpVerbs.Get, HttpVerbs.Post).ShouldMapToNothing();
            actionForGet.DefaultAreaRoutes(MVC.Identity.Name).ShouldMapToNothing();
            actionForPost.DefaultAreaRoutes(MVC.Identity.Name).ShouldMapToNothing();
        }

        [TestMethod]
        public void Route_Identity_Self_EditAffiliation_GET_IsSetUp()
        {
            var entityId = Guid.NewGuid();
            Expression<Func<SelfController, ActionResult>> action =
                controller => controller.EditAffiliation(entityId);
            const string entityIdParam = "{entityId}";
            const string urlFormat = "me/affiliations/{entityId}/edit.html";

            var url1 = urlFormat.Replace(entityIdParam, entityId.ToString()).ToAppRelativeUrl();
            url1.WithMethod(HttpVerbs.Get).ShouldMapTo(action);
            url1.WithMethodsExcept(HttpVerbs.Get).ShouldMapToNothing();
            action.DefaultAreaRoutes(MVC.Identity.Name).ShouldMapToNothing();

            var url2 = urlFormat.Replace(entityIdParam, Guid.Empty.ToString()).ToAppRelativeUrl();
            url2.WithAnyMethod().ShouldMapToNothing();

            var url3 = urlFormat.Replace(entityIdParam, "not a Guid").ToAppRelativeUrl();
            url3.WithAnyMethod().ShouldMapToNothing();
        }

        [TestMethod]
        public void Route_Identity_Self_EditAffiliation_POST_IsSetUp()
        {
            Expression<Func<SelfController, ActionResult>> action =
                controller => controller.EditAffiliation(null as AffiliationForm);
            const string url = "me/affiliations/edit.html";

            url.ToAppRelativeUrl().WithMethod(HttpVerbs.Post).ShouldMapTo(action);
            url.ToAppRelativeUrl().WithMethodsExcept(HttpVerbs.Post).ShouldMapToNothing();
            action.DefaultAreaRoutes(MVC.Identity.Name).ShouldMapToNothing();
        }

        [TestMethod]
        public void Route_Identity_Self_ChangeEmailSpelling_GET_IsSetUp()
        {
            var entityId = Guid.NewGuid();
            Expression<Func<SelfController, ActionResult>> action =
                controller => controller.ChangeEmailSpelling(entityId);
            const string routeUrl = "me/emails/{entityId}/change-spelling.html";
            const string entityIdParam = "entityId";
            var urlFormat = routeUrl.Replace(entityIdParam, "0");

            var url1 = string.Format(urlFormat, entityId).ToAppRelativeUrl();
            url1.WithMethod(HttpVerbs.Get).ShouldMapTo(action);
            url1.WithMethodsExcept(HttpVerbs.Get).ShouldMapToNothing();
            action.DefaultAreaRoutes(MVC.Identity.Name).ShouldMapToNothing();

            var url2 = string.Format(urlFormat, Guid.Empty).ToAppRelativeUrl();
            url2.WithAnyMethod().ShouldMapToNothing();

            var url3 = string.Format(urlFormat, "not a Guid").ToAppRelativeUrl();
            url3.WithAnyMethod().ShouldMapToNothing();
        }

        [TestMethod]
        public void Route_Identity_Self_ChangeEmailSpelling_POST_IsSetUp()
        {
            Expression<Func<SelfController, ActionResult>> action =
                controller => controller.ChangeEmailSpelling(null as ChangeEmailSpellingForm);
            const string url = "me/emails/change-spelling.html";

            url.ToAppRelativeUrl().WithMethod(HttpVerbs.Post).ShouldMapTo(action);
            url.ToAppRelativeUrl().WithMethodsExcept(HttpVerbs.Post).ShouldMapToNothing();
            action.DefaultAreaRoutes(MVC.Identity.Name).ShouldMapToNothing();
        }

        [TestMethod]
        public void Route_Identity_Self_CheckEmailSpelling_JSON_IsSetUp()
        {
            Expression<Func<SelfController, ActionResult>> action =
                controller => controller.CheckEmailSpelling(null);
            var url = "my/emails/change-spelling/validate".ToAppRelativeUrl();

            OutBoundRoute.Of(action).InArea(MVC.Identity.Name).WithMethod(HttpVerbs.Get).Url().ShouldBeNull();
            OutBoundRoute.Of(action).InArea(MVC.Identity.Name).WithMethod(HttpVerbs.Post).AppRelativeUrl().ShouldEqual(url);
            url.WithMethod(HttpVerbs.Post).ShouldMapTo(action);
            url.WithMethodsExcept(HttpVerbs.Post).ShouldMapToNothing();
            action.DefaultAreaRoutes(MVC.Identity.Name).ShouldMapToNothing();
        }

        #endregion

    }
}