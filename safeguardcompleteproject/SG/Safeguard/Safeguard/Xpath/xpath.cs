using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safeguard.Xpath
{
    public class xpath
    {
        public static string selectproduct = ("//*[@id=\"productFamily\"]/option[2]"); 
        public static string selectproduct1 = ("//*[@id=\"productFamily\"]/option[3]");
        public static string selectproduct2 = ("//*[@id=\"productFamily\"]/option[4]");
        public static string modelname = (" //*[@id=\"productModel\"]/option[2]");//*[@id="productModel"]/option[3]
        public static string modelname2 = (" //*[@id=\"productModel\"]/option[3]");
        public static string modelname3 = (" //*[@id=\"productModel\"]/option[4]");
        public static string modelname4 = (" //*[@id=\"productModel\"]/option[5]");
        public static string selectproduct3 = ("//*[@id=\"productFamily\"]/option[5]");
        public static string modelname1 = (" //*[@id=\"productModel\"]/option[2]");

        public static string securecode = ("//input[@name='secureCode']");
        public static string lotcode = ("//input[@name='lotCode']");
        public static string checkbox = ("//input[@name='captcha']");
        public static string checkvalidate = ("//div[@class='btn btn-primary btn-lg']");
        public static string confirm = ("//button[normalize-space()='Confirm']");

        public static string changelang1 = ("//li[@id=\"jaJP\"]"); //*[@id="js-siteHd"]/div[2]/div[2]/ul/li/ul
        public static string changelang2 = ("//*[@id=\"frCA\"]");
        public static string changelang3 = ("//*[@id=\"ptBR\"]");
        public static string changelang4 = ("//*[@id=\"esmx\"]");
        public static string changelang5 = ("//*[@id=\"enUS\"]");
        public static string changelang6 = ("//*[@id=\"zhCN\"]");
    }
}
