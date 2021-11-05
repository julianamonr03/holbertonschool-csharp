using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace InventoryManager
{
    class Program
    {
        public static void Main()
        {
            JSONStorage storageDevice = new JSONStorage();
            storageDevice.Load();

            List<string> classList = new List<string>
            {
                "item",
                "user",
                "inventory"
            };

            List<string> commandList = new List<string>
            {
                "classnames",
                "all",
                "create",
                "show",
                "update",
                "delete",
                "exit"
            };

            string prompt = "$ ";

            string[] userSplit;

            while (true)
            {                
                Console.WriteLine("Inventory Manager");
                Console.WriteLine("-------------------------");
                Console.WriteLine("<ClassNames> show all ClassNames of objects");
                Console.WriteLine("<All> show all objects");
                Console.WriteLine("<All [ClassName]> show all objects of a ClassName");
                Console.WriteLine("<Create [ClassName]> a new object");
                Console.WriteLine("<Show [ClassName object_id]> an object");
                Console.WriteLine("<Update [ClassName object_id]> an object");
                Console.WriteLine("<Delete [ClassName object_id]> an object");
                Console.WriteLine("<Exit>");

                int randomConsole = randomNumber.Next(0, promptList.Length);
                prompt = promptList[randomConsole];
                Console.Write(prompt);

                userSplit = Console.ReadLine().Split(' ');


                switch (userSplit[0].ToLower())
                {
                    /// <summary>Displays all available classes.</summary>
                    case "classnames":
                        {
                            foreach (string classes in classList)
                                Console.WriteLine($"{classes}");
                            continue;
                        }

                    /// <summary> Displays all elements. </summary>
                    case "all":
                        {
                            //Display all elements of a given ClassName.
                            try
                            {
                                if (userSplit[1].ToLower() != null)
                                {
                                    if (classList.Contains(userSplit[1].ToLower()))
                                    {
                                        foreach (KeyValuePair<string, object> kvp in storageDevice.objects)
                                        {
                                            if (kvp.Key.Split('.')[0] == userSplit[1].ToLower())
                                            {
                                                Console.WriteLine(kvp.Value);
                                                Console.WriteLine("-------");
                                            }
                                        }
                                    }
                                    else
                                        Console.WriteLine($"{userSplit[1]} is not a valid object type");
                                }
                            }
                            catch (IndexOutOfRangeException)
                            {
                                //Display all elements in the Objects dictionary.
                                foreach (KeyValuePair<string, object> kvp in storageDevice.objects)
                                {
                                    Console.WriteLine(kvp.Value);
                                    Console.WriteLine("-------");
                                }

                            }
                            continue;
                        }

                    /// <summary>Creates a new object.</summary>
                    case "create":
                        {
                            if (userSplit.Length < 2)
                            {
                                Console.WriteLine("Object ClassName is missing");
                                continue;
                            }
                            else
                            {
                                try
                                {
                                    if (classList.Contains(userSplit[1].ToLower()))
                                    {
                                        storageDevice.New(userSplit[1].ToLower());
                                        Console.WriteLine($"Object of the class {userSplit[1]} has been created");
                                        storageDevice.Save();
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{userSplit[1]} is not a valid object type");
                                        continue;
                                    }
                                }
                                catch (IndexOutOfRangeException)
                                {
                                    Console.WriteLine("Usage: Create <ClassName>");
                                    continue;
                                }
                            }
                            continue;
                        }

                    /// <summary> Shows an existing object.</summary>
                    case "show":
                        {
                            if (userSplit.Length == 2)
                            {
                                Console.WriteLine("Id is missing");
                                continue;
                            }
                            else if (userSplit.Length == 1)
                            {
                                Console.WriteLine("ClassName is missing");
                                continue;
                            }
                            else
                            {
                                if (classList.Contains(userSplit[1].ToLower()))
                                {
                                    bool found = false;
                                    foreach (KeyValuePair<string, object> kvp in storageDevice.objects)
                                    {
                                        if (kvp.Key.Split('.')[0] == userSplit[1].ToLower() && kvp.Key.Split('.')[1] == userSplit[2])
                                        {
                                            Console.WriteLine(storageDevice.objects[kvp.Key]);
                                            found = true;
                                            break;
                                        }
                                    }
                                    if (found == false)
                                        Console.WriteLine($"Object {userSplit[2]} could not be found");
                                }
                                else
                                    Console.WriteLine($"{userSplit[1]} is not a valid object type");
                            }
                            continue;
                        }

                    /// <summary> Updates an existing object. </summary>
                    case "update":
                        {
                            if (userSplit.Length == 2)
                            {
                                Console.WriteLine("Id is missing");
                                continue;
                            }
                            else if (userSplit.Length == 1)
                            {
                                Console.WriteLine("ClassName is missing");
                                continue;
                            }
                            continue;
                        }

                    /// <summary>Deletes an existing object. Usage: Delete [ClassName] [Id]</summary>
                    case "delete":
                        {
                            if (userSplit.Length == 2)
                            {
                                Console.WriteLine("Id is missing");
                                continue;
                            }
                            else if (userSplit.Length == 1)
                            {
                                Console.WriteLine("ClassName is missing");
                                continue;
                            }
                            else
                            {
                                if (classList.Contains(userSplit[1].ToLower()))
                                {
                                    bool found = false;
                                    foreach (KeyValuePair<string, object> kvp in storageDevice.objects)
                                    {
                                        if (kvp.Key.Split('.')[0] == userSplit[1].ToLower() && kvp.Key.Split('.')[1] == userSplit[2])
                                        {
                                            storageDevice.objects.Remove(kvp.Key);
                                            storageDevice.Save();
                                            found = true;
                                            break;
                                        }
                                    }
                                    if (found == false)
                                        Console.WriteLine($"Object {userSplit[2]} could not be found");
                                }
                                else
                                    Console.WriteLine($"{userSplit[1]} is not a valid object type");
                            }
                            continue;
                        }

                    /// <summary> Terminatess the console.</summary>
                    case "exit":
                        {
                            // int response = randomNumber.Next(0, exitApp.Length);
                            // Console.WriteLine(exitApp[response]);
                            Console.ForegroundColor = ConsoleColor.White;
                            return;
                        }

                    /// <summary>For unknown commands</summary>
                    default:
                        {
                            // int response = randomNumber.Next(0, commandUnknown.Length);
                            // Console.WriteLine(commandUnknown[response]);
                            Console.WriteLine("Command Unkown");
                            continue;
                        }
                }
            }
        }
    }
}
