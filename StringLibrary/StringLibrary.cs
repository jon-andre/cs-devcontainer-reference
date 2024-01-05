namespace UtilityLibraries;

public class StringLibrary
{
    public static bool StartsWithUpper(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
        {
            return false;
        }

        char ch = s[0];
        return char.IsUpper(ch);
    }
}
