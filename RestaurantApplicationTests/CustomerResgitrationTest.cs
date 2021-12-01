using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RestaurantApplicationClassLibrary;
using RestaurantApplicationClassLibrary.Helpers.Validation;

namespace RestaurantApplicationTests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void TestCustomerRegistrationInMemory()
        {
            Customer customer = new Customer("Juan Perez", "10141416");
            var mock = new Mock<InMemoryDataAccess<Customer>>();
            CustomerRepository repository = new CustomerRepository(mock.Object);
            Assert.AreEqual(customer, repository.Save(customer));            
        }
        [TestMethod]
        public void TestCustomerValidation()
        {
            Customer customer = new Customer("Juan Perez", "10141416");
            IClassValidator<Customer> validator = new ClassValidator<Customer>(customer);
            validator.IsNotEmptyOrNull((x => x.Name), "Please fill The name");
            validator.IsNotEmptyOrNull((x => x.Document), "Please fill The name");
            var mock = new Mock<ClassValidator<Customer>>(customer);            
            CustomerValidation validation = new CustomerValidation(mock.Object);
            Assert.AreEqual(0,validation.Validate()._errors.Count);
        }
    }
}
