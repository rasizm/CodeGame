using Solution6.VPM.Client.UIHelperClasses;
using System;
using System.Drawing;

public class ForumHomePage : MYOB.CSSInterface.HomePageItem
{    
    #region " Windows Form Designer generated code "


    private string mURL;
    public ForumHomePage() : base()
    {

        //This call is required by the Windows Form Designer.
        InitializeComponent();

    }


    //UserControl overrides dispose to clean up the component list.
    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            //To address issue: http://support.microsoft.com/kb/948838
            //NullReferenceException Occurs in Windows Forms Application Running on .NET Framework 2.0 Service Pack 1
            if ((AxWebBrowser1 != null))
            {
                System.Reflection.FieldInfo fi = default(System.Reflection.FieldInfo);
                object o = null;
                fi = typeof(System.Windows.Forms.AxHost).GetField("oleSite", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                o = fi.GetValue(AxWebBrowser1);
                GC.SuppressFinalize(o);
            }
            if ((components != null))
            {
                components.Dispose();
            }
        }
        base.Dispose(disposing);
    }

    //Required by the Windows Form Designer

    private System.ComponentModel.IContainer components;
    //NOTE: The following procedure is required by the Windows Form Designer
    //It can be modified using the Windows Form Designer.  
    //Do not modify it using the code editor.
    internal System.Windows.Forms.Panel pnlNavBar;
    private System.Windows.Forms.TextBox withEventsField_txtURL;
    internal System.Windows.Forms.TextBox txtURL
    {
        get { return withEventsField_txtURL; }
        set
        {
            if (withEventsField_txtURL != null)
            {
                withEventsField_txtURL.KeyDown -= txtURL_KeyDown;
            }
            withEventsField_txtURL = value;
            if (withEventsField_txtURL != null)
            {
                withEventsField_txtURL.KeyDown += txtURL_KeyDown;
            }
        }
    }
    private AxSHDocVw.AxWebBrowser withEventsField_AxWebBrowser1;
    internal AxSHDocVw.AxWebBrowser AxWebBrowser1
    {
        get { return withEventsField_AxWebBrowser1; }
        set
        {
            if (withEventsField_AxWebBrowser1 != null)
            {
                withEventsField_AxWebBrowser1.NavigateComplete2 -= AxWebBrowser1_NavigateComplete2;
            }
            withEventsField_AxWebBrowser1 = value;
            if (withEventsField_AxWebBrowser1 != null)
            {
                withEventsField_AxWebBrowser1.NavigateComplete2 += AxWebBrowser1_NavigateComplete2;
            }
        }
    }
    private System.Windows.Forms.Button withEventsField_cmdNavigate;
    internal System.Windows.Forms.Button cmdNavigate
    {
        get { return withEventsField_cmdNavigate; }
        set
        {
            if (withEventsField_cmdNavigate != null)
            {
                withEventsField_cmdNavigate.Click -= cmdNavigate_Click;
            }
            withEventsField_cmdNavigate = value;
            if (withEventsField_cmdNavigate != null)
            {
                withEventsField_cmdNavigate.Click += cmdNavigate_Click;
            }
        }
    }
    [System.Diagnostics.DebuggerStepThrough()]
    private void InitializeComponent()
    {
        System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ForumHomePage));
        this.pnlNavBar = new System.Windows.Forms.Panel();
        this.cmdNavigate = new System.Windows.Forms.Button();
        this.txtURL = new System.Windows.Forms.TextBox();
        this.AxWebBrowser1 = new AxSHDocVw.AxWebBrowser();
        this.pnlNavBar.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.AxWebBrowser1).BeginInit();
        this.SuspendLayout();
        //
        //pnlNavBar
        //
        this.pnlNavBar.Controls.Add(this.cmdNavigate);
        this.pnlNavBar.Controls.Add(this.txtURL);
        this.pnlNavBar.Dock = System.Windows.Forms.DockStyle.Top;
        this.pnlNavBar.Location = new System.Drawing.Point(0, 0);
        this.pnlNavBar.Name = "pnlNavBar";
        this.pnlNavBar.Size = new System.Drawing.Size(688, 20);
        this.pnlNavBar.TabIndex = 13;
        //
        //cmdNavigate
        //
        this.cmdNavigate.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
        this.cmdNavigate.Image = (System.Drawing.Image)resources.GetObject("cmdNavigate.Image");
        this.cmdNavigate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.cmdNavigate.Location = new System.Drawing.Point(624, 0);
        this.cmdNavigate.Name = "cmdNavigate";
        this.cmdNavigate.Size = new System.Drawing.Size(40, 20);
        this.cmdNavigate.TabIndex = 14;
        this.cmdNavigate.Text = "Go";
        this.cmdNavigate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        //
        //txtURL
        //
        this.txtURL.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
        this.txtURL.Location = new System.Drawing.Point(0, 0);
        this.txtURL.Name = "txtURL";
        this.txtURL.Size = new System.Drawing.Size(624, 20);
        this.txtURL.TabIndex = 13;
        this.txtURL.Text = "";
        //
        //AxWebBrowser1
        //
        this.AxWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.AxWebBrowser1.Enabled = true;
        this.AxWebBrowser1.Location = new System.Drawing.Point(0, 20);
        this.AxWebBrowser1.OcxState = (System.Windows.Forms.AxHost.State)resources.GetObject("AxWebBrowser1.OcxState");
        this.AxWebBrowser1.Size = new System.Drawing.Size(688, 124);
        this.AxWebBrowser1.TabIndex = 14;
        //
        //WebBrowser
        //
        this.BackColor = System.Drawing.SystemColors.Control;
        this.Controls.Add(this.AxWebBrowser1);
        this.Controls.Add(this.pnlNavBar);
        this.Name = "WebBrowser";
        this.Size = new System.Drawing.Size(688, 124);
        this.ToolBoxImage = (System.Drawing.Bitmap)resources.GetObject("$this.ToolBoxImage");
        this.ToolBoxSequence = 5;
        this.Controls.SetChildIndex(this.pnlNavBar, 0);
        this.Controls.SetChildIndex(this.AxWebBrowser1, 0);
        this.pnlNavBar.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)this.AxWebBrowser1).EndInit();
        this.ResumeLayout(false);

    }

    #endregion
    
    public override void LoadData(bool Cache, bool StartNewThread)
    {
        if (Cache == false)
        {
            AxWebBrowser1.Navigate(mURL);            
        }
    }
    public override bool Customise
    {
        get { return base.Customise; }
        set
        {
            base.Customise = value;

            if (value)
            {
                this.DockPadding.All = 8;
                pnlNavBar.Visible = true;

            }
            else
            {
                this.DockPadding.All = 0;
                pnlNavBar.Visible = false;
            }
        }
    }

    public void Navigate(string url)
    {
        FormatScreen(url);
    }


    private void cmdNavigate_Click(System.Object sender, System.EventArgs e)
    {
        mURL = txtURL.Text;
        LoadData(false, false);
    }

    public override void SaveCustomisation(System.Xml.XmlTextWriter XW)
    {
        XW.WriteAttributeString("BrowserURL", mURL);
    }

    private void AxWebBrowser1_NavigateComplete2(object sender, AxSHDocVw.DWebBrowserEvents2_NavigateComplete2Event e)
    {
        txtURL.Text = AxWebBrowser1.LocationURL;
        mURL = AxWebBrowser1.LocationURL;
    }



    private void txtURL_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
    {
        if (e.KeyCode == System.Windows.Forms.Keys.Enter)
        {
            mURL = txtURL.Text;
            LoadData(false, false);
        }
    }

    public override System.Drawing.Size InitialSize
    {
        get { return new Size(400, 200); }
    }


    public override void DefaultSettings()
    {
        FormatScreen("localhost:9666/members/logon/");
    }

    public override void RestoreCustomisation(System.Xml.XmlElement Customisation)
    {
        string URL = null;
        try
        {
            URL = Customisation.Attributes["BrowserURL"].Value;
        }
        catch
        {
            URL = "";
        }

        FormatScreen(URL);

    }

    private void FormatScreen(string URL)
    {
        if (string.IsNullOrEmpty(URL))
        {
            mURL = MYOB.Central.WS.WebServices.HomePage.GetBrowserURL(LocalSettings.ConnectionStringKey, LocalSettings.EmployeeID);
        }
        else
        {
            mURL = URL;
        }

        txtURL.Text = mURL;
    }

    public override string DisplayName
    {
        get { return "Web Browser"; }
    }

    public override string ApplicationName
    {
        get { return "Plugin"; }
    }

    public override System.Drawing.Bitmap ToolBoxGroupImage
    {
        get
        {
            System.Reflection.Assembly ass = System.Reflection.Assembly.GetExecutingAssembly();
            return (System.Drawing.Bitmap)System.Drawing.Image.FromStream(ass.GetManifestResourceStream("Plugin.no_CCH_red_Icon.png"));
        }
    }
}

