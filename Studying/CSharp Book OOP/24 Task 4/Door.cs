public class Door
{
    //State Related Stuff
    public DoorState State { get; set; } = DoorState.Locked;
    public DoorState Open()
    {
        return DoorState.Open;
    }
    public DoorState Close()
    {
        return DoorState.Closed;
    }
    public DoorState Lock()
    {
        Console.Beep();      //just for fun
        return DoorState.Locked;
    }
    public DoorState Unlock()
    {
        Console.Write("Enter the password.");
        int currentPassword = Convert.ToInt32(Console.ReadLine());
        if (currentPassword == Password)
        {
            return DoorState.Closed;
        }
        else
        {
            Console.WriteLine("Sorry, the password is wrong, try again.");
            return DoorState.Locked; 
        }
    }


    //Password Related Stuff
    public int Password { get; set; }

    public Door(int startCode)
    {
        Password = startCode;
    }

    public void ChangePassword()
    {
        Console.Write("Enter the current password ");
        int currentPassword = Convert.ToInt32(Console.ReadLine());

        if (currentPassword == Password)
        {
            Console.Write("Enter the new password ");
            int newPassword = Convert.ToInt32(Console.ReadLine());
            Password = newPassword;
        }
    }
}