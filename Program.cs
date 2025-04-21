using System;
using System.Globalization;

namespace ExercicioFixacao1 {
    class Program {
        static void Main(string[] args) {

            Student[] vect = new Student[10];


            Console.Write("How many rooms will be retend? = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++) {

                Console.WriteLine();
                Console.WriteLine("$ Rent #{i}:");

                Console.Write("Name: ");
                string name = Console.ReadLine(); 

                Console.Write("E-mail: ");
                string email = Console.ReadLine();

                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                vect[room] = new Student(name, email);
            }

            if (vect[room] != null) {
                Console.WriteLine("Room already occupied! Try another number");
                i--;
                continue;
            }

            vect[room] = new Student(name, emial);
        }

            Console.WriteLine();
            Console.WriteLine("Occupied rooms: ");
            for (int i = 0; i < 10; i++) {
                if (vect[i] != null) {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }

        }
    }
}