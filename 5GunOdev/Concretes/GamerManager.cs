using System;
using _5GunOdev.Abstract;
using _5GunOdev.Adapter;
using _5GunOdev.Entities;

namespace _5GunOdev.Concretes
{
    class GamerManager : IGamerService
    {
        Check check = new Check();
        public void SignIn(Gamer gamer)
        {
            Console.WriteLine("Signed in!");
        }

        public void SignOut(Gamer gamer)
        {
            Console.WriteLine("Signed out!");
        }

        public void SignUp(Gamer gamer)
        {
            if((check.CheckIfRealPerson(gamer))==true)
            {
                Console.WriteLine("Signed up!");
            }
            else
            {
                Console.WriteLine("Validation failed. Signing up failed.");
            }
        }
    }
}
