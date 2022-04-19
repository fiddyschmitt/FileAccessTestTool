using System;
using System.Collections.Generic;
using System.Linq;
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
                                    .Select(filename => File.OpenRead(filename))
                                    .ToList();

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
    }
}
