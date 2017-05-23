using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.User_Logins
{
    public class Program
    {
       public static void Main()
        {
            var accounts = new Dictionary<string, string>();
            var loginAccounts = new Dictionary<string, string>();
            var count = 0;
            bool isLogin = false;
            var usernameAndPassword = Console.ReadLine();
            while (usernameAndPassword != "end" && isLogin == false) 
            {
                    var usernameAndPasswordParts = usernameAndPassword
                        .Split(new string[] { "->", " " }
                    , StringSplitOptions.RemoveEmptyEntries).ToList();
                    var username = usernameAndPasswordParts[0];
                    var password = usernameAndPasswordParts[1];
                    accounts[username] = password;
                    usernameAndPassword = Console.ReadLine();
                while (usernameAndPassword == "login")
                {
                    isLogin = true;
                    var loginUsernamePassword = Console.ReadLine();
                    if (loginUsernamePassword == "end")
                    {
                        break;
                    }
                    var loginUsernamePasswordParts = loginUsernamePassword.Split(new string[] { "->", " " }
                    , StringSplitOptions.RemoveEmptyEntries).ToList();
                    var loginUsername = loginUsernamePasswordParts[0];
                    var loginPassword = loginUsernamePasswordParts[1];
                    loginAccounts[loginUsername] = loginPassword;
                    if (!accounts.ContainsKey(loginUsername))
                    {
                        Console.WriteLine($"{loginUsername}: login failed");
                        count++;
                    }
                    else
                    {
                        if (accounts[loginUsername] == loginAccounts[loginUsername])
                        {
                            Console.WriteLine($"{loginUsername}: logged in successfully");
                        }
                        else
                        {
                            Console.WriteLine($"{loginUsername}: login failed");
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine($"unsuccessful login attempts: {count}");
        }
    }
}