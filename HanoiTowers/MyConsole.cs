namespace HanoiTowers
{
    internal class MyConsole
    {
        public static int AskForNoAndReturnIndex(string question)
        {
            Console.Write(question);
            var numberStr = Console.ReadLine();
            return Convert.ToInt32(numberStr) - 1;
        }
    }
}
