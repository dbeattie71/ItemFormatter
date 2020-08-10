namespace ItemFormatter.Common
{
    public static class Extensions
    {
        public static string TrimEnd(this string source, string value)
        {
            return !source.EndsWith(value) ? source : source.Remove(source.LastIndexOf(value));
        }
    }
}
