using System.Collections.Generic;
using System.Linq;

namespace WpfAppExample1.Classes
{
    public class MockedData
    {
        public List<Person> PeopleList() 
        {
            return new List<Person>()
            {
                new Person() {Id = 1,FirstName = "Karen",LastName = "Payne"},
                new Person() {Id = 2,FirstName = "Mary",LastName = "Jones"},
                new Person() {Id = 3,FirstName = "Jack",LastName = "Lebow"}
            };
        }

        public Person FindPerson(int code)
        {
            var person = new Person() {Id = -1};

            var result = NewUsers.SystemCodes().ContainsKey(code);
            if (result)
            {
                person = PeopleList().First(user => user.Id == NewUsers.SystemCodes()[code]);
            }

            return person;
        }
    }
}
