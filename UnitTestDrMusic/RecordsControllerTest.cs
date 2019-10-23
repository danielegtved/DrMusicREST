using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DrMusicREST.Controllers;
using DrMusicREST.Model;

namespace UnitTestDrMusic
{
    [TestClass]
    public class RecordsControllerTest
    {

        RecordsController recordsController = new RecordsController();

        [TestMethod]
        public void TestGet()
        {
            Record testRecord = recordsController.Get(1);
            Assert.IsNotNull(testRecord);
        }

        [TestMethod]
        public void TestGetAll()
        {
            IEnumerable<Record> testRecord = recordsController.Get();
            Assert.IsNotNull(testRecord);
        }

        [TestMethod]
        public void TestPut()
        {
            recordsController.Put(4, new Record("Test", "test", new TimeSpan(00,01,01), new DateTime(1111, 01, 01), 4));
            Assert.AreEqual("Test", recordsController.Get(4).Title);
        }

        [TestMethod]
        public void TestPost()
        {
            recordsController.Post(new Record("Test", "test", new TimeSpan(00, 01, 01), new DateTime(1111, 01, 01), 5));
            Assert.AreEqual("Test", recordsController.Get(5).Title);
        }

        [TestMethod]
        public void TestDelete()
        {
            recordsController.Delete(4);
            Assert.IsNull(recordsController.Get(4));
        }

        [TestMethod]
        public void TestSearchByTitle()
        {
            IEnumerable<Record> titleList = recordsController.GetByTitle("Hej");
            Record testRecord = new Record();
            foreach (var record in titleList)
            {
                testRecord = record;
            }
            Assert.AreEqual("Hej", testRecord.Title);
        }

        [TestMethod]
        public void TestSearchByArtist()
        {
            IEnumerable<Record> artistList = recordsController.GetByArtist("Knud");
            Record testRecord = new Record();
            foreach (var record in artistList)
            {
                testRecord = record;
            }
            Assert.AreEqual("Knud", testRecord.Artist);
        }
    }
}
