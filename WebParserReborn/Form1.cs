using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using HtmlAgilityPack;
using Spire.Doc;
using Spire.Doc.Documents;
using System.Diagnostics;
using static WebParserReborn.Program;

namespace WebParserReborn
{
    public partial class Form1 : Form
    {
        int method = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void advancedMode_CheckedChanged(object sender, EventArgs e)
        {
            if (advancedMode.Checked)
            {
                this.Height = 210;
                autoBtn.Visible = false;
            }
            else
            {
                this.Height = 150;
                autoBtn.Visible = true;
            }
        }

        private void parseBtn_Click(object sender, EventArgs e)
        {
            Parse();
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearHTML();
        }
        private void autoBtn_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            timer.Reset();
            timer.Start();
            Parse();
            if (statusLabel.Text == "Адрес не введен") { }
            else if (statusLabel.Text == "Адрес введен некорректно") { }
            else { clearHTML(); }
            timer.Stop();
            timerLabel.Text = Convert.ToString(timer.Elapsed);
        }
        private void clearHTML()
        {
            Stopwatch timer = new Stopwatch();
            timer.Reset();
            timer.Start();
            Filter filter = new Filter();
            Saver web = new Saver();
            if (method == 0) method = filter.selectAutoMethod();
            if (method == 1) filter.clearMethod1(); //чистка, которая сначала убирает скрипты (хорошо на вики)
            if (method == 2) filter.clearMethod2(); //чистка, которая проходится по br-кам и отрезает лишнее
            if (method == 3) filter.clearMethod3(); //чистка; убирает футеры и хедеры
            filter.postClear();
            web.save_doc();
            timer.Stop();
            timerLabel.Text = Convert.ToString(timer.Elapsed);
        }
        public string Txt(string web)
        {
            string title = web;
            title = title.Replace("<title>", "");
            title = title.Replace("</title>", "");
            File.WriteAllText(Filename.html, title);
            return title;
        }
        private void addToHistory()
        {
            if (!File.Exists(Filename.history)) { File.WriteAllText(Filename.history, ""); }
            string history = File.ReadAllText(Filename.history);
            if (history.Contains(linkBox.Text)) { }
            else
            {
                File.AppendAllText(Filename.history, linkBox.Text + "\r\n");
            }
        }
        private void Parse()
        {
            Stopwatch timer = new Stopwatch();
            timer.Reset();
            timer.Start();
            var html = linkBox.Text;
            if (linkBox.Text.Length == 0)
            {
                statusLabel.Text = "Адрес не введен";
            }
            else if (!linkBox.Text.Contains("http"))
            {
                statusLabel.Text = "Адрес введен некорректно";
            }
            else
            {
                addToHistory();
                parseBtn.Enabled = false;
                HtmlWeb web = new HtmlWeb();
                string title;
                try
                {
                    var htmlDoc = web.Load(html);
                    var node = htmlDoc.DocumentNode.SelectSingleNode("//body");
                    title = Convert.ToString(node.OuterHtml);
                    title = Txt(title);
                }
                catch (Exception)
                {
                    statusLabel.Text = "Не удалось выполнить по указанному адресу";
                }
                parseBtn.Enabled = true;
                statusLabel.Text = "Выполнение завершено";
                timerLabel.Text = "Типо время";
            }
            timer.Stop();
            timerLabel.Text = Convert.ToString(timer.Elapsed);
        }
        private void method2_CheckedChanged_1(object sender, EventArgs e)
        {
            method = 1;
        }
        private void method1_CheckedChanged_1(object sender, EventArgs e)
        {
            method = 2;
        }
        private void method3_CheckedChanged_1(object sender, EventArgs e)
        {
            method = 3;
        }
        private void autoRadioBtn1_CheckedChanged(object sender, EventArgs e)
        {
            Filter automizer = new Filter();
            method = automizer.selectAutoMethod();
        }
        private void showHistory_Click(object sender, EventArgs e)
        {
            Form2 history = new Form2();
            history.Show();
        }

        private void clearLinkBox_Click(object sender, EventArgs e)
        {
            linkBox.Text = "";
        }
    }
}
