using System.Threading;

namespace WinForms_SideThread
{
    public partial class ThreadForm : Form
    {
        private CancellationTokenSource cancelTokenSource;
        private CancellationToken stopToken;
        private string? autoName;
        private Random random;
        private Task sideTask;
        public ThreadForm()
        {
            InitializeComponent();
            random = new Random();
            cancelTokenSource = new CancellationTokenSource();
            stopToken = cancelTokenSource.Token;
            sideTask = new Task(SleepAndInsert, stopToken);
            checkBox_Turn.Text = "Start";
        }

        private void checkBox_Turn_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Turn.Checked)
            {
                checkBox_Turn.Text = "Stop";
                cancelTokenSource = new CancellationTokenSource();
                stopToken = cancelTokenSource.Token;
                sideTask = new Task(SleepAndInsert, stopToken);
                sideTask.Start();
            }
            else
            {
                checkBox_Turn.Text = "Start";
                cancelTokenSource.Cancel();
                Thread.Sleep(1000);
                cancelTokenSource.Dispose();
            }

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            autoName = openFileDialog.FileName;
            Files.ReadFile(autoName);
            textBox_Main.Text = Files.Text;
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (autoName == null)
            {
                saveasToolStripMenuItem_Click(sender, e);
                return;
            }
            Files.WriteFile(textBox_Main.Text, autoName);
        }
        private void saveasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;
            string fileName = saveFileDialog.FileName;
            Files.WriteFile(textBox_Main.Text, fileName);
            textBox_Main.Text = Files.Text;
        }
        private void SleepAndInsert()
        {
            try
            {
                while (true)
                {
                    if (stopToken.IsCancellationRequested)
                        stopToken.ThrowIfCancellationRequested();
                    Thread.Sleep(500);
                    if (stopToken.IsCancellationRequested)
                        stopToken.ThrowIfCancellationRequested();
                    if (textBox_Main.InvokeRequired)
                    {
                        Action safeWrite = delegate { RandomInsert($"{textBox_Subline.Text}"); };
                        textBox_Main.Invoke(safeWrite);
                    }
                    else
                        RandomInsert(textBox_Subline.Text);
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("! : " + e.Message);
            }
        }
        private void RandomInsert(string subline)
        {
            int ind = random.Next(textBox_Main.Text.Length);
            textBox_Main.Text = textBox_Main.Text.Insert(ind, subline);
            textBox_Main.Refresh();
            
        }
    }
}