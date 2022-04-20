namespace FileAccessTestTool
{
    public partial class Form1 : Form
    {
        static string PROGRAM_NAME = "File Access Test Tool";
        static string PROGRAM_VERSION = "1.0.1";

        public Form1()
        {
            InitializeComponent();

            Text = $"{PROGRAM_NAME} {PROGRAM_VERSION}";
        }

        Task? aggregateReadTask = null;
        CancellationTokenSource readTaskCancellationToken = new();
        public static readonly Random Random = new Random();

        private void btnStartRead_Click(object sender, EventArgs e)
        {
            if (btnStartRead.Text.Equals("Stop"))
            {
                if (aggregateReadTask != null)
                {
                    readTaskCancellationToken.Cancel();
                    aggregateReadTask.Wait();
                }

                btnStartRead.Text = "Start";

                return;
            }

            btnStartRead.Text = "Stop";
            tableLayoutPanel1.Controls.Clear();
            readTaskCancellationToken = new();

            var threadCount = int.Parse(txtReadThreads.Text);
            var readSize = int.Parse(txtReadSize.Text.Replace(",", ""));
            var sleepBetweenReadsMillis = int.Parse(txtSleepBetweenReadsMillis.Text);
            var readFilenames = txtReadFilenames
                                    .Lines
                                    .Select(line => line.Replace("\"", ""))
                                    .ToArray();

            var progresses = new Dictionary<ReadTask, (Label BytesReadLabel, Label ErrorLabel)>();

            aggregateReadTask = Task.Factory.StartNew(() =>
            {
                var readTasks = Enumerable
                                    .Range(0, threadCount)
                                    .Select(threadNumber => new ReadTask(readFilenames, threadNumber, readSize, sleepBetweenReadsMillis, readTaskCancellationToken.Token))
                                    .ToList();

                Invoke(() =>
                {
                    tableLayoutPanel1.SuspendLayout();
                });

                var row = 0;
                readTasks
                    .ForEach(readTask =>
                    {
                        var threadNameLabel = new Label
                        {
                            Text = $"Thread {readTask.ThreadNumber}",
                            AutoSize = true
                        };

                        var bytesReadLabel = new Label
                        {
                            Text = $"Read {Utility.FormatSize(readTask.TotalBytesRead)}",
                            AutoSize = true
                        };

                        var errorLabel = new Label
                        {
                            Text = $"",
                            AutoSize = true
                        };

                        Invoke(() =>
                        {
                            tableLayoutPanel1.Controls.Add(threadNameLabel, 0, row);
                            tableLayoutPanel1.Controls.Add(bytesReadLabel, 1, row);
                            tableLayoutPanel1.Controls.Add(errorLabel, 2, row);
                        });

                        row++;

                        progresses[readTask] = (bytesReadLabel, errorLabel);
                    });

                Invoke(() =>
                {
                    tableLayoutPanel1.ResumeLayout();
                });

                var progressThread = new Thread(new ThreadStart(() =>
                {
                    while (!readTaskCancellationToken.IsCancellationRequested)
                    {
                        tableLayoutPanel1.SuspendLayout();

                        progresses
                            .ToList()
                            .ForEach(kvp =>
                            {
                                Invoke(() =>
                                {
                                    kvp.Value.BytesReadLabel.Text = $"Read {Utility.FormatSize(kvp.Key.TotalBytesRead)}";
                                    kvp.Value.ErrorLabel.Text = kvp.Key.ErrorEncountered;
                                });
                            });

                        Invoke(() =>
                        {
                            tableLayoutPanel1.ResumeLayout();
                        });

                        Thread.Sleep(1000);
                        Application.DoEvents();
                    }
                }));
                progressThread.IsBackground = true;
                progressThread.Start();

                var allTasks = readTasks
                                .Select(rt => rt.Task)
                                .ToArray();

                Task.WaitAll(allTasks);
            });
        }

        /*
        public void Log(string str)
        {
            var logEntry = $"{DateTime.Now:yyyy-MM-dd hh:mm:ss.fff},{str}";
            Invoke(() =>
            {
                if (txtLog.TextLength == 0)
                {
                    txtLog.Text = logEntry;
                }
                else
                {
                    txtLog.Text = $"{logEntry}{Environment.NewLine}{txtLog.Text}";
                }
            });
        }
        */
    }
}