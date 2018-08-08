using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AfinMobil
{
    class appMobil
    {
        
        public static void init()
        {
           Login g = new Login();
           App.getmain.addpage(g);
        }
    }
}
