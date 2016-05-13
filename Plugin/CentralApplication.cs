using MYOB.CSS;

namespace Plugin
{
    public class CentralApplication : CSSApplication
    {
        /// <summary>
        /// Gets the copyright text for the Help | About screen.
        /// </summary>
        public override string CopyrightText
        {
            get { return "Copyright © 2016 CCH Software"; }
        }

        /// <summary>
        /// Gets the product version for the Help | About screen.
        /// </summary>
        public override string ProductVersion
        {
            get { return "1.0"; }
        }
    }
}
