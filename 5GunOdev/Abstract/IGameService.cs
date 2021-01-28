using _5GunOdev.Entities;
namespace _5GunOdev.Abstract
{
    interface IGameService
    {
        void Buy(Gamer gamer, Game game, Campaign campaign);
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
    }
}
