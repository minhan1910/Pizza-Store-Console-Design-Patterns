using MinPizzaN.enums;
using MinPizzaN.models.Menus;
using MinPizzaN.views.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinPizzaN
{
    public class Program
    {
        static void Main(string[] args)
        {
            var mainView = new MainView();
            mainView.RunView(); 

            Console.ReadLine();
        }
    }
}
