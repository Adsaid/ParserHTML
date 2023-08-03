using HtmlAgilityPack;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ParserHTML
{
    public static class Pars
    {

        public static string Parser(string link, string titlePath,string pricePath)
        {
            string text = " ";
            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = web.Load(link);
            HtmlNodeCollection qttitle = null;
            HtmlNodeCollection qtprice = null;

            Parallel.Invoke(
                () =>
                {
                    HtmlNodeCollection htmlNodeCollection = document.DocumentNode.SelectNodes(titlePath);
                    qttitle = htmlNodeCollection;
                },
                () =>
                {
                    HtmlNodeCollection htmlNodeCollection = document.DocumentNode.SelectNodes(pricePath);
                    qtprice = htmlNodeCollection;
                }
            );

            if (qtprice != null && qttitle != null)
            {
                int g = 1;

                var listdata = qttitle.ToList().Zip(qtprice.ToList(), (title, price) => title.InnerText + "|  Price " + price.InnerText.Replace("&nbsp;", " ") + Environment.NewLine);

                foreach (var item in listdata)
                {
                    text += Environment.NewLine + (g++) + ")" + item;
                }

                /*
                List<HtmlNode> list_tit = qttitle.ToList();
                List<HtmlNode> list_qt = qtprice.ToList();
                for (int item = 0; item < list_tit.Count; item++)
                {
                    HtmlNode i_tit = list_tit[item];
                    HtmlNode i_qt = list_qt[item];
                    g++;
                    text += "\r\n" + g + ")" + i_tit.InnerText + "|  Price " + i_qt.InnerText.Replace("&nbsp;", " ") + "\r\n";
                }
                */

            }
            else
                text = "Невдалося спарсити данну сторінку !";
            
            return text;
        }

    }
}
