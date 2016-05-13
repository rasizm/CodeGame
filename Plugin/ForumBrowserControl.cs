using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plugin
{
    public partial class ForumBrowserControl : UserControl
    {
        public ForumBrowserControl()
        {
            InitializeComponent();
        }
        
        public void Navigate(string url)
        {
            webBrowser1.Navigate(url);
        }
    }
}
