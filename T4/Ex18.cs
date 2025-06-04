using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    public class Ex18
    {
        public static void Exercise()
        {
            const string TxtQueueStart = "Cua d'espera inicial:";
            const string TxtQueueProcessing = "Processant els tres primers noms...";
            const string TxtQueueResult = "Qui queda a la cua d'espera:";

            const string TxtPressToExit = "Prem qualsevol tecla per sortir...";

            Queue<string> waitingQueue = new Queue<string>();
            waitingQueue.Enqueue("Alice");
            waitingQueue.Enqueue("Bob");
            waitingQueue.Enqueue("Charlie");
            waitingQueue.Enqueue("David");
            waitingQueue.Enqueue("Eve");

            Console.WriteLine(TxtQueueStart);
            foreach (var name in waitingQueue)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();
            Console.WriteLine(TxtQueueProcessing);
            for (int i = 0; i < 3 && waitingQueue.Count > 0; i++)
            {
                string processedName = waitingQueue.Dequeue();
                Console.WriteLine($"Processat: {processedName}");
            }

            Console.WriteLine();
            Console.WriteLine(TxtQueueResult);
            foreach (var name in waitingQueue) 
                Console.WriteLine(name);

            Console.WriteLine(TxtPressToExit);
            Console.ReadKey();
        }
    }
}
