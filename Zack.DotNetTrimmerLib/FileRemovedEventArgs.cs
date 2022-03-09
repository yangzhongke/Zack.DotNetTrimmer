namespace Zack.DotNetTrimmerLib
{
    public class FileRemovedEventArgs : EventArgs
    {
        public string FileFullPath { get; private set; }
        public FileRemovedEventArgs(string fileFullPath)
        {
            FileFullPath = fileFullPath;
        }
    }
}
