using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class CampaingManager : IManagerService<Campaing>
    {
        public void Delete(Campaing entity)
        {
            Console.WriteLine(entity.CampaingName + " Deleted");
        }

        public void Add(Campaing entity)
        {
            Console.WriteLine(entity.CampaingName + " Added");
        }

        public void Update(Campaing entity)
        {
            Console.WriteLine(entity.CampaingName + " Update");
        }
    }
}
