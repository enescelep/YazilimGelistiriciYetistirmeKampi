using System;
using _5GunOdev.Abstract;
using _5GunOdev.Entities;

namespace _5GunOdev.Concretes
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("{0} added!",game.Name);
        }

        public void Buy(Gamer gamer, Game game, Campaign campaign)
        {
            game.UnitPrice = game.UnitPrice - (game.UnitPrice * campaign.Rate);
            Console.WriteLine("{0} bought {1}:{2}TRY.",gamer.Name,game.Name,game.UnitPrice);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("{0} deleted!", game.Name);
        }

        public void Update(Game game)
        {
            Console.WriteLine("{0} updated!", game.Name);
        }
    }
}
