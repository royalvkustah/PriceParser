using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Net;
using CsQuery;


namespace PriceParser
{
    class Updater
    {

        public string Update(string url)
        {
            WebClient wc = new WebClient();
            string Responte = wc.DownloadString(url);
            int num = Responte.IndexOf("$");
            int numb2 = Responte.IndexOf("%",num);
            string persent = Responte.Substring(numb2-5, 6);
            if ((persent[0] != '+')&&(persent[0] != '-'))
            {
                persent = Responte.Substring(numb2 - 6, 7);
            }
            string price = Responte.Substring(num+1,8);
            string res = price + "$_________" + persent;
            return res;
            // return "цена равна: "+Rate+" $";
        }


    }
}
