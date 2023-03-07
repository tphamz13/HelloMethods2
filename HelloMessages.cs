namespace HelloMethods2
{
    public class Message
    {
        public static string GetMessage(string lang)
        {
            if (lang.Equals("sp")) {
                return "Hola Mundo";
            }
            else if (lang.Equals("fr"))
            {
                return "Bonjour le monde";
            }
            else if (lang.Equals("gr"))
            {
                return "Hallo Welt!";
            }
            else
            {
                return "Hello World";
            }
        }
    }
}