using Logger.Controller;

namespace Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var instance = new DatabaseController();
                instance.RetrieveData();
            } 
        }
    }
}
