using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication3
{
    interface Item
    {
        string name();
        double price();
        int Count();
        void minize();

    }
    //classe of rise//
    class Rice : Item
    {
        static int count=10 ;
        string n = "Rice";
        

        public int Count()
        {
            return count;
        }
        public string name()
        {
            return n;
        }

        public double price()
        {
            return 14.5;
        }
        public void minize()
        {
            count--;
        }


    }
    //classe of oil//
    class oil : Item
    {
        static int count = 10;
        string n = "Oil";

        public int Count()
        {
            return count;
        }
        public string name()
        {
            return n;
        }

        public double price()
        {
            return 20.5;
        }
        public void minize()
        {
            count--;
        }



    }
    //calss of sugar//
    class sugar : Item
    {
        static int count = 9;
        string n = "Sugar";

        public int Count()
        {
            return count;
        }
        public string name()
        {
            return n;
        }

        public double price()
        {
            return 11.5;
        }
        public void minize()
        {
            count--;
        }


    }
    //class pf meat//
    class Meat : Item
    {
        static int count = 8;
        string n = "Meat";

        public int Count()
        {
            return count;
        }
        public string name()
        {
            return n;
        }

        public double price()
        {
            return 100;
        }
        public void minize()
        {
            count--;
        }

    }
    //class of fish//
    class fish : Item
    {
        static int count = 7;
        string n = "Fish";

        public int Count()
        {
            return count;
        }
        public string name()
        {
            return n;
        }

        public double price()
        {
            return 60;
        }
        public void minize()
        {
            count--;
        }

    }
    //class of chicken//
    class Chicken : Item
    {
        static int count = 6;
        string n = "Chicken";

        public int Count()
        {
            return count;
        }
        public string name()
        {
            return n;
        }

        public double price()
        {
            return 30;
        }
        public void minize()
        {
            count--;
        }

    }
    //class of pasta//
    class Pasta : Item
    {
        static int count = 4;
        string n = "Pasta";

        public int Count()
        {
            return count;
        }
        public string name()
        {
            return n;
        }

        public double price()
        {
            return 15.30;
        }
        public void minize()
        {
            count--;
        }

    }
    //class of milk//
    class Milk : Item
    {
        static int count = 5;
        string n = "Milk";

        public int Count()
        {
            return count;
        }
        public string name()
        {
            return n;
        }

        public double price()
        {
            return 50;
        }
        public void minize()
        {
            count--;
        }

    }
    //class of Water//
    class Water : Item
    {
        static int count = 3;
        string n = "Water";

        public int Count()
        {
            return count;
        }
        public string name()
        {
            return n;
        }

        public double price()
        {
            return 20.5;
        }
        public void minize()
        {
            count--;
        }

    }
}
