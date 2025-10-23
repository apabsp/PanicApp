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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(282, 253);
            button1.Name = "button1";
            button1.Size = new Size(120, 60);
            button1.TabIndex = 0;
            button1.Text = "Clica aqui!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // programsListBox
            // 
            programsListBox.FormattingEnabled = true;
            programsListBox.Location = new Point(265, 12);
            programsListBox.Name = "programsListBox";
            programsListBox.Size = new Size(150, 104);
            programsListBox.TabIndex = 1;
            programsListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(programsListBox);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private FontDialog fontDialog1;
        private ListBox programsListBox;
    }
}
