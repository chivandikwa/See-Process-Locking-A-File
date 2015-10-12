namespace SeeProcessesLockingAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var procs = FileLockInfoHelper.WhoIsLocking(@"");
        }
    }
}
