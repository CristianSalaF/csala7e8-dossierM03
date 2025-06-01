namespace T1Ex9
{
    internal class T1Ex9
    {
        static void Main(string[] args)
        {
            /* 4. Si x=4, y=7, p=true i q=false, avalua les expressions següents:
             * a) y > x && p == q
             * c) !(x * y < 30) && p
             */

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