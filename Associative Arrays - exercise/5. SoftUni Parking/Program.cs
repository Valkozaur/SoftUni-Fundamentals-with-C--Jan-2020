using System;
using System.Linq;

namespace _5._SoftUni_Parking
{
    using System.Collections.Generic;
    public class Program
    {
        static void Main()
        {
            var parkingUsers = new List<ParkingUser>();

            var numberOfInputs = int.Parse(Console.ReadLine());

            for (var i = 0; i < numberOfInputs; i++)
            {
                var splitInput = Console.ReadLine()
                    .Split(" ");
                var command = splitInput[0];
                var userName = splitInput[1];

                if (command == "register")
                {
                    var plateNumber = splitInput[2];

                    var user = parkingUsers.FirstOrDefault(x => x.UserName == userName);
                    if (user != null)
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {user.CarPlate}");
                    }
                    else
                    {
                        var newUser = new ParkingUser(userName, plateNumber);
                        parkingUsers.Add(newUser);
                        Console.WriteLine($"{newUser.UserName} registered {newUser.CarPlate} successfully");
                    }
                }
                else if (command == "unregister")
                {
                    var user = parkingUsers.FirstOrDefault(x => x.UserName == userName);
                    if (user != null)
                    {
                        Console.WriteLine($"{user.UserName} unregistered successfully");
                        parkingUsers.Remove(user);
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                }
            }

            foreach (var user in parkingUsers)
            {
                Console.WriteLine(user);
            }
        }
    }
}
