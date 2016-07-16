using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using JobPortal.Repository.Interface;
namespace JobPortal.Test
{
    [TestClass]
    public class RepositoryTest
    {
        [TestMethod]
        public void DBContext_Initialize()
        {
            //var context = new Mock<IDbContext>();
            //context.Setup(p => p.SaveChanges()).Returns(It.IsAny<int>());
            //context.Verify(a => a.SaveChanges() == It.IsAny<int>());  
        }
    }
}
