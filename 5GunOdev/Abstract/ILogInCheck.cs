using System;
using System.Collections.Generic;
using System.Text;
using _5GunOdev.Adapter;

namespace _5GunOdev.Abstract
{
    interface ILogInCheck: IMernisServiceAdapter
    {
        void LoginCheck();
    }
}
