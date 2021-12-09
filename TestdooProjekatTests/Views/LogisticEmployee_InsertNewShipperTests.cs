using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestdooProjekat.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestdooProjekat.Views.Tests
{
    [TestClass()]
    public class LogisticEmployee_InsertNewShipperTests
    {
        [TestMethod()]
        public void TestExceptionCase()
        {
            Shipper shipper = new Shipper();

            try
            {
                shipper.shipperid =2;
                if (shipper.shipperid < 0)
                {
                    throw new System.ArgumentOutOfRangeException("id");
                }
            }
            catch (ArgumentNullException)
            {
 
                return;
            }
        }
    }
}