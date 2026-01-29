using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace JSONHandling;

public class JsonListToArray
{
    public static void Convert()
    {
        var users = new List<User>
        {
            new User { Name = "Raj", Age = 26 },
            new User { Name = "Neha", Age = 22 }
        };

        string json = JsonConvert.SerializeObject(users, Formatting.Indented);
        Console.WriteLine("\nJSON Array:\n" + json);
    }
}
