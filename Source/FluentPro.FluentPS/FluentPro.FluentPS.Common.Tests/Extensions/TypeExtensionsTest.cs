using FluentPro.FluentPS.Common.Extensions;
using FluentPro.FluentPS.Common.Tests.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;

namespace FluentPro.FluentPS.Common.Tests.Extensions
{
    [TestClass]
    public class TypeExtensionsTest
    {
        [TestMethod]
        public void IsAssignableFromType_Object_Object_ReturnsTrue()
        {
            Assert.IsTrue(TypeExtensions.IsAssignableFromType(typeof(object), typeof(object)));
        }

        [TestMethod]
        public void IsAssignableFromType_Object_EntityWithPlainNames_ReturnsTrue()
        {
            Assert.IsTrue(TypeExtensions.IsAssignableFromType(typeof(object), typeof(EntityWithPlainNames)));
        }

        [TestMethod]
        public void IsAssignableFromType_Object_Guid_ReturnsTrue()
        {
            Assert.IsTrue(TypeExtensions.IsAssignableFromType(typeof(object), typeof(Guid)));
        }

        [TestMethod]
        public void IsAssignableFromType_Object_GenericList_ReturnsTrue()
        {
            Assert.IsTrue(TypeExtensions.IsAssignableFromType(typeof(object), typeof(List<>)));
        }

        [TestMethod]
        public void IsAssignableFromType_Object_DictionaryStringObject_ReturnsTrue()
        {
            Assert.IsTrue(TypeExtensions.IsAssignableFromType(typeof(object), typeof(Dictionary<string, object>)));
        }

        [TestMethod]
        public void IsAssignableFromType_Object_DataTableReader_ReturnsTrue()
        {
            Assert.IsTrue(TypeExtensions.IsAssignableFromType(typeof(object), typeof(DataTableReader)));
        }

        [TestMethod]
        public void IsAssignableFromType_GenericList_ListOfEntityWithPlainNames_ReturnsFalse()
        {
            Assert.IsTrue(TypeExtensions.IsAssignableFromType(typeof(List<>), typeof(List<EntityWithPlainNames>)));
        }

        [TestMethod]
        public void IsAssignableFromType_EntityWithPlainNames_Object_ReturnsFalse()
        {
            Assert.IsFalse(TypeExtensions.IsAssignableFromType(typeof(EntityWithPlainNames), typeof(object)));
        }

        [TestMethod]
        public void IsAssignableFromType_EntityWithPlainNames_GenericList_ReturnsFalse()
        {
            Assert.IsFalse(TypeExtensions.IsAssignableFromType(typeof(EntityWithPlainNames), typeof(List<>)));
        }

        [TestMethod]
        public void IsAssignableFromType_GenericList_EntityWithPlainNames_ReturnsFalse()
        {
            Assert.IsFalse(TypeExtensions.IsAssignableFromType(typeof(List<>), typeof(EntityWithPlainNames)));
        }
    }
}
