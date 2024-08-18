namespace Open_Closed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in After.QuestionBank.Generate())
            {
                item.PrintQustion();
            }
        }
    }
}
