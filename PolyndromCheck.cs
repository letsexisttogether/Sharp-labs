 public class Polyndrom
    {
        static void makeNoSpaces(ref string str)
        {
            string extraString = "";
            foreach (char sym in str)
                if (sym != ' ')
                    extraString += sym;
            str = extraString;
        }
        static bool isPolyndrom(string str = "a")
        {
            makeNoSpaces(ref str);
            for (int i = 0; i < str.Length; i++)
                if (str[i] != str[str.Length - i - 1])
                    return false;
            return true;
        }
    }
