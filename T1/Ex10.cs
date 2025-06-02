namespace T1
{
    internal class Ex10
    {
        internal static void Exercise(string[] args)
        {
            const string TxtPressToExit = "Prem qualsevol tecla per sortir...";

            int x = 10;
            int y = 20;
            int z = x + y;
            Console.WriteLine("El resultat és: {0}", z);
            Console.WriteLine(TxtPressToExit);
            Console.ReadKey();
        }
    }
}
