using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.HtmlControls;

namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BadCode_Demo();
            GoodCode_Demo();
        }

        private static void GoodCode_Demo()
        {
            HtmlBuilder builder = new HtmlBuilder("ul");
            builder.AddChild("li", "123");
            Console.WriteLine(builder.ToString());
            Console.ReadLine();
        }

        private static void BadCode_Demo()
        {
            string[] words = new[] { "hello", "world" };
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("<ul>");
            foreach (string word in words)
            {
                stringBuilder.Append("<li>");
                stringBuilder.Append(word);
                stringBuilder.Append("</li>");
            }
            stringBuilder.Append("</ul>");
            Console.WriteLine(stringBuilder);
            Console.ReadLine();
        }
    }

    public class HtmlElement
    {
        public string Name, Text;
        public List<HtmlElement> Elements = new List<HtmlElement>();
        private const int indentSize = 2;
        public HtmlElement()
        {

        }
        public HtmlElement(string name, string text)
        {
            Name = name; Text = text;
        }
        public override string ToString()
        {
            return ToStringImpliment(0);
        }

        private string ToStringImpliment(int indent)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string i = new string(' ', indent * indentSize);
            stringBuilder.AppendLine($"{i}<{Name}>");
            if (!string.IsNullOrWhiteSpace(Text))
            {
                stringBuilder.Append($"{new string(' ', indent + 1 * indentSize)}");
                stringBuilder.AppendLine(Text);
            }
            foreach(var h in Elements)
            {
                stringBuilder.Append(h.ToStringImpliment(indent + 1));
            }
            stringBuilder.AppendLine($"{i}</{Name}>");
            return stringBuilder.ToString();
        }
    }

    public class HtmlBuilder
    {
        private readonly string _rootName;
        HtmlElement root = new HtmlElement();
        public HtmlBuilder(string rootName)
        {
            _rootName = rootName;
            root.Name = _rootName;
        }
        public void AddChild(string childName, string text)
        {
            HtmlElement child = new HtmlElement(childName, text);
            root.Elements.Add(child);
        }
        public override string ToString()
        {
            return root.ToString();
        }
        public void Clear()
        {
            this.root = new HtmlElement{ Name = this._rootName};
        }
    }
}
