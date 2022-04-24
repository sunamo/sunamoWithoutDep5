namespace SunamoExceptions
{
    public class ThisApp
    {

        static bool _async_ = false;
        /// <summary>
        /// Use everywhere is method without / with Async. Its needed due to avoid deadlock https://stackoverflow.com/a/65820543/9327173
        /// Good for example in ClipboardHelperWinStd. But when I'm changing headers of methods, I have to use #if ASYNC. Otherwise program can "froze" and due to async I cant debug where.
        /// </summary>
        public static bool async_
        {
            get => _async_;
            set => _async_ = value;
        }
    }
}