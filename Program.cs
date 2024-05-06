using ums_proj;

List<User> users = new List<User>(); // iinitialize class as a list because we want to store user data in the list
bool status = true;
while (status)
{
    Console.WriteLine("1. Add user");
    Console.WriteLine("2. View users");
    Console.WriteLine("3. Delete user");
    Console.WriteLine("4. Exit");
    Console.WriteLine("Enter your preferred option");
    string option = Console.ReadLine();
    switch (option)
    {
        case "1":
            Console.WriteLine("Enter UserId");
            string userId = Console.ReadLine();
            Console.WriteLine("Enter Username");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            string salary = Console.ReadLine();
            User newUser = new User(userId, username, email, salary); // after getting user details, we create the user
            users.Add(newUser); // store created user in list called `users`
            break;
        case "2":
            Console.WriteLine("List of users: ");
            foreach (var user in users)
            {
                // we are returning the user in an organized way
                Console.WriteLine($"UserId: {user.UserId}, Username: {user.Username}, Email: {user.Email}, Salary: {user.Salary}");
            }
            break;
        case "3":
            Console.WriteLine("Enter ID of the user you want to delete");
            string idOfUser = Console.ReadLine();
            User userToDelete = users.Find(user => user.UserId == idOfUser); // this finds the user with specified id from the list
            if (userToDelete != null)
            {
                // if user to delete is valid, remove the user from the list
                users.Remove(userToDelete);
                Console.WriteLine("User deleted");
            }
            else{
                Console.WriteLine("User not found");
            }
            break;
        case "4":
            status = false;
            break;
        default:
            Console.WriteLine("Invalid selection");
            break;

    }
}

