using System.Collections;

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
            #region question 4
            // 1
            //var emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            //
            //// 2
            //mails.Add("ahmed@test.com");  
            //mails.Add("AHMED@test.com");  
            //mails.Add("sara@test.com");   
            //mails.Add("Sara@Test.Com");   
            //
            //// 3
            //Console.WriteLine( emails.Count);
            //Console.WriteLine(string.Join(", ", emails));
            //
            //// 4
            //var setA = new HashSet<int> { 1, 2, 3, 4, 5 };
            //var setB = new HashSet<int> { 4, 5, 6, 7, 8 };
            //
            //// 5
            //var union = new HashSet<int>(setA);
            //union.UnionWith(setB);
            //Console.WriteLine($"\nUnion:     {string.Join(", ", union)}");
            //
            //var intersect = new HashSet<int>(setA);
            //intersect.IntersectWith(setB);
            //Console.WriteLine($"Intersect: {string.Join(", ", intersect)}");
            //
            //var except = new HashSet<int>(setA);
            //except.ExceptWith(setB);
            //Console.WriteLine($"Except:    {string.Join(", ", except)}");
            //
            //// 6
            //var small = new HashSet<int> { 1, 2 };
            //Console.WriteLine($" {small.IsSubsetOf(setA)}");
            #endregion
            #region question 5
            
           // Queue<string> q1 = new Queue<string>();
           // q1.Enqueue("Report.pdf");
           // q1.Enqueue("Invoice.pdf");
           // q1.Enqueue("Letter.docx");
           // q1.Enqueue("Resume.pdf");
           // //1
           // Console.WriteLine(q1.Count);
           // foreach (var item in q1)
           // {
           //     Console.WriteLine(item);
           // }
           // //2
           // Console.WriteLine(q1.Peek());
           // //3 
           // for (;  q1.Count>0; )
           // {
           //     Console.WriteLine($"printing:{q1.Dequeue()}");
           // }
           // //4
           // bool now_empty_queue = q1.TryDequeue(out string result);
           // Console.WriteLine(result);
           // Console.WriteLine(now_empty_queue);



            #endregion

        }
    }
}
