using DesignPatterns.Patterns.Creational.Singleton;

partial class Program
{
    static void Main(string[] args)
    {
        TestSingleton();
       
    }

    #region Singleton

    private static void TestSingleton()
    {
        // Enables only one test function at a time!!!

        // TestSingletonStandart();
        // TestSingletonStandartWithThreads(300);
        TestSingletonSafeThreads(300);
    }

    private static void TestSingletonStandart()
    {
        printTestSeparator("Testing Singleton standart pattern...");

        Console.WriteLine(
               "{0}\n{1}\n\n{2}\n",
               "If you see the same value, then singleton was reused => WORKS!",
               "If you see different values, then 2 singletons were created =>  FAILS!",
               "Result:"
           );

        var singleton1 = Singleton.GetInstance("UNO");
        var singleton2 = Singleton.GetInstance("DOS");

        Console.WriteLine(singleton1.Value);
        Console.WriteLine(singleton2.Value);
    }

    private static void TestSingletonStandartWithThreads(int numOfThreads)
    {
        // If we run this test several times, it will fail
        printTestSeparator("Testing Singleton Safe pattern with threads");

        Console.WriteLine(
              "{0}\n{1}\n\n{2}\n",
              "If you see the same value, then singleton was reused => WORKS!",
              "If you see different values, then 2 singletons were created =>  FAILS!",
              "Result:"
          );

        Parallel.For(0, numOfThreads, i =>
        {
            var singleton = Singleton.GetInstance(i.ToString());
            Console.Write($"{singleton.Value} ");
        });
    }

    private static void TestSingletonSafeThreads(int numOfThreads)
    {
        printTestSeparator("Testing Singleton Safe pattern with threads");

        Console.WriteLine(
              "{0}\n{1}\n\n{2}\n",
              "If you see the same value, then singleton was reused => WORKS!",
              "If you see different values, then 2 singletons were created =>  FAILS!",
              "Result:"
          );

        Parallel.For(0, numOfThreads, i =>
        {
            var singleton = SingletonSafeThreads.GetInstance(i.ToString());
            Console.Write($"{singleton.Value} ");
        });
    }

    #endregion


    #region Helpers

    private static void printTestSeparator(string? testNanme)
    {
        Console.WriteLine($"{Environment.NewLine}-------------------------{Environment.NewLine}");
        Console.WriteLine($">>> {testNanme}{Environment.NewLine}");
    } 
    
    #endregion

}



