using System;
using System.Collections.Generic;
using System.Text;
using _5GunOdev.Entities;
using _5GunOdev.Abstract;
namespace _5GunOdev.Concrete
{
    class GameManager:IManagerService<Game>
    {
        public void Add(Game entity)
        {
            Console.WriteLine("Added!");
            Get(entity);
        }

        public void Delete(Game entity)
        {
            Console.WriteLine("Deleted!");
            Get(entity);
        }
        public void Update(Game entity)
        {
            Console.WriteLine("Updated!");
            Get(entity);
        }
        public void Get(Game entity)
        {
            Console.WriteLine("GameId: {0}  |  GameName: {1}  |  GamePrice: {2}\n", entity.GameId, entity.GameName, entity.GamePrice);
        }

        public void GetAll(List<Game> entities)
        {
            foreach (var item in entities)
            {
                Console.WriteLine("GameId: {0}  |  GameName: {1}  |  GamePrice: {2}\n", entity.GameId, entity.GameName, entity.GamePrice);
            }
            Console.WriteLine();
        }
    }
}
