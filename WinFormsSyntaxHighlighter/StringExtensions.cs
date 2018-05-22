using System;

namespace WinFormsSyntaxHighlighter
{
    public static class StringExtensions
    {
        public static string NormalizeLineBreaks(this string instance, string preferredLineBreak)
            => instance.Replace("\r\n", "\n").Replace("\r", "\n").Replace("\n", preferredLineBreak);
        

        public static string NormalizeLineBreaks(this string instance)
            => NormalizeLineBreaks(instance, Environment.NewLine);
    }
}
