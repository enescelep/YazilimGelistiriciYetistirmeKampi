using System;
using _5GunOdev.Entities;
using _5GunOdev.Concretes;

namespace _5GunOdev
{
    public class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer
            {
                Name = "Ahmet",
                LastName = "Kaya",
                NationalityID = 12345678912,
                DateOfBirth = new DateTime(2000, 1, 15)
            };
            Game game1 = new Game
            {
                Name = "GTA 5",
                UnitPrice = 169.90
            };
            Game game2 = new Game
            {
                Name = "Metro: Last Light Redux",
                UnitPrice = 18.90
            };
            Campaign campaign1 = new Campaign
            {
                Id = 1,
                Name = "Special for students",
                Rate = 0.25
            };
            CampaignManager campaignManager = new CampaignManager();
            GameManager gameManager = new GameManager();
            GamerManager gamerManager = new GamerManager();
            

            gamerManager.SignIn(gamer1);
            gameManager.Buy(gamer1,game1,campaign1);
            campaignManager.Add(campaign1);
            gameManager.Add(game2);
        }
    }
}