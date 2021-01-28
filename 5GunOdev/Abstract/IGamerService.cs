using System;
using System.Collections.Generic;
using System.Text;
using _5GunOdev.Entities;

namespace _5GunOdev.Abstract
{
    interface IGamerService
    {
        void SignUp(Gamer gamer);
        void SignIn(Gamer gamer);
        void SignOut(Gamer gamer);
    }
}
