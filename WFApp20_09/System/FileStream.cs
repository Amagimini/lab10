using System.IO;

namespace System
{
    internal class FileStream : IO.FileStream
    {
        public FileStream(string path, FileMode mode, FileAccess access) : base(path, mode, access)
        {
        }
    }
}