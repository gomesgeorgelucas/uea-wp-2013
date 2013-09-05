using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Macaco.Macaco
{
    class Macaco : Comida
    {
        public string nome { get; set; }
        List<Comida> bucho=new List<Comida>();
        public Macaco(string nome)
        {
            this.nome = nome;
        }
        public Macaco()
        {
        }
        public void Comer(Comida c)
        {
            bucho.Add(c);
        }
        public void VerBucho()
        {
            foreach (Comida  c in bucho)
            {
                Console.WriteLine(c.nome);
            }
        }
        public void Digerir(int cheio)
        {
            bucho.Clear();
        }
    }
    class Comida
    {
        public string nome { get; set; }
        public Comida(string nome)
        {
            this.nome = nome;
        }
        public Comida()
        {
        }
    }
    class Menu
    {
        private List<Comida> menu;

        public Menu()
        {
        }
        public void insereAlimento(Comida c)
        {
            menu.Add(c);
        }
        public void mostrarMenu()
        {
            foreach (Comida c in menu)
            {
                Console.WriteLine(c);
            }
        }
        public void removeMenu(Comida c)
        {
            menu.Remove(c);
        }
    }
    class Main
    {
        public void Main(String[] args)
        {
            string op;
            Menu me = new Menu();
            Macaco m1 = new Macaco("Steve");
            Macaco m2 = new Macaco("Chita");
            Comida c1 = new Comida("Manga");
            Comida c2 = new Comida("Banana");
            Comida c3 = new Comida("Pera");
            Comida c4 = new Comida("Macaco");
            me.insereAlimento(c1);
            me.insereAlimento(c2);
            me.insereAlimento(c3);
            me.insereAlimento(c4);
            System.Console.WriteLine("Comidas disponiveis: \n");
            me.mostrarMenu();
            System.Console.WriteLine("Quer comer algo\n");

            op = Console.ReadLine();
            if (op.Equals("sim"))
            {
                System.Console.WriteLine("Que alimeto você quer\n");
                op = Console.ReadLine();
                switch(op)
                {
                    case "Manga": 
                        m1.Comer(c1);
                        me.removeMenu(c1);
                        break;
                    case "Banana":
                        m1.Comer(c2);
                        me.removeMenu(c2);
                        break;
                    case "Pera":
                        m1.Comer(c3);
                        me.removeMenu(c3);
                        break;
                    case "Macaco":
                        m1.Comer(m2);
                        me.removeMenu(c4);
                        break;
                    default:
                        Console.WriteLine("Não existe este alimento");
                        break;

                }
            }                       
        }
    }
}
