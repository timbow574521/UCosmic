﻿using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Should;
using UCosmic.Domain.Identity;
using UCosmic.Domain.People;
using UCosmic.Www.Mvc.Areas.Identity.Models;
using UCosmic.Www.Mvc.Controllers;

namespace UCosmic.Www.Mvc.Areas.Identity.Controllers
{
    public static class UpdateNameControllerFacts
    {
        [TestClass]
        public class TheClass
        {
            [TestMethod]
            public void IsDecoratedWith_Authorize()
            {
                var attribute = Attribute.GetCustomAttribute(typeof(UpdateNameController), typeof(AuthorizeAttribute));

                attribute.ShouldNotBeNull();
                attribute.ShouldBeType<AuthorizeAttribute>();
            }
        }

        [TestClass]
        public class TheGetMethod
        {
            [TestMethod]
            public void IsDecoratedWith_HttpGet()
            {
                Expression<Func<UpdateNameController, ActionResult>> method = m => m.Get();

                var attributes = method.GetAttributes<UpdateNameController, ActionResult, HttpGetAttribute>();
                attributes.ShouldNotBeNull();
                attributes.Length.ShouldEqual(1);
                attributes[0].ShouldNotBeNull();
            }

            [TestMethod]
            public void IsDecoratedWith_NullLayoutOnChildAction()
            {
                Expression<Func<UpdateNameController, ActionResult>> method = m => m.Get();

                var attributes = method.GetAttributes<UpdateNameController, ActionResult, NullLayoutOnChildActionAttribute>();
                attributes.ShouldNotBeNull();
                attributes.Length.ShouldEqual(1);
                attributes[0].ShouldNotBeNull();
            }

            [TestMethod]
            public void IsDecoratedWith_OpenTopTab_UsingHome()
            {
                Expression<Func<UpdateNameController, ActionResult>> method = m => m.Get();

                var attributes = method.GetAttributes<UpdateNameController, ActionResult, OpenTopTabAttribute>();
                attributes.ShouldNotBeNull();
                attributes.Length.ShouldEqual(1);
                attributes[0].ShouldNotBeNull();
                attributes[0].TabName.ShouldEqual(TopTabName.Home);
            }

            [TestMethod]
            public void IsDecoratedWith_ActionName_UsingUpdateName()
            {
                Expression<Func<UpdateNameController, ActionResult>> method = m => m.Get();

                var attributes = method.GetAttributes<UpdateNameController, ActionResult, ActionNameAttribute>();
                attributes.ShouldNotBeNull();
                attributes.Length.ShouldEqual(1);
                attributes[0].ShouldNotBeNull();
                attributes[0].Name.ShouldEqual("update-name");
            }

            [TestMethod]
            public void ThrowsNullReferenceException_WhenUserIsNull()
            {
                var scenarioOptions = new ScenarioOptions();
                var controller = CreateController(scenarioOptions);
                scenarioOptions.MockQueryProcessor.Setup(m => m.Execute(It.IsAny<GetMyEmailAddressByNumberQuery>()))
                    .Returns(null as EmailAddress);
                NullReferenceException exception = null;

                try
                {
                    controller.Get();
                }
                catch (NullReferenceException ex)
                {
                    exception = ex;
                }

                exception.ShouldNotBeNull();
            }

            [TestMethod]
            public void ExecutesQuery_ForUser_ByName()
            {
                const string userName = "user@domain.tld";
                var scenarioOptions = new ScenarioOptions
                {
                    PrincipalIdentityName = userName,
                };
                Expression<Func<GetUserByNameQuery, bool>> userByNameQuery =
                    query => query.Name == userName;
                var controller = CreateController(scenarioOptions);
                scenarioOptions.MockQueryProcessor.Setup(m => m.Execute(It.Is(userByNameQuery)))
                    .Returns(null as User);

                controller.Get();

                scenarioOptions.MockQueryProcessor.Verify(m => m.Execute(
                    It.Is(userByNameQuery)),
                        Times.Once());
            }

            [TestMethod]
            public void Returns404_WheUser_CannotBeFound()
            {
                const string userName = "user@domain.tld";
                var scenarioOptions = new ScenarioOptions
                {
                    PrincipalIdentityName = userName,
                };
                Expression<Func<GetUserByNameQuery, bool>> userByNameQuery =
                    query => query.Name == userName;
                var controller = CreateController(scenarioOptions);
                scenarioOptions.MockQueryProcessor.Setup(m => m.Execute(It.Is(userByNameQuery)))
                    .Returns(null as User);

                var result = controller.Get();

                result.ShouldNotBeNull();
                result.ShouldBeType<HttpNotFoundResult>();
            }

            [TestMethod]
            public void ReturnsPartialView_WhenUserIsFound_AndIsChildAction()
            {
                const string userName = "user@domain.tld";
                var scenarioOptions = new ScenarioOptions
                {
                    PrincipalIdentityName = userName,
                    IsChildAction = true,
                };
                Expression<Func<GetUserByNameQuery, bool>> userByNameQuery =
                    query => query.Name == userName;
                var controller = CreateController(scenarioOptions);
                scenarioOptions.MockQueryProcessor.Setup(m => m.Execute(It.Is(userByNameQuery)))
                    .Returns(new User { Person = new Person() });

                var result = controller.Get();

                result.ShouldNotBeNull();
                result.ShouldBeType<PartialViewResult>();
                var partialViewResult = (PartialViewResult)result;
                partialViewResult.Model.ShouldNotBeNull();
                partialViewResult.Model.ShouldBeType<UpdateNameForm>();
            }

            [TestMethod]
            public void ReturnsView_WhenUserIsFound_AndIsNotChildAction()
            {
                const string userName = "user@domain.tld";
                var scenarioOptions = new ScenarioOptions
                {
                    PrincipalIdentityName = userName,
                };
                Expression<Func<GetUserByNameQuery, bool>> userByNameQuery =
                    query => query.Name == userName;
                var controller = CreateController(scenarioOptions);
                scenarioOptions.MockQueryProcessor.Setup(m => m.Execute(It.Is(userByNameQuery)))
                    .Returns(new User { Person = new Person() });

                var result = controller.Get();

                result.ShouldNotBeNull();
                result.ShouldBeType<ViewResult>();
                var viewResult = (ViewResult)result;
                viewResult.Model.ShouldNotBeNull();
                viewResult.Model.ShouldBeType<UpdateNameForm>();
            }
        }

        [TestClass]
        public class ThePutMethod
        {
            [TestMethod]
            public void IsDecoratedWith_HttpPut()
            {
                Expression<Func<UpdateNameController, ActionResult>> method = m => m.Put(null);

                var attributes = method.GetAttributes<UpdateNameController, ActionResult, HttpPutAttribute>();
                attributes.ShouldNotBeNull();
                attributes.Length.ShouldEqual(1);
                attributes[0].ShouldNotBeNull();
            }

            [TestMethod]
            public void IsDecoratedWith_UnitOfWork()
            {
                Expression<Func<UpdateNameController, ActionResult>> method = m => m.Put(null);

                var attributes = method.GetAttributes<UpdateNameController, ActionResult, UnitOfWorkAttribute>();
                attributes.ShouldNotBeNull();
                attributes.Length.ShouldEqual(1);
                attributes[0].ShouldNotBeNull();
            }

            [TestMethod]
            public void IsDecoratedWith_OpenTopTab_UsingHome()
            {
                Expression<Func<UpdateNameController, ActionResult>> method = m => m.Put(null);

                var attributes = method.GetAttributes<UpdateNameController, ActionResult, OpenTopTabAttribute>();
                attributes.ShouldNotBeNull();
                attributes.Length.ShouldEqual(1);
                attributes[0].ShouldNotBeNull();
                attributes[0].TabName.ShouldEqual(TopTabName.Home);
            }

            [TestMethod]
            public void IsDecoratedWith_ActionName_UsingUpdateName()
            {
                Expression<Func<UpdateNameController, ActionResult>> method = m => m.Put(null);

                var attributes = method.GetAttributes<UpdateNameController, ActionResult, ActionNameAttribute>();
                attributes.ShouldNotBeNull();
                attributes.Length.ShouldEqual(1);
                attributes[0].ShouldNotBeNull();
                attributes[0].Name.ShouldEqual("update-name");
            }

            [TestMethod]
            public void Returns404_WhenModel_IsNull()
            {
                var controller = CreateController();

                var result = controller.Put(null);

                result.ShouldNotBeNull();
                result.ShouldBeType<HttpNotFoundResult>();
            }

            [TestMethod]
            public void ReturnsView_WhenModelState_IsInvalid()
            {
                var scenarioOptions = new ScenarioOptions();
                var model = new UpdateNameForm();
                var controller = CreateController(scenarioOptions);
                controller.ModelState.AddModelError("error", "message");

                var result = controller.Put(model);

                result.ShouldNotBeNull();
                result.ShouldBeType<ViewResult>();
                var viewResult = (ViewResult)result;
                viewResult.Model.ShouldNotBeNull();
                viewResult.Model.ShouldBeType<UpdateNameForm>();
                viewResult.Model.ShouldEqual(model);
            }

            [TestMethod]
            public void SetsCommandPrincipalProperty()
            {
                const string principalIdentityName = "user@domain.tld";
                var scenarioOptions = new ScenarioOptions
                {
                    PrincipalIdentityName = principalIdentityName,
                };
                var model = new UpdateNameForm
                {
                    DisplayName = "test",
                    IsDisplayNameDerived = false,
                    FirstName = "first",
                    LastName = "last",
                };
                var controller = CreateController(scenarioOptions);
                Expression<Func<UpdateMyNameCommand, bool>> commandDerivedFromModel =
                    command =>
                    command.DisplayName == model.DisplayName &&
                    command.IsDisplayNameDerived == model.IsDisplayNameDerived &&
                    command.Salutation == model.Salutation &&
                    command.FirstName == model.FirstName &&
                    command.MiddleName == model.MiddleName &&
                    command.LastName == model.LastName &&
                    command.Suffix == model.Suffix
                ;
                UpdateMyNameCommand executedCommand = null;
                scenarioOptions.MockCommandHandler.Setup(m => m.Handle(It.Is(commandDerivedFromModel)))
                    .Callback((UpdateMyNameCommand command) => executedCommand = command);

                controller.Put(model);

                executedCommand.Principal.Identity.Name.ShouldEqual(scenarioOptions.PrincipalIdentityName);
                executedCommand.Principal.Identity.Name.ShouldEqual(principalIdentityName);
            }

            [TestMethod]
            public void ExecutesCommand_WhenAction_IsValid()
            {
                var scenarioOptions = new ScenarioOptions();
                var model = new UpdateNameForm
                {
                    DisplayName = "test",
                    IsDisplayNameDerived = false,
                    FirstName = "first",
                    LastName = "last",
                };
                var controller = CreateController(scenarioOptions);
                Expression<Func<UpdateMyNameCommand, bool>> commandDerivedFromModel =
                    command =>
                    command.DisplayName == model.DisplayName &&
                    command.IsDisplayNameDerived == model.IsDisplayNameDerived &&
                    command.Salutation == model.Salutation &&
                    command.FirstName == model.FirstName &&
                    command.MiddleName == model.MiddleName &&
                    command.LastName == model.LastName &&
                    command.Suffix == model.Suffix
                ;
                scenarioOptions.MockCommandHandler.Setup(m => m.Handle(It.Is(commandDerivedFromModel)));

                controller.Put(model);

                scenarioOptions.MockCommandHandler.Verify(m =>
                    m.Handle(It.Is(commandDerivedFromModel)),
                        Times.Once());
            }

            [TestMethod]
            public void FlashesSuccessMessage_WhenCommand_ChangedState()
            {
                var scenarioOptions = new ScenarioOptions();
                var model = new UpdateNameForm
                {
                    DisplayName = "test",
                    IsDisplayNameDerived = false,
                    FirstName = "first",
                    LastName = "last",
                };
                var controller = CreateController(scenarioOptions);
                Expression<Func<UpdateMyNameCommand, bool>> commandDerivedFromModel =
                    command =>
                    command.DisplayName == model.DisplayName &&
                    command.IsDisplayNameDerived == model.IsDisplayNameDerived &&
                    command.Salutation == model.Salutation &&
                    command.FirstName == model.FirstName &&
                    command.MiddleName == model.MiddleName &&
                    command.LastName == model.LastName &&
                    command.Suffix == model.Suffix
                ;
                scenarioOptions.MockCommandHandler.Setup(m => m.Handle(It.Is(commandDerivedFromModel)))
                    .Callback((UpdateMyNameCommand command) => command.ChangeCount = 1);

                controller.Put(model);

                controller.TempData.ShouldNotBeNull();
                var message = controller.TempData.FeedbackMessage();
                message.ShouldNotBeNull();
                message.ShouldEqual(UpdateNameController.SuccessMessage);
            }

            [TestMethod]
            public void FlashesNoChangesMessage_WhenCommand_ChangedState()
            {
                var scenarioOptions = new ScenarioOptions();
                var model = new UpdateNameForm
                {
                    DisplayName = "test",
                    IsDisplayNameDerived = false,
                    FirstName = "first",
                    LastName = "last",
                };
                var controller = CreateController(scenarioOptions);
                Expression<Func<UpdateMyNameCommand, bool>> commandDerivedFromModel =
                    command =>
                    command.DisplayName == model.DisplayName &&
                    command.IsDisplayNameDerived == model.IsDisplayNameDerived &&
                    command.Salutation == model.Salutation &&
                    command.FirstName == model.FirstName &&
                    command.MiddleName == model.MiddleName &&
                    command.LastName == model.LastName &&
                    command.Suffix == model.Suffix
                ;
                scenarioOptions.MockCommandHandler.Setup(m => m.Handle(It.Is(commandDerivedFromModel)));

                controller.Put(model);

                controller.TempData.ShouldNotBeNull();
                var message = controller.TempData.FeedbackMessage();
                message.ShouldNotBeNull();
                message.ShouldEqual(UpdateNameController.NoChangesMessage);
            }

            [TestMethod]
            public void ReturnsRedirect_ToStaticReturnUrl_AfterCommandIsExecuted()
            {
                var scenarioOptions = new ScenarioOptions();
                var model = new UpdateNameForm
                {
                    DisplayName = "test",
                    IsDisplayNameDerived = false,
                    FirstName = "first",
                    LastName = "last",
                };
                var controller = CreateController(scenarioOptions);
                Expression<Func<UpdateMyNameCommand, bool>> commandDerivedFromModel =
                    command =>
                    command.DisplayName == model.DisplayName &&
                    command.IsDisplayNameDerived == model.IsDisplayNameDerived &&
                    command.Salutation == model.Salutation &&
                    command.FirstName == model.FirstName &&
                    command.MiddleName == model.MiddleName &&
                    command.LastName == model.LastName &&
                    command.Suffix == model.Suffix
                ;
                scenarioOptions.MockCommandHandler.Setup(m => m.Handle(It.Is(commandDerivedFromModel)));

                var result = controller.Put(model);

                result.ShouldNotBeNull();
                result.ShouldBeType<RedirectResult>();
                var redirectResult = (RedirectResult)result;
                redirectResult.Url.ShouldEqual(UpdateNameForm.ReturnUrl);
                redirectResult.Permanent.ShouldBeFalse();
            }
        }

        private class ScenarioOptions
        {
            internal Mock<IProcessQueries> MockQueryProcessor { get; set; }
            internal Mock<IHandleCommands<UpdateMyNameCommand>> MockCommandHandler { get; set; }
            internal string PrincipalIdentityName { get; set; }
            internal bool IsChildAction { get; set; }
        }

        private static UpdateNameController CreateController(ScenarioOptions scenarioOptions = null)
        {
            scenarioOptions = scenarioOptions ?? new ScenarioOptions();

            scenarioOptions.MockQueryProcessor = new Mock<IProcessQueries>(MockBehavior.Strict);

            scenarioOptions.MockCommandHandler = new Mock<IHandleCommands<UpdateMyNameCommand>>(MockBehavior.Strict);

            var services = new UpdateNameServices(scenarioOptions.MockQueryProcessor.Object, scenarioOptions.MockCommandHandler.Object);

            var controller = new UpdateNameController(services);

            var builder = ReuseMock.TestControllerBuilder();

            if (!string.IsNullOrWhiteSpace(scenarioOptions.PrincipalIdentityName))
                builder.HttpContext.User = scenarioOptions.PrincipalIdentityName.AsPrincipal();

            builder.InitializeController(controller);

            if (scenarioOptions.IsChildAction)
            {
                var controllerContext = new Mock<ControllerContext>(MockBehavior.Strict);
                var parentContext = new ViewContext { TempData = new TempDataDictionary() };
                builder.RouteData.DataTokens.Add("ParentActionViewContext", parentContext);
                controllerContext.Setup(p => p.IsChildAction).Returns(true);
                controllerContext.Setup(p => p.HttpContext).Returns(builder.HttpContext);
                controllerContext.Setup(p => p.RouteData).Returns(builder.RouteData);
                controller.ControllerContext = controllerContext.Object;
            }

            return controller;
        }
    }
}
