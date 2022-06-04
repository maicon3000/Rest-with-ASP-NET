﻿using RestWithASPNET5.Controllers.Model;
using RestWithASPNET5.Controllers.Model.Context;
using RestWithASPNET5.Controllers.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASPNET5.Controllers.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private readonly IPersonRepository _repository;

        public PersonBusinessImplementation(IPersonRepository reprository)
        {
            _repository = reprository;
        }

        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }

        public Person FindByID(long id)
        {
            return _repository.FindByID(id);
        }

        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        public Person Update(Person person)
        {
            return _repository.Update(person);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
