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
using static WebParserReborn.Program;

namespace WebParserReborn
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            if(File.Exists(Filename.history))
            historyRtb.Text = File.ReadAllText(Filename.history);
        }

        private void clearHistory_Click(object sender, EventArgs e)
        {
            try
            {
                string history = File.ReadAllText(Filename.history);
                history = history.Remove(0);
                File.WriteAllText(Filename.history, history);
                historyRtb.Text = File.ReadAllText(Filename.history);
            }
            catch (Exception) { }
        }
    }
}
