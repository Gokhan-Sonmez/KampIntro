using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
   public class Campaing :IEntity
    {
        public int CampaingId { get; set; }
        public string CampaingName { get; set; }
        public double DiscountRate { get; set; }

    }
}
