using MYOB.CSSInterface;

namespace Plugin
{
    public class FormFactory<T> : FrameworkForm
    {
        /// <summary>
        /// Despite the property name this gets the namespace of the class containing the form.
        /// </summary>
        protected override string AssemblyName
        {
            get { return typeof(T).Namespace; }
        }

        /// <summary>
        /// Gets the class name of the form.
        /// </summary>
        protected override string ClassName
        {
            get { return typeof(T).Name; }
        }
    }


    public class Forum : FormFactory<ForumForm>
    {
        public string Url { get; set; }
    }
}
