using DesignPattern.Lesson2_Factory;
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
            #region L1 Builder


            //Lesson1_Builder.HtmlBuilder.BadCode_Demo();
            //Lesson1_Builder.HtmlBuilder.GoodCode_Demo();
            //Lesson1_Builder.PersonBuilder.Demo();


            #endregion
            #region L2 Factory


            Lesson2_Factory.ProductFactory.Demo();


            #endregion
        }
    }
}
