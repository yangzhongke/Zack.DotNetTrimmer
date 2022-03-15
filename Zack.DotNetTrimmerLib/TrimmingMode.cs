namespace Zack.DotNetTrimmerLib
{
    public enum TrimmingMode
    {
        /// <summary>
        /// Append the activities to a file which would be used for trimming in the mode of Load
        /// </summary>
        Record,
        /// <summary>
        /// Load a file contains activities and trim the application
        /// </summary>
        Apply,
        /// <summary>
        /// check the unused assebemblies and delete them in one go
        /// </summary>
        Direct
    }
}
