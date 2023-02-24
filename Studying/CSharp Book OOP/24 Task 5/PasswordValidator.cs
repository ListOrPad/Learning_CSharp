public class PasswordValidator
{
    public string? Password { get; set; }

    public bool CheckLettersInPassword(string password)
    {
        foreach (char letter in password)
        {
            if (!char.IsDigit(letter) && !char.IsUpper(letter) && !char.IsLower(letter) || letter == 'T' || letter == '&')
                //IMPORTANT: only one invalid character is enough to tell that logic is FALSE
            {
                return false;
            }
        };
        return true;
    }
    public string TellIfValid(string password)
    {
        if (password.Length >= 6 && password.Length <= 13 && CheckLettersInPassword(password))
        {
            return "Allowed";
        }
        else
        {
            return "Forbidden"; 
        }
    }

}
