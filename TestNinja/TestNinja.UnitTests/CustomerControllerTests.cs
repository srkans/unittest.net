using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {

        private CustomerController _controller;

        [SetUp]
        public void SetUp() 
        {
            _controller = new CustomerController();
        }

        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound() 
        {
           
            var result = _controller.GetCustomer(0);

            Assert.That(result, Is.TypeOf<NotFound>()); //typeof waits exactly same object

           // Assert.That(result, Is.InstanceOf<NotFound>()); //Instance of waits notfound or one of its derivatives

        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOk() 
        {
            var result = _controller.GetCustomer(1);

            Assert.That(result, Is.TypeOf<Ok>());
        }
    }
}
