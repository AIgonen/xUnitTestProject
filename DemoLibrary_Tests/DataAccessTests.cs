using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DemoLibrary;
using DemoLibrary.Models;

namespace DemoLibrary_Tests
{
    public class DataAccessTests
    {
        [Fact]
        public void AddPersonToPeopleList_ShouldWork()
        {
            PersonModel newPerson = new PersonModel { FirstName = "John", LastName = "Smith"};
            List<PersonModel> people = new List<PersonModel>();

            DataAccess.AddPersonToPeopleList(people,newPerson);
            Assert.True(people.Count == 1);
            Assert.Contains<PersonModel>(newPerson, people);
        }

        [Theory]
        [InlineData("Tim", "", "LastName")]
        [InlineData("", "Cook", "FirstName")]
        public void AddPersonToPeopleList_ShouldFail(string firstName, string lastNAme, string param)
        {
            PersonModel newPerson = new PersonModel { FirstName = firstName, LastName = lastNAme };
            List<PersonModel> people = new List<PersonModel>();

            Assert.Throws<ArgumentException>(param, () => DataAccess.AddPersonToPeopleList(people, newPerson));
        }
    }
}
