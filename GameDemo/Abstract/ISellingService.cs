using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public interface ISellingService
    {
        void Buy(Player player,Game game);
        void Discount(Campaing campaing, Game game);
        void ReturnBackGame(Game game);
       
      


    }
}
