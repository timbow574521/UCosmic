﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace UCosmic.Domain.Establishments
{
    public static class EstablishmentEmailDomainFacts
    {
        [TestClass]
        public class EstablishmentIdProperty
        {
            [TestMethod]
            public void HasGetSet()
            {
                const int value = 12;
                var entity = new EstablishmentEmailDomain { EstablishmentId = value };
                entity.ShouldNotBeNull();
                entity.EstablishmentId.ShouldEqual(value);
            }
        }

        [TestClass]
        public class EstablishmentProperty
        {
            [TestMethod]
            public void HasGetSet()
            {
                var value = new Establishment();
                var entity = new EstablishmentEmailDomain { Establishment = value };
                entity.ShouldNotBeNull();
                entity.Establishment.ShouldEqual(value);
            }

            [TestMethod]
            public void IsVirtual()
            {
                var entity = new EstablishmentEmailDomainRuntimeEntity();
                entity.ShouldNotBeNull();
            }
            private class EstablishmentEmailDomainRuntimeEntity : EstablishmentEmailDomain
            {
                public override Establishment Establishment
                {
                    get { return null; }
                    protected internal set { }
                }
            }
        }
    }
}
