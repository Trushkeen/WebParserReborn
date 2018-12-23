using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebParserReborn
{
    static class Program
    {
        public class Filename
        {
            public static string history = "history.txt";
            public static string clearedHtml = "clearHTML.txt";
            public static string html = "html.txt";
        }
        public class Filter
        {
            public Filter() { }
            public int selectAutoMethod()
            {
                int[] methods = new int[3];
                int minIndex;
                string html = File.ReadAllText(Filename.html);
                methods[0] = html.IndexOf("<string>");
                methods[1] = html.IndexOf("<br>");
                methods[2] = html.IndexOf("header");
                minIndex = methods[0];
                for (int i = 0; i < 2; i++)
                {
                    if (methods[i] < 0)
                    {
                        methods[i] = 0;
                    }
                    if (methods[i + 1] <= methods[i])
                    {
                        minIndex = i;
                    }
                }
                if (minIndex == 2)
                {
                    minIndex = 1;
                }
                else if (minIndex == 1)
                {
                    minIndex = 2;
                }
                return minIndex+1;
            }
            public void clearMethod1()
            {
                int startIndex, endIndex;
                string html = File.ReadAllText(Filename.html);
                try
                {
                    while (html.Contains("<script"))
                    {
                        startIndex = html.IndexOf("<script");
                        endIndex = html.IndexOf("</script>");
                        if (endIndex < startIndex)
                        {
                            int temp = startIndex;
                            endIndex = startIndex;
                            startIndex = temp;
                        }
                        html = html.Remove(startIndex, endIndex - startIndex + 9);
                    }
                }
                catch (Exception) { }
                File.WriteAllText(Filename.clearedHtml, html);
            }
            public void clearMethod2()
            {
                int startIndex, endIndex;
                string html = File.ReadAllText(Filename.html);
                try
                {
                    endIndex = html.IndexOf("<br>");
                    startIndex = endIndex - endIndex;
                    html = html.Remove(startIndex, endIndex);
                    while (html.Contains("<br>"))
                    {
                        endIndex = html.IndexOf("<br>");
                        html = html.Remove(endIndex, 4);
                    }
                    endIndex = html.IndexOf("</div>", endIndex);
                    html = html.Remove(endIndex);
                }
                catch (Exception) { }
                File.WriteAllText(Filename.clearedHtml, html);
            }
            public void clearMethod3()
            {
                string html = File.ReadAllText(Filename.html);
                int removeIndex = html.IndexOf("footer");
                html = html.Remove(removeIndex);
                removeIndex = html.IndexOf("header");
                try
                {
                    html = html.Insert(removeIndex - 1, "<");
                    html = html.Remove(0, removeIndex);
                }
                catch (Exception) { }
                if (html.Contains("function("))
                {
                    removeIndex = html.IndexOf("function(");
                    html = html.Remove(removeIndex - 1);
                }
                File.WriteAllText(Filename.clearedHtml, html);
            }
            public void postClear()
            {
                string html = File.ReadAllText(Filename.clearedHtml);
                int startIndex, endIndex;
                while (html.Contains("&nbsp;"))
                {
                    html = html.Replace("&nbsp;", " ");
                }
                while (html.Contains("&#160;"))
                {
                    html = html.Replace("&#160;", " ");
                }
                while (html.Contains("&#"))
                {
                    html = html.Replace("&#32;", " ");
                    html = html.Replace("&#91;", " ");
                    html = html.Replace("&#93;", " ");
                    html = html.Replace("&#59;", " ");
                    html = html.Replace("&#", " ");
                }
                while (html.Contains("Источник —"))
                {
                    int index = html.IndexOf("Источник —");
                    html = html.Remove(index);
                }
                while (html.Contains("</div>"))
                {
                    html = html.Replace("</div>", " ");
                }
                while (html.Contains("\n\n"))
                {
                    html = html.Replace("\n\n", "\n");
                }
                try
                {
                    while (html.Contains("<")) //удаление остатков хтмл
                    {
                        startIndex = html.IndexOf("<"); //находим индексы тегов
                        endIndex = html.IndexOf(">");
                        html = html.Insert(endIndex + 1, " "); //после закрытия тега вставляем пробел
                        if (endIndex < startIndex)
                        {
                            endIndex = startIndex + 1; //если закрывающий тег не там, где надо
                        }
                        html = html.Remove(startIndex, endIndex - startIndex + 1);
                    }
                }
                catch (Exception) { }
                File.WriteAllText(Filename.clearedHtml, html);
            }
        }
        public class Saver
        {
            public void save_doc()
            {
                Document document = new Document();
                Paragraph paragraph = document.AddSection().AddParagraph();
                string html = File.ReadAllText(Filename.clearedHtml);
                paragraph.AppendText(html);
                try
                {
                    string date = Convert.ToString(DateTime.Now);
                    while (date.Contains(":"))
                    {
                        date = date.Replace(":", "-");
                    }
                    string filename = "Saved Article " + date + ".doc";
                    document.SaveToFile(filename, FileFormat.Doc);
                    System.Diagnostics.Process.Start(filename);
                }
                catch (Exception) { }
            }
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
