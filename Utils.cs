namespace AdafyBlazorApp
{
    public static class Utils
    {
        public static string ReplaceUrlProtocolToSecure(this string url)
        {
            return url.Replace("http", "https");
        }
    }
}
