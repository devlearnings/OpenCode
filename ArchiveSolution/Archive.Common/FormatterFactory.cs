namespace Archive.Common
{
    public static class FormatterFactory
    {
        public static string FormatString(string text)
        {
            return ("*** " + text + " ***");
        }
    }
}
