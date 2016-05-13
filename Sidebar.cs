using Janus.Windows.Ribbon;
using MYOB.CSS;
using MYOB.CSSInterface;
using System.Diagnostics;


namespace Plugin
{
    public class Sidebar : CSSTabSideBarItems
    {
        public override SideBarGroup[] AddItems()
        {
            SideBarGroup[] sbgs = new SideBarGroup[1];
            sbgs[0] = new SideBarGroup();
            sbgs[0].Name = "Forum";
            sbgs[0].Add("Home Page", 0, OpenForumHomePage, Central.Icons.IconLibrary.Support(), CommandSizeStyle.Large, "F");
            sbgs[0].Add("Login", 1, LoginToForum, Central.Icons.IconLibrary.Support(), CommandSizeStyle.Large, "U");        
            return sbgs;
        }

        public override AvailableArea Area
        {
            get { return AvailableArea.HomePage; }
        }

        private void OpenForumHomePage(object sender, SideBarEventArgs e)
        {
            string url = "http://localhost:9666/";

            OpenForumPage(url);

            //Process.Start("http://localhost:9666/");
        }

        private void LoginToForum(object sender, SideBarEventArgs e)
        {
            string url1 = "http://localhost:9666/members/logon/";
            string url2 = "http://localhost:9666/members/logon/admin/password";
            
            OpenForumPage(url2);

            //Process.Start("http://localhost:9666/members/logon/?UserName=admin&Password=password");
        }


        private void OpenForumPage(string url)
        {
            Forum form = new Forum();
            form.Url = url;
            CssContext.Instance.Host.Register(form);
        }
    }
}