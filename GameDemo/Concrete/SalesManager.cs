using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class SalesManager : ISellingService
    {


        public void Buy(Player player, Game game)
        {
            Console.WriteLine(" Player : " + player.UserName + " "+ "buying  " + game.GameName);
            Console.WriteLine(" No discount price : " + Convert.ToInt32(game.Price));
            Console.WriteLine("--------------------------------------");
        }

        public void Discount(Campaing campaing, Game game)
        {
            Console.WriteLine("Discounted price: " + (game.Price - (game.Price * (campaing.DiscountRate / 100))));
            Console.WriteLine("--------------------------------------");
        }

        public void ReturnBackGame(Game game)
        {
            Console.WriteLine(game.GameName+ " " + "The game is returned");
        }
    }
}
