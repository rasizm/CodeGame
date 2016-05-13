using MYOB.CSSInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Plugin
{
    public partial class ForumForm : Form, ICSSDisplayMainArea
    {
        public string Url { get; set; }

        public ForumForm(Forum form)
        {
            Url = form.Url;
            InitializeComponent();
        }

        #region ICSSDisplayMainArea Members
        public void CloseForm(object sender, CSSCancelEventArgs e)
        {
            CloseForm();
        }

        public int CollectionID { get; set; }

        public SideBarGroups Register()
        {
            Show();
            return new SideBarGroups("");
        }

        public void CloseForm(object sender, EventArgs e)
        {
            try
            {
                CloseForm();
            }
            catch (Exception ex)
            {
                ExceptionHandler.Process(ex);
            }
        }

        public void RefreshHandler(object sender, EventArgs e)
        {
            try
            {
                ReloadForum();
            }
            catch (Exception ex)
            {
                ExceptionHandler.Process(ex);
            }
        }      
        #endregion

        #region CloseForm
        private void CloseForm()
        {
            Close();
        }
        #endregion

        private void ReloadForum()
        {
            forumBrowserControl1.Navigate(Url);
        }

        protected override void OnLoad(EventArgs e)
        {
            try
            {
                base.OnLoad(e);
                ReloadForum();
            }
            catch (Exception ex)
            {
                ExceptionHandler.Process(ex);
            }
        }
    }
}
