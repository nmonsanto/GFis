using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AfinMobil
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //--
        }

        public void addpage(ContentView e)
        {
            StackLayout v = ((StackLayout)App.getmain.Content).FindByName<StackLayout>("center");
            if (v != null)
            {
                if(v.Children.Count > 0)
                {
                    v.Children.RemoveAt(0);
                }

                v.Children.Add(e);
                v.ForceLayout();
            }
        }
        public static void addmenu(Element e)
        {

        }
        public static void addfooter(Element e)
        {

        }
    }
}
