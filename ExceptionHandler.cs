using System;
using System.Reflection;
using System.Windows.Forms;

namespace Plugin
{
    /// <summary>
    /// A static class that wraps the default exception handling for the application.
    /// </summary>
    public static class ExceptionHandler
    {
        #region Central exception form fields
        // Information about the exception form gleaned via reflection.
        static Type _ExceptionFormType;
        static MethodInfo _ShowDialogMethod;
        static Exception _LoadFormException;
        #endregion

        #region Process
        /// <summary>
        /// Performs the default action for exceptions we don't explicitly cope with.
        /// </summary>
        /// <param name="ex"></param>
        /// <remarks>
        /// <para>
        /// Central rather unfortunately will swallow unhandled exceptions, so we are forced to handle
        /// all of them. This method performs the default action for what would otherwise be an unhandled
        /// exception. At the time of writing this displays Central's standard exception dialog but in
        /// the future if Central stops swallowing exceptions we can change this to be a simple "throw;".
        /// </para><para>
        /// The DLL holding the common Central exception dialog is not signed, but all of our stuff
        /// is. We can't call it directly so it's loaded and called via reflection instead. This can
        /// mean that a failure to load the Central DLL will itself raise an exception, which will
        /// then go through to Central's default exception handler to be swallowed. There is not a
        /// great deal we can do about that but to make it clear that it's happened we try to display
        /// a message box.
        /// </para></remarks>
        public static void Process(Exception ex)
        {
            if(ex != null) {
                if(_ExceptionFormType == null) LoadCentralExceptionForm();

                if(_ExceptionFormType != null) {
                    // We can legitimately be asked to report a null exception - silently ignore nulls...
                    if(ex != null) {
                        // Show them Central's dialog
                        using(IDisposable centralExceptionDialog = (IDisposable)Activator.CreateInstance(_ExceptionFormType, ex)) {
                            _ShowDialogMethod.Invoke(centralExceptionDialog, null);
                        }
                    }
                } else if(_LoadFormException != null) {
                    MessageBox.Show(String.Format("Exception caught but cannot load the Central exception handler ({0}). Details are: {1}", _LoadFormException.Message, ex.ToString()), "Exception Caught");
                } else {
                    MessageBox.Show(String.Format("Exception caught but cannot load the Central exception handler. Details are: {0}", ex.ToString()), "Exception Caught");
                }
            }
        }

        static void LoadCentralExceptionForm()
        {
            try {
                Assembly uiHelperClasses = Assembly.LoadFrom("UIHelperClasses.dll");
                _ExceptionFormType = uiHelperClasses.GetType("Solution6.VPM.Client.UIHelperClasses.frmDisplayException");
                _ShowDialogMethod = _ExceptionFormType.GetMethod("ShowDialog", new Type[]{});
            } catch(Exception ex) {
                _LoadFormException= ex;
            }
        }
        #endregion
    }
}
