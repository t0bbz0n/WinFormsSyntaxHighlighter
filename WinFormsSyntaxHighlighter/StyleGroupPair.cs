using System;

namespace WinFormsSyntaxHighlighter
{
    internal class StyleGroupPair
    {
        public int Index { get; set; }
        public SyntaxStyle SyntaxStyle { get; set; }
        public string GroupName { get; set; }

        public StyleGroupPair(SyntaxStyle syntaxStyle, string groupName)
        {
            SyntaxStyle = syntaxStyle ?? throw new ArgumentNullException(nameof(syntaxStyle));
            GroupName = groupName ?? throw new ArgumentNullException(nameof(groupName));
        }
    }
}
