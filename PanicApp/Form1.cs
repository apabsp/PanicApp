    using System.Media;
    using System.Diagnostics;
    using System.Linq.Expressions;
    using System.DirectoryServices;

    namespace PanicApp
    {
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            /*button1.Location = new Point(
                (this.ClientSize.Width - button1.Width) / 2,
                (this.ClientSize.Height - button1.Height) / 2
            );
            button2.Location = new Point(
                (this.ClientSize.Width - button2.Width) / 2,
                (this.ClientSize.Height - button2.Height) / 2
            );*/
        }

        Dictionary<string, Process> runningProcesses = new Dictionary<string, Process>();
        Dictionary<string, Process> processesToClose = new Dictionary<string, Process>();
        Dictionary<string, Process> processesToOpen = new Dictionary<string, Process>();

        // Try paths for opening programs
        Dictionary<string, string> programPathsToOpen = new Dictionary<string, string>();


        public void LoadRunningPrograms()
        {
            programsListBox.Items.Clear();
            // Input list of all running processes into the listBox

            Process[] processes = Process.GetProcesses();

            foreach (Process i in processes)
            {
                try
                {
                    // We don't want to get ALL processes, but only the ones that are visible

                    if (!string.IsNullOrEmpty(i.MainWindowTitle)) // taking method from .NET String class
                    {
                        programsListBox.Items.Add(i.MainWindowTitle);
                        runningProcesses[i.MainWindowTitle] = i;
                    }

                }

                catch
                {
                    Debug.WriteLine($" Not going into programsListBox: {i.MainWindowTitle}");
                }
            }


        }

        //This is the Button for closing windows.
        private void button1_Click(object sender, EventArgs e)
        {

            if (programsListToClose.Items.Count <= 0)
            {
                MessageBox.Show("Empty close windows list box.");
            }
            else
            {
                int closedCount = 0;

                foreach (var item in processesToClose)
                {
                    //MessageBox.Show(item.ToString());
                    string programName = item.ToString();

                    /* DialogResult result = MessageBox.Show(
                        $"Close this program?\n\n{programName}",
                        "Confirm Close",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    ); */

                    //if (result == DialogResult.Yes)
                    CloseProcess(item.Value);


                }

            }

            programsListToClose.Items.Clear();
            processesToClose.Clear();

        }

        private void CloseProcess(Process process)
        {
            process.CloseMainWindow();
            if (!process.WaitForExit(3000)) // to avoid zombies
            {
                process.Kill();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            //Console.WriteLine("button2 clicked!");
            //MessageBox.Show("button2 clicked!");
            LoadRunningPrograms();
            MessageBox.Show($"Loaded {programsListBox.Items.Count} programs!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (programsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a program first!");
                return;
            }

            string title = programsListBox.SelectedItem.ToString();

            if (processesToClose.ContainsKey(title))
            {
                return;
            }

            processesToClose.Add(title, runningProcesses[title]);
            programsListToClose.Items.Add(title);

        }

        private void programsListToClose_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void button4_Click(object sender, EventArgs e)
        {

            if (programsListToClose.SelectedItem == null)
            {
                MessageBox.Show("Click on the \"Programs to Close\" box item to select the item to be unadded.");
                return;
            }


            string title = programsListToClose.SelectedItem.ToString();
            if (processesToClose.ContainsKey(title))
            {
                processesToClose.Remove(title);
            }

            programsListToClose.Items.Remove(title);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        // Select path button for opening programs
        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Executable Files (*.exe)|*.exe|All Files (*.*)|*.*";
            openFileDialog.Title = "Select Program to Open";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string filePath in openFileDialog.FileNames)
                {
                    string displayName = Path.GetFileName(filePath);

                    if (!programPathsToOpen.ContainsKey(displayName))
                    {
                        programPathsToOpen.Add(displayName, filePath);
                        programsToOpenListBox.Items.Add(displayName);
                    }
                }
            }
        }

        private void runPathButton_Click(object sender, EventArgs e)
        {
            if (programPathsToOpen.Count == 0)
            {
                return;
            }
            int openedCount = 0;

            foreach (var item in programPathsToOpen)
            {
                try
                {
                    Process.Start(item.Value);
                    openedCount++;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to open {item.Key}: {ex.Message}");
                }
            }
        }
    }
}
