using GameDemo.Concrete;
using GameDemo.Entities;
using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        { 
            PlayerManager playerManager = new PlayerManager(new PersonCheckManager());
            //Person
            playerManager.Add(new Person { Id = 1,NationalityId = "12345678",Name = "Game",
             Surname = "Player",DateOfBirth = new DateTime(1989, 01, 01)});
            //Game
            Game game1 = new Game { GameId = 2, GameName = "Age of Empires", Price = 100 };
            Game game2 = new Game { GameId = 3, GameName = "Counter-Strike", Price = 75 };
            //Player
            Player player1 = new Player {UserName="Gohenka",Password="12345",Email="gohenka@email.com",Balance=500 };
            //campain
            Campaing campaing1 = new Campaing {CampaingId=1,CampaingName= "Discount campaign",DiscountRate=10 };

            SalesManager salesManager = new SalesManager();
            salesManager.Buy(player1,game1);
            salesManager.Discount(campaing1, game1);
            salesManager.ReturnBackGame(game1);
        }
    }
}
