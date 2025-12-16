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
                    }

                }

                catch
                {
                    Debug.WriteLine($" Not going into programsListBox: {i.MainWindowTitle}");
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (programsListBox.Items.Count <= 0)
            {
                foreach (var item in programsListToClose.Items)
                {
                    CloseProcessByWindowTitle(item.ToString());
                }
            }
            else
            {
                int closedCount = 0;

                foreach (var item in programsListToClose.Items)
                {
                    string programName = item.ToString();

                    /* DialogResult result = MessageBox.Show(
                        $"Close this program?\n\n{programName}",
                        "Confirm Close",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    ); */

                    //if (result == DialogResult.Yes)
                    CloseProcessByWindowTitle(programName);
                    closedCount++;

                }
            }
            ;
        }

        private void CloseProcessByWindowTitle(string windowTitle)
        {
            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                if (p.MainWindowTitle == windowTitle)
                {
                    p.CloseMainWindow(); // try p.Kill if doesn't work
                    break;
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine("button2 clicked!");
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

            //MessageBox.Show($"selected {programsListBox.SelectedItem.ToString()}");

            //Add to programs to CLOSE list

            if (programsListToClose.Items.Contains(programsListBox.SelectedItem))
            {

            }
            else
            {
                programsListToClose.Items.Add(programsListBox.SelectedItem);
            }
        }

        private void programsListToClose_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
