using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FileAccessTestTool
{
    public class ReadTask
    {
        public ReadTask(IList<string> readFilenames, int threadNumber, int readSize, int sleepBetweenReadsMillis, CancellationToken readTaskCancellationToken)
        {
            ThreadNumber = threadNumber;

            var buffer = new byte[readSize];

            Task = Task.Factory.StartNew(() =>
            {
                try
                {
                    var streams = readFilenames
                                    //.Select(filename => File.OpenRead(filename))  //If this is used, the OS will cache the file in RAM (resulting in the file not being read).
                                    .Select(filename => new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 4096, FileFlagNoBuffering))  //This prevents caching. Only works for network files and not local files!
                                    .ToList();

                    //Todo: Make it work for local files by satisfying the alignment and file access requirements listed here:
                    //https://docs.microsoft.com/en-au/windows/win32/fileio/file-buffering?redirectedfrom=MSDN

                    while (!readTaskCancellationToken.IsCancellationRequested)
                    {
                        var randomStream = streams[Form1.Random.Next(0, streams.Count)];

                        var randomPosition = Form1.Random.NextInt64(0, randomStream.Length);
                        randomStream.Seek(randomPosition, SeekOrigin.Begin);

                        var bytesActuallyRead = (ulong)randomStream.Read(buffer, 0, buffer.Length);

                        TotalBytesRead += bytesActuallyRead;

                        if (sleepBetweenReadsMillis > 0)
                        {
                            Thread.Sleep(sleepBetweenReadsMillis);
                        }
                    }
                }
                catch (Exception ex)
                {
                    ErrorEncountered = ex.Message;
                }
            }, TaskCreationOptions.LongRunning);
        }

        public int ThreadNumber { get; }
        public Task Task { get; }
        public ulong TotalBytesRead { get; protected set; }
        public string? ErrorEncountered { get; protected set; }

        const FileOptions FileFlagNoBuffering = (FileOptions)0x20000000;
    }
}
