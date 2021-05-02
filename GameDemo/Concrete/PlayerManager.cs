using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
  
    class PlayerManager : IManagerService<Person>
    {
        IPersonCheckService _personCheckService;
        public PlayerManager(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }
        public void Add(Person entity)
        {
            if (_personCheckService.CheckIfRealPerson(entity))
            {
                Console.WriteLine("A valid person");
                Console.WriteLine("Save to db : " + entity.Name);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }
        public void Delete(Person entity)
        {
            Console.WriteLine(entity.Name + " Deleted");
        }
        public void Update(Person entity)
        {
            Console.WriteLine(entity.Name + " Updated");
        }
    }
}
