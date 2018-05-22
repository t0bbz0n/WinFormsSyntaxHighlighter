using System;

namespace WinFormsSyntaxHighlighter
{
    public class Expression
    {
        public ExpressionType Type { get; private set; }
        public string Content { get; private set; }
        public string Group { get; private set; }

        public Expression(string content, ExpressionType type, string group)
        {
            Type = type;
            Content = content ?? throw new ArgumentNullException(nameof(content));
            Group = group ?? throw new ArgumentNullException(nameof(group));
        }

        public Expression(string content, ExpressionType type)
            : this(content, type, String.Empty)
        {
        }

        public override string ToString()
        => Type == ExpressionType.Newline 
            ? string.Format("({0})", Type)
            : string.Format("({0} --> {1}{2})", Content, Type, Group.Length > 0? " --> " + Group : String.Empty);
    }
}
