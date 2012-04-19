﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace UCosmic.Domain.People
{
    // ReSharper disable UnusedMember.Global
    public class GenerateDisplayNameHandlerFacts
    // ReSharper restore UnusedMember.Global
    {
        [TestClass]
        public class TheHandleMethod
        {
            [TestMethod]
            public void ReturnsNull_WhenNoComponentsAreProvided()
            {
                var query = new GenerateDisplayNameQuery();
                var handler = new GenerateDisplayNameHandler();

                var result = handler.Handle(query);

                result.ShouldBeNull();
            }

            [TestMethod]
            public void GeneratesNameFrom_First_Last()
            {
                var query = new GenerateDisplayNameQuery
                {
                    FirstName = "Adam",
                    LastName = "West",
                };
                var handler = new GenerateDisplayNameHandler();

                var result = handler.Handle(query);

                result.ShouldEqual("Adam West");
            }

            [TestMethod]
            public void GeneratesNameFrom_First_Middle_Last()
            {
                var query = new GenerateDisplayNameQuery
                {
                    FirstName = "Adam",
                    MiddleName = "B",
                    LastName = "West",
                };
                var handler = new GenerateDisplayNameHandler();

                var result = handler.Handle(query);

                result.ShouldEqual("Adam B West");
            }

            [TestMethod]
            public void GeneratesNameFrom_Salutation_First_Middle_Last_Suffix()
            {
                var query = new GenerateDisplayNameQuery
                {
                    Salutation = "Mr.",
                    FirstName = "Adam",
                    MiddleName = "B",
                    LastName = "West",
                    Suffix = "Sr",
                };
                var handler = new GenerateDisplayNameHandler();

                var result = handler.Handle(query);

                result.ShouldEqual("Mr. Adam B West Sr");
            }
        }
    }
}
