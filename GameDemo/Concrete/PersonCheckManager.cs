using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    class PersonCheckManager : IPersonCheckService
    {
        public bool CheckIfRealPerson(Person person)
        {
            return true;
        }
    }
}
