using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Program2._4;

namespace TestProject2._4
{
    public class Tests
    {


            private IdentifiableObject _obj;
            private string _string;
            private string[] _array;

            private IdentifiableObject _tempobj;
            private string _testString_emp;
            private string[] _testArray_emp;

            [SetUp]
            public void Setup()
            {
                _string = "Anh";
                _array = new string[] { "Patch", "Lily" };
                _obj = new IdentifiableObject(_array);
                _obj.AddIdentifier(_string);

                _testString_emp = "";
                _testArray_emp = new string[] { };
                _tempobj = new IdentifiableObject(_testArray_emp);
                _tempobj.AddIdentifier(_testString_emp);
            }

            [Test]
            public void TestAreYou()
            {
                Assert.IsTrue(_obj.AreYou(_string));
            }

            [Test]
            public void TestNotAreYou()
            {
                Assert.IsFalse(_obj.AreYou("Chi"));
            }

            [Test]
            public void Insensitive()
            {
                Assert.IsTrue(_obj.AreYou("LILY"));
            }

            [Test]
            public void TestFirstId()
            {
                Assert.AreEqual("patch", _obj.FirstID);
                Assert.AreNotEqual("lily", _obj.FirstID);
            }

            [Test]
            public void TestFirstIdWithNoId()
            {
                Assert.AreEqual("", _tempobj.FirstID);
            }

            [Test]
            public void TestAddID()
            {
                _tempobj.AddIdentifier("Dang");
                _obj.AddIdentifier("Chi");
                Assert.IsTrue(_tempobj.AreYou("Dang"));
                Assert.IsTrue(_obj.AreYou("Chi"));

            }
        }
    
}