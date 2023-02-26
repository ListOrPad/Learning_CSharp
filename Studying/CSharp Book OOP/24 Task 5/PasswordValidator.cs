public class PasswordValidator
{
    public string Password { get; set; }

    public bool IsValid(string password)
    {
        if (password.Length < 6) return false;
        if (password.Length > 13) return false;
        if (!HasUpperCase(password)) return false;
        if (!HasLowerCase(password)) return false;
        if (!HasDigit(password)) return false;
        if (Contains(password, 'T')) return false;
        if (Contains(password, '&')) return false;

        return true;
    }
    public string TellIfValid(string password)
    {
        if (IsValid(password))
            return "Allowed";
        else
            return "Forbidden";
    }
    private bool HasUpperCase(string password)
    {
        foreach (char letter in password)
        {
            if (char.IsUpper(letter))
            {
                return true;
            }
        }
        return false;
    }
    private bool HasLowerCase(string password)
    {

        foreach (char letter in password)
        {
            if (char.IsLower(letter))
            {
                return true;
            }
        }
        return false;
    }
    private bool HasDigit(string password)
    {

        foreach (char letter in password)
        {
            if (char.IsDigit(letter))
            {
                return true;
            }
        }
        return false;
    }
    private bool Contains(string password, char letter)
    {
        foreach (char containedLetter in password)
        {
            if (containedLetter == letter)
            {
                return true;
            }
        }
        return false;
    }
}
