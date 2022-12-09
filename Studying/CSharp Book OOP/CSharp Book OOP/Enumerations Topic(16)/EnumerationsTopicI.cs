using CSharp_Book_OOP;

internal class EnumerationsTopic
{
    public void Invoke()
    {
        //Semula's test challenge 📦📦📦
        ChestState state = ChestState.Locked;
        string input;
        while (true)
        {
            input = Program.Input($"The chest is {state}. What do you want to do?  ");

            if (state == ChestState.Locked && input == "unlock") state = ChestState.Closed;
            else if (state == ChestState.Closed && input == "open") state = ChestState.Open;
            else if (state == ChestState.Open && input == "close") state = ChestState.Closed;
            else if (state == ChestState.Closed && input == "lock") state = ChestState.Locked;
            else
                Console.WriteLine("I don't know what it is. Try using \"unlock\" \"lock\" \"close\" or \"open\"  ");

        }
    }
}