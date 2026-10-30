namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question2
            // Dictionary<int, string> leaderboard = new Dictionary<int, string>();
            // //1
            // leaderboard.Add(500, "Ahmed");
            // leaderboard.Add(200, "Sara");
            // leaderboard.Add(800, "Ali");
            // leaderboard.Add(350, "Mona");
            // //2
            // foreach (var x in leaderboard)
            // {
            //     Console.WriteLine($"score:{x.Key},,name:{x.Value}");
            // }
            // //3
            // var first = leaderboard.First();
            // Console.WriteLine($"score:{first.Key},,name:{first.Value}");
            // //4
            // Console.WriteLine(leaderboard.ContainsKey(500));
            // //5
            // if (leaderboard.TryGetValue(999, out string name)) ;
            // {
            //     Console.WriteLine($"name={name}");
            // }
            // //6
            // leaderboard.Remove(200);
            // foreach (var x in leaderboard)
            // {
            //     Console.WriteLine($"score:{x.Key},,name:{x.Value}");
            // }


            #endregion
            #region question3
         // //1
         // Dictionary<string, int> phonebook = new Dictionary<string, int>();
         // //2
         // phonebook.Add("ahmed", 010);
         // phonebook.Add("ali", 011);
         // phonebook.Add("abdo", 012);
         // phonebook.Add("bido", 015);
         // //3
         // try
         // {
         //     phonebook.Add("ahmed", 010);
         // }
         // catch (ArgumentException ex)
         // {
         //     Console.WriteLine($"Error: {ex.Message}");
         // }
         // //4
         // Console.WriteLine( phonebook.TryAdd("ahmed", 010));
         // //5
         // phonebook.TryGetValue("hassan", out int n);
         // //6
         // Console.WriteLine(phonebook.Keys);
         // Console.WriteLine(phonebook.Values);
            #endregion

        }
    }
}
