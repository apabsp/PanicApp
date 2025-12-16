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
            ProgramsToOpen = new ListBox();
            ProgramsToOpenLabel = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(316, 263);
            button1.Name = "button1";
            button1.Size = new Size(156, 89);
            button1.TabIndex = 0;
            button1.Text = "Close selected programs";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // programsListBox
            // 
            programsListBox.FormattingEnabled = true;
            programsListBox.Location = new Point(316, 58);
            programsListBox.Name = "programsListBox";
            programsListBox.Size = new Size(150, 104);
            programsListBox.TabIndex = 1;
            programsListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(483, 58);
            button2.Name = "button2";
            button2.Size = new Size(110, 52);
            button2.TabIndex = 2;
            button2.Text = "Load running programs";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(297, 35);
            label1.Name = "label1";
            label1.Size = new Size(187, 20);
            label1.TabIndex = 3;
            label1.Text = "Programs currently running";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // programsListToClose
            // 
            programsListToClose.FormattingEnabled = true;
            programsListToClose.Location = new Point(35, 190);
            programsListToClose.Name = "programsListToClose";
            programsListToClose.Size = new Size(150, 104);
            programsListToClose.TabIndex = 4;
            programsListToClose.SelectedIndexChanged += programsListToClose_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 167);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 5;
            label2.Text = "Programs to close";
            // 
            // button3
            // 
            button3.Location = new Point(483, 133);
            button3.Name = "button3";
            button3.Size = new Size(47, 29);
            button3.TabIndex = 6;
            button3.Text = "+";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(556, 135);
            button4.Name = "button4";
            button4.Size = new Size(37, 27);
            button4.TabIndex = 7;
            button4.Text = "-";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // ProgramsToOpen
            // 
            ProgramsToOpen.FormattingEnabled = true;
            ProgramsToOpen.Location = new Point(547, 190);
            ProgramsToOpen.Name = "ProgramsToOpen";
            ProgramsToOpen.Size = new Size(150, 104);
            ProgramsToOpen.TabIndex = 8;
            ProgramsToOpen.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // ProgramsToOpenLabel
            // 
            ProgramsToOpenLabel.AutoSize = true;
            ProgramsToOpenLabel.Location = new Point(556, 167);
            ProgramsToOpenLabel.Name = "ProgramsToOpenLabel";
            ProgramsToOpenLabel.Size = new Size(130, 20);
            ProgramsToOpenLabel.TabIndex = 9;
            ProgramsToOpenLabel.Text = "Programs to Open";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ProgramsToOpenLabel);
            Controls.Add(ProgramsToOpen);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(programsListToClose);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(programsListBox);
            Controls.Add(button1);
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
        private ListBox ProgramsToOpen;
        private Label ProgramsToOpenLabel;
    }
}
