using MsCoders.Agents;
using System;
using System.Threading.Tasks;

namespace DemoMsCoders
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comienza la demo");
            Agent1 ag1 = new Agent1();
            Agent2 ag2 = new Agent2();
           
           Task tsk= ag1.Run();
           Task tsk2= ag2.Run();
           
           
            Message msg1 = new Message()
            {
                Count = 5.0M,
                Incremt = 2.0M,
                Price = 4.0M,
                Text = "Manzanas"
            };

            Message msg2 = new Message()
            {
                Count = 3.0M,
                Incremt = 4.0M,
                Price = 3.5M,
                Text = "Naranjas"
            };

            ag1.Input.Enqueue(msg1);
            ag2.Input.Enqueue(msg1);
            ag1.Input.Enqueue(msg2);
            ag2.Input.Enqueue(msg2);

            Console.WriteLine("Fin de la demo");

            Console.ReadKey();

        }
    }
}
