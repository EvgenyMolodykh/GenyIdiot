namespace GeniyIdiotWinFormsApp
{
    partial class AddQuestionsForm
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
            label1 = new Label();
            addQuestionTextBox = new TextBox();
            addAnswerTextBox = new TextBox();
            label2 = new Label();
            cancelButton = new Button();
            AdditionalQuestionButton = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            restartToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 143);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 0;
            label1.Text = "Введите вопрос";
            // 
            // addQuestionTextBox
            // 
            addQuestionTextBox.Location = new Point(298, 140);
            addQuestionTextBox.Name = "addQuestionTextBox";
            addQuestionTextBox.Size = new Size(303, 27);
            addQuestionTextBox.TabIndex = 1;
            // 
            // addAnswerTextBox
            // 
            addAnswerTextBox.Location = new Point(298, 219);
            addAnswerTextBox.Name = "addAnswerTextBox";
            addAnswerTextBox.Size = new Size(303, 27);
            addAnswerTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 226);
            label2.Name = "label2";
            label2.Size = new Size(182, 20);
            label2.TabIndex = 3;
            label2.Text = "Введите ответ на вопрос";
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(364, 343);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(156, 29);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // AdditionalQuestionButton
            // 
            AdditionalQuestionButton.Location = new Point(316, 288);
            AdditionalQuestionButton.Name = "AdditionalQuestionButton";
            AdditionalQuestionButton.Size = new Size(275, 29);
            AdditionalQuestionButton.TabIndex = 5;
            AdditionalQuestionButton.Text = "Добавить вопрос";
            AdditionalQuestionButton.UseVisualStyleBackColor = true;
            AdditionalQuestionButton.Click += AdditionalQuestionButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem, restartToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(59, 24);
            fileToolStripMenuItem.Text = "Файл";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(144, 26);
            exitToolStripMenuItem.Text = "Выход";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // restartToolStripMenuItem
            // 
            restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            restartToolStripMenuItem.Size = new Size(144, 26);
            restartToolStripMenuItem.Text = "Рестарт";
            restartToolStripMenuItem.Click += restartToolStripMenuItem_Click;
            // 
            // AddQuestionsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AdditionalQuestionButton);
            Controls.Add(cancelButton);
            Controls.Add(label2);
            Controls.Add(addAnswerTextBox);
            Controls.Add(addQuestionTextBox);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AddQuestionsForm";
            Text = "AddQuestionsForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox addQuestionTextBox;
        private TextBox addAnswerTextBox;
        private Label label2;
        private Button cancelButton;
        private Button AdditionalQuestionButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem restartToolStripMenuItem;
    }
}