﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_004_Inheritance
{
    class ClassA
    {
        public void MethodA() => Console.WriteLine("ClassA.MethodA");
    }
    class ClassB : ClassA
    {
        #region Composition
        //public void MethodA() => new ClassA().MethodA(); 
        #endregion
        public void MethodB() => Console.WriteLine("ClassB.MethodB");
    }
    class Animal
    {

    }
    class Dog : Animal
    {
        private string Sound { get; set; } = "Woof-Woof";
        public void MakeSound() => Console.WriteLine(Sound);
        public void BringStick() => Console.WriteLine("Bring a stick");
    }
    class Cat : Animal
    {
        private string Sound { get; set; } = "Meow-Meow";
        public void MakeSound() => Console.WriteLine(Sound);
        public void CatchMouse() => Console.WriteLine("Catch the mouse");
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassB instance = new ClassB();
            instance.MethodA();
            instance.MethodB();
            new ClassA().MethodA();

            Animal dog = new Dog(), cat = new Cat();
            Animal[] animals = { dog, cat };

            Console.ReadKey();
        }
    }
}
