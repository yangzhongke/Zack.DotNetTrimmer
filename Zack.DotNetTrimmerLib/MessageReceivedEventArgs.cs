namespace Zack.DotNetTrimmerLib
{
    public class MessageReceivedEventArgs : EventArgs
    {
        public string Message { get; private set; }
        public MessageReceivedEventArgs(string msg)
        {
            Message = msg;
        }
    }
}
