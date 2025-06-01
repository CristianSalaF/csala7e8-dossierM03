namespace T1Ex10
{
    internal class T1Ex10
    {
        static void Main(string[] args)
        {
            const string TxtPressToExit = "Prem qualsevol tecla per sortir...";

            /* int x = 10
             * string y = "20";
             * int z = x + y;
             * Console.WriteLine("El resultat és: " z); */

            int x = 10;
            int y = 20;
            int z = x + y;
            Console.WriteLine("El resultat és: {0}", z);
            Console.WriteLine(TxtPressToExit);
            Console.ReadKey();
        }
    }
}
