namespace PanicApp
{
    partial class MainForm    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            fontDialog1 = new FontDialog();
            programsListBox = new ListBox();
            button2 = new Button();
            label1 = new Label();
            programsListToClose = new ListBox();
            label2 = new Label();
            button3 = new Button();
            button4 = new Button();
            programsToOpenListBox = new ListBox();
            ProgramsToOpenLabel = new Label();
            button5 = new Button();
            runPathButton = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(276, 197);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(136, 67);
            button1.TabIndex = 0;
            button1.Text = "Close selected programs";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // programsListBox
            // 
            programsListBox.FormattingEnabled = true;
            programsListBox.ItemHeight = 15;
            programsListBox.Location = new Point(276, 44);
            programsListBox.Margin = new Padding(3, 2, 3, 2);
            programsListBox.Name = "programsListBox";
            programsListBox.Size = new Size(132, 79);
            programsListBox.TabIndex = 1;
            programsListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(423, 44);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(96, 39);
            button2.TabIndex = 2;
            button2.Text = "Load running programs";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(260, 26);
            label1.Name = "label1";
            label1.Size = new Size(153, 15);
            label1.TabIndex = 3;
            label1.Text = "Programs currently running";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // programsListToClose
            // 
            programsListToClose.FormattingEnabled = true;
            programsListToClose.ItemHeight = 15;
            programsListToClose.Location = new Point(31, 142);
            programsListToClose.Margin = new Padding(3, 2, 3, 2);
            programsListToClose.Name = "programsListToClose";
            programsListToClose.Size = new Size(132, 79);
            programsListToClose.TabIndex = 4;
            programsListToClose.SelectedIndexChanged += programsListToClose_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 125);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 5;
            label2.Text = "Programs to close";
            // 
            // button3
            // 
            button3.Location = new Point(423, 100);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(41, 22);
            button3.TabIndex = 6;
            button3.Text = "+";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(486, 101);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(32, 20);
            button4.TabIndex = 7;
            button4.Text = "-";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // programsToOpenListBox
            // 
            programsToOpenListBox.FormattingEnabled = true;
            programsToOpenListBox.ItemHeight = 15;
            programsToOpenListBox.Location = new Point(479, 142);
            programsToOpenListBox.Margin = new Padding(3, 2, 3, 2);
            programsToOpenListBox.Name = "programsToOpenListBox";
            programsToOpenListBox.Size = new Size(132, 79);
            programsToOpenListBox.TabIndex = 8;
            programsToOpenListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // ProgramsToOpenLabel
            // 
            ProgramsToOpenLabel.AutoSize = true;
            ProgramsToOpenLabel.Location = new Point(486, 125);
            ProgramsToOpenLabel.Name = "ProgramsToOpenLabel";
            ProgramsToOpenLabel.Size = new Size(104, 15);
            ProgramsToOpenLabel.TabIndex = 9;
            ProgramsToOpenLabel.Text = "Programs to Open";
            // 
            // button5
            // 
            button5.Location = new Point(506, 226);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 10;
            button5.Text = "Select Path";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // runPathButton
            // 
            runPathButton.Location = new Point(506, 255);
            runPathButton.Name = "runPathButton";
            runPathButton.Size = new Size(75, 23);
            runPathButton.TabIndex = 11;
            runPathButton.Text = "Run Paths";
            runPathButton.UseVisualStyleBackColor = true;
            runPathButton.Click += runPathButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(runPathButton);
            Controls.Add(button5);
            Controls.Add(ProgramsToOpenLabel);
            Controls.Add(programsToOpenListBox);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(programsListToClose);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(programsListBox);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private FontDialog fontDialog1;
        private ListBox programsListBox;
        private Button button2;
        private Label label1;
        private ListBox programsListToClose;
        private Label label2;
        private Button button3;
        private Button button4;
        private ListBox programsToOpenListBox;
        private Label ProgramsToOpenLabel;
        private Button button5;
        private Button runPathButton;
    }
}
