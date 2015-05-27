using System;
using System.Collections.Generic;
using System.Data;
using FluentPro.Common.Mapper.Extensions;
using FluentPro.Common.Mapper.Tests.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentPro.Common.Mapper.Tests.Extensions
{
    [TestClass]
    public class TypeExtensionsTest
    {
        [TestMethod]
        public void IsAssignableFromType_Object_Object_ReturnsTrue()
        {
            Assert.IsTrue(typeof(object).IsAssignableFromType(typeof(object)));
        }

        [TestMethod]
        public void IsAssignableFromType_Object_EntityWithPlainNames_ReturnsTrue()
        {
            Assert.IsTrue(typeof(object).IsAssignableFromType(typeof(EntityWithPlainNames)));
        }

        [TestMethod]
        public void IsAssignableFromType_Object_Guid_ReturnsTrue()
        {
            Assert.IsTrue(typeof(object).IsAssignableFromType(typeof(Guid)));
        }

        [TestMethod]
        public void IsAssignableFromType_Object_GenericList_ReturnsTrue()
        {
            Assert.IsTrue(typeof(object).IsAssignableFromType(typeof(List<>)));
        }

        [TestMethod]
        public void IsAssignableFromType_Object_DictionaryStringObject_ReturnsTrue()
        {
            Assert.IsTrue(typeof(object).IsAssignableFromType(typeof(Dictionary<string, object>)));
        }

        [TestMethod]
        public void IsAssignableFromType_Object_DataTableReader_ReturnsTrue()
        {
            Assert.IsTrue(typeof(object).IsAssignableFromType(typeof(DataTableReader)));
        }

        [TestMethod]
        public void IsAssignableFromType_GenericList_ListOfEntityWithPlainNames_ReturnsFalse()
        {
            Assert.IsTrue(typeof(List<>).IsAssignableFromType(typeof(List<EntityWithPlainNames>)));
        }

        [TestMethod]
        public void IsAssignableFromType_EntityWithPlainNames_Object_ReturnsFalse()
        {
            Assert.IsFalse(typeof(EntityWithPlainNames).IsAssignableFromType(typeof(object)));
        }

        [TestMethod]
        public void IsAssignableFromType_EntityWithPlainNames_GenericList_ReturnsFalse()
        {
            Assert.IsFalse(typeof(EntityWithPlainNames).IsAssignableFromType(typeof(List<>)));
        }

        [TestMethod]
        public void IsAssignableFromType_GenericList_EntityWithPlainNames_ReturnsFalse()
        {
            Assert.IsFalse(typeof(List<>).IsAssignableFromType(typeof(EntityWithPlainNames)));
        }
    }
}
