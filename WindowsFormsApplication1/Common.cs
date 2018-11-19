using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Common
    {
        public static bool Check(string project)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(project, @"\d\d\d\d$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //チケット番号チェック
        public static bool ticketNum(string チケット番号)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(チケット番号, @"^#\d\d\d\d|\d|$"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }



    }
}
