using DesignPattern.Lesson1_Builder;
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
            //HtmlBuilder.BadCode_Demo();
            //HtmlBuilder.GoodCode_Demo();

            PersonJobBuilder<Person.Builder> p = Person.New.Called("John");
            Console.WriteLine(p);
            Console.ReadLine();
        }
    }
}
