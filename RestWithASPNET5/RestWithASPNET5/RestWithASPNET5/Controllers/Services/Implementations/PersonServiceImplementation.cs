using RestWithASPNET5.Controllers.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RestWithASPNET5.Controllers.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            //ADICIONAR PESSOA CRIADA NA BASE DE DADOS E RETORNAR A PESSOA CRIADA.
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> people = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                people.Add(person);
            }

            return people;
        }

        public Person FindByID(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Maicon",
                LastName = "Moraes",
                Address = "Mesquita, Rio de Janeiro",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            //IR A BASE DE DADOS, REALIZAR UPDATE E RETORNAR A PESSOA ATUALIZADA.
            return person;
        }
        
        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person Name " + i,
                LastName = "Person LastName " + i,
                Address = "Some Address " + i,
                Gender = "Male"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
