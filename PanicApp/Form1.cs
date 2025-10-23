using System.Media;
using System.Diagnostics;
using System.Linq.Expressions;

namespace PanicApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            button1.Location = new Point(
                (this.ClientSize.Width - button1.Width) / 2,
                (this.ClientSize.Height - button1.Height) / 2
            );
        }

        public void LoadRunningPrograms()
        {
            programsListBox.Items.Clear();
            // Input list of all running processes into the listBox

            Process[] processes = Process.GetProcesses();

            foreach(Process i in processes)
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
            Debug.WriteLine(programsListBox.SelectedIndices[0].ToString());
            MessageBox.Show("Text message");
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
