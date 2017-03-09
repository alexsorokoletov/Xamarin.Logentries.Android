namespace Logentries.Android
{
    public partial class AndroidLogger
    {
        public static AndroidLogger CreateInstance(string token, bool useSsl = true, bool useHttpPost = false, bool logHostName = false)
        {
            return AndroidLogger.CreateInstance(global::Android.App.Application.Context.ApplicationContext, useHttpPost, useSsl, false, null, 0, token, logHostName);
        }
    }
}
