﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projPilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> pilhaInt;
            pilhaInt = new Stack<int>();

            pilhaInt.Push(10);
            pilhaInt.Push(20);
            pilhaInt.Push(30);
            pilhaInt.Push(40);
            pilhaInt.Push(50);

            mostraPilha(pilhaInt);

            Console.WriteLine("Topo da pilha: {0}", pilhaInt.Peek());
            Console.WriteLine("Primeiro elemento da pilha: {0}", pilhaInt.First());
            Console.WriteLine("Último elemento da pilha: {0}", pilhaInt.Last());
            mostraPilha(pilhaInt);

            Console.WriteLine("Saiu da pilha: {0}", pilhaInt.Pop());
            mostraPilha(pilhaInt);

            Console.WriteLine("Saiu da pilha: {0}", pilhaInt.Pop());
            Console.WriteLine("Saiu da pilha: {0}", pilhaInt.Pop());
            mostraPilha(pilhaInt);

        }

        static void mostraPilha(Stack<int> pilha)
        {
            int k;
            Console.WriteLine("-- Qtde de elementos: {0} --", pilha.Count);
            k = 0;
            foreach(int i in pilha)
            {
                Console.WriteLine("{0}º elemento: {1}", ++k, i);
            }
            Console.WriteLine("----------------------");
        }


    }
}
