namespace GeniyIdiotWinFormsApp
{
    partial class DeleteQuestionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            deleteQuestionButton = new Button();
            startGameButton = new Button();
            questionListBox = new ListBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            addQuestionToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // deleteQuestionButton
            // 
            deleteQuestionButton.Location = new Point(270, 362);
            deleteQuestionButton.Name = "deleteQuestionButton";
            deleteQuestionButton.Size = new Size(289, 34);
            deleteQuestionButton.TabIndex = 0;
            deleteQuestionButton.Text = "Удалить";
            deleteQuestionButton.UseVisualStyleBackColor = true;
            deleteQuestionButton.Click += button1_Click;
            // 
            // startGameButton
            // 
            startGameButton.Location = new Point(270, 409);
            startGameButton.Name = "startGameButton";
            startGameButton.Size = new Size(289, 29);
            startGameButton.TabIndex = 1;
            startGameButton.Text = "Начать игру";
            startGameButton.UseVisualStyleBackColor = true;
            startGameButton.Click += button2_Click;
            // 
            // questionListBox
            // 
            questionListBox.FormattingEnabled = true;
            questionListBox.Location = new Point(12, 92);
            questionListBox.Name = "questionListBox";
            questionListBox.Size = new Size(776, 264);
            questionListBox.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addQuestionToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(59, 24);
            fileToolStripMenuItem.Text = "Файл";
            // 
            // addQuestionToolStripMenuItem
            // 
            addQuestionToolStripMenuItem.Name = "addQuestionToolStripMenuItem";
            addQuestionToolStripMenuItem.Size = new Size(224, 26);
            addQuestionToolStripMenuItem.Text = "Добавить вопрос";
            addQuestionToolStripMenuItem.Click += добавитьВопросToolStripMenuItem_Click;
            // 
            // DeleteQuestionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(questionListBox);
            Controls.Add(startGameButton);
            Controls.Add(deleteQuestionButton);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "DeleteQuestionForm";
            Text = "DeleteQuestionForm";
            Load += DeleteQuestionForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button deleteQuestionButton;
        private Button startGameButton;
        private ListBox questionListBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem addQuestionToolStripMenuItem;
    }
}