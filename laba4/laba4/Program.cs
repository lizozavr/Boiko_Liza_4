using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    interface GardenTree
    {
        string Planting();
        void Info();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Garden Trees:");
            AppleTree ap1 = new AppleTree(6, 49);
            ApricotTree apr1 = new ApricotTree(1, 58);
            CherryTree ch1 = new CherryTree(2, 73);
            PearTree pea1 = new PearTree(5, 46);
            PlumTree pl1 = new PlumTree(3, 67);

            ap1.Info();
            Console.WriteLine(ap1.Planting());
            Console.WriteLine("");
            apr1.Info();
            Console.WriteLine(apr1.Planting());
            Console.WriteLine("");
            ch1.Info();
            Console.WriteLine(ch1.Planting());
            Console.WriteLine("");
            pea1.Info();
            Console.WriteLine(pea1.Planting());
            Console.WriteLine("");
            pl1.Info();
            Console.WriteLine(pl1.Planting());
            Console.ReadKey();
        }
    }

    class AppleTree:GardenTree
    {
        public string name = "Apple tree";
        private int _number, _age, _fruiting;

        public AppleTree(int age, int fruiting)
        {
            _number = 1;
            _age = age;
            _fruiting = fruiting;
        }
        public string Planting()
        {
            if (_age >= 1 && _age <= 3 && _fruiting >= 40)
                return "Suitable for transplantation.";
            else return "Not suitable for transplantation.";
        }
         
        public void Info()
        {
            Console.WriteLine(name + ": number " + _number+" Age: " + _age +" Fruiting: "+ _fruiting+" kg");
            Console.WriteLine("An apple is a sweet, edible fruit produced by an apple tree (Malus domestica).");
        }
    }

    class CherryTree:GardenTree
    {
        public string name = "Cherry tree";
        private int _number, _age, _fruiting;

        public CherryTree( int age, int fruiting)
        {
            _number = 2;
            _age = age;
            _fruiting = fruiting;
        }
        public string Planting()
        {
            if (_age >= 1 && _age <= 3 && _fruiting >= 40)
                return "Suitable for transplantation.";
            else return "Not suitable for transplantation.";
        }

        public void Info()
        {
            Console.WriteLine(name + ": number " + _number + " Age: " + _age + " Fruiting: " + _fruiting+" kg");
            Console.WriteLine("A cherry is the fruit of many plants of the genus Prunus, and is a fleshy drupe (stone fruit).");
        }
    }

    class PearTree:GardenTree
    {
        public string name = "Pear tree";
        private int _number, _age, _fruiting;

        public PearTree(int age, int fruiting)
        {
            _number = 3;
            _age = age;
            _fruiting = fruiting;
        }
        public string Planting()
        {
            if (_age >= 1 && _age <= 3 && _fruiting >= 40)
                return "Suitable for transplantation.";
            else return "Not suitable for transplantation.";
        }
        public void Info()
        {
            Console.WriteLine(name + ": number " + _number + " Age: " + _age + " Fruiting: " + _fruiting + " kg");
            Console.WriteLine("The pear tree and shrub are a species of genus Pyrus, in the family Rosaceae, bearing the pomaceous fruit of the same name.");
        }
    }

    class PlumTree:GardenTree
    {
        public string name = "Plum tree";
        private int _number, _age, _fruiting;

        public PlumTree(int age, int fruiting)
        {
            _number = 4;
            _age = age;
            _fruiting = fruiting;
        }
        public string Planting()
        {
            if (_age >= 1 && _age <= 3 && _fruiting >= 40)
                return "Suitable for transplantation.";
            else return "Not suitable for transplantation.";
        }
        public void Info()
        {
            Console.WriteLine(name + ": number " + _number + " Age: " + _age + " Fruiting: " + _fruiting + " kg");
            Console.WriteLine("A plum is a fruit of the subgenus Prunus of the genus Prunus.");
        }
    }

    class ApricotTree:GardenTree
    {
        public string name = "Apricot tree";
        private int _number, _age, _fruiting;

        public ApricotTree(int age, int fruiting)
        {
            _number = 5;
            _age = age;
            _fruiting = fruiting;
        }
        public string Planting()
        {
            if (_age >= 1 && _age <= 3 && _fruiting >= 40)
                return "Suitable for transplantation.";
            else return "Not suitable for transplantation.";
        }
        public void Info()
        {
            Console.WriteLine(name + ": number " + _number + " Age: " + _age + " Fruiting: " + _fruiting + " kg");
            Console.WriteLine("An apricot is a fruit, or the tree that bears the fruit, of several species in the genus Prunus (stone fruits).");
        }

    }
}
