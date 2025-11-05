using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Person Emilio = new Person("Emilio", 18);
            Person Santiago = new Person("Santiago", 5);
            Person Gabriela = new Person("Gabriela", 50);
            Person Olga = new Person("Olga", 75);
            Person Helena = new Person("Helena", 16);
            Person Alvaro = new Person("Alvaro", 59);
            
            
            Node<int> n1 = new Node<int>(1);
            Node<int> n2 = new Node<int>(2);
            Node<int> n3 = new Node<int>(3);
            Node<int> n4 = new Node<int>(4);
            Node<int> n5 = new Node<int>(5);
            Node<int> n6 = new Node<int>(6);
            Node<int> n7 = new Node<int>(7);

            Node<Person> n8 = new Node<Person>(Emilio);
            Node<Person> n9 = new Node<Person>(Santiago);
            Node<Person> n10 = new Node<Person>(Gabriela);
            Node<Person> n11 = new Node<Person>(Olga);
            Node<Person> n12 = new Node<Person>(Helena);
            Node<Person> n13 = new Node<Person>(Alvaro);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            n10.AddChildren(n9);
            n10.AddChildren(n8);
            n11.AddChildren(n10);
            n13.AddChildren(n12);
            n11.AddChildren(n13);
            
            // visitar el árbol aquí
            SumVisitor<> visitor = new SumVisitor();
            n1.Accept(visitor);
            Console.WriteLine(visitor.Sum);
        }
    }
}
