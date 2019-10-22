using NUnit.Framework;
using Weaselware.Mosiac.DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Weaselware.Mosiac.Model;

namespace MosiacTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            MosiacContext ctx = new MosiacContext();
            var parts = ctx.Part.ToList();
            Assert.IsTrue(parts.Count > 100);
        }
    }
}