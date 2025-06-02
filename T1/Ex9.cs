namespace T1
{
    internal class Ex9
    {
        internal static void Exercise(string[] args)
        {
            const string TxConditionA = "y > x && p == q";
            const string TxConditionC = "!(x * y < 30) && p";
            const string TxtPressToExit = "Prem qualsevol tecla per sortir...";

            int x = 4, y = 7;
            bool p = true, q = false;

            bool conditionA = y > x && p == q;
            Console.WriteLine($"{TxConditionA} is {conditionA}");

            bool conditionC = !(x * y < 30) && p;
            Console.WriteLine($"{TxConditionC} is {conditionC}");

            Console.WriteLine(TxtPressToExit);
            Console.ReadKey();
        }
    }
}