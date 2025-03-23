namespace GeniyIdiotWinFormsApp
{
    partial class mainForm
    {
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
            nextButton = new Button();
            questionTextLabel = new Label();
            userAnswerTextBox = new TextBox();
            questionNumberLabel = new Label();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            restartGameToolStripMenuItem = new ToolStripMenuItem();
            lookResultToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            questionsToolStripMenuItem = new ToolStripMenuItem();
            addQuestionToolStripMenuItem = new ToolStripMenuItem();
            removeQuestionToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // nextButton
            // 
            nextButton.Font = new Font("Segoe UI", 20F);
            nextButton.Location = new Point(326, 333);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(136, 54);
            nextButton.TabIndex = 0;
            nextButton.Text = "Далее\r\n";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // questionTextLabel
            // 
            questionTextLabel.AutoSize = true;
            questionTextLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            questionTextLabel.Location = new Point(136, 110);
            questionTextLabel.MaximumSize = new Size(0, 200);
            questionTextLabel.Name = "questionTextLabel";
            questionTextLabel.Size = new Size(251, 46);
            questionTextLabel.TabIndex = 3;
            questionTextLabel.Text = "Текст вопроса";
            questionTextLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // userAnswerTextBox
            // 
            userAnswerTextBox.Location = new Point(367, 280);
            userAnswerTextBox.Multiline = true;
            userAnswerTextBox.Name = "userAnswerTextBox";
            userAnswerTextBox.Size = new Size(365, 30);
            userAnswerTextBox.TabIndex = 0;
            // 
            // questionNumberLabel
            // 
            questionNumberLabel.AutoSize = true;
            questionNumberLabel.Location = new Point(326, 60);
            questionNumberLabel.Name = "questionNumberLabel";
            questionNumberLabel.Size = new Size(132, 20);
            questionNumberLabel.TabIndex = 5;
            questionNumberLabel.Text = "Вопрос номер №";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(123, 269);
            label2.Name = "label2";
            label2.Size = new Size(218, 41);
            label2.TabIndex = 6;
            label2.Text = "Введите ответ";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 28);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, questionsToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 28);
            menuStrip2.TabIndex = 8;
            menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { restartGameToolStripMenuItem, lookResultToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(59, 24);
            fileToolStripMenuItem.Text = "Файл";
            // 
            // restartGameToolStripMenuItem
            // 
            restartGameToolStripMenuItem.Name = "restartGameToolStripMenuItem";
            restartGameToolStripMenuItem.Size = new Size(258, 26);
            restartGameToolStripMenuItem.Text = "Перезагрузить игру";
            restartGameToolStripMenuItem.Click += restartGameToolStripMenuItem_Click;
            // 
            // lookResultToolStripMenuItem
            // 
            lookResultToolStripMenuItem.Name = "lookResultToolStripMenuItem";
            lookResultToolStripMenuItem.Size = new Size(258, 26);
            lookResultToolStripMenuItem.Text = "Посмотреть результаты";
            lookResultToolStripMenuItem.Click += lookResultToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(258, 26);
            exitToolStripMenuItem.Text = "Выход";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // questionsToolStripMenuItem
            // 
            questionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addQuestionToolStripMenuItem, removeQuestionToolStripMenuItem });
            questionsToolStripMenuItem.Name = "questionsToolStripMenuItem";
            questionsToolStripMenuItem.Size = new Size(86, 24);
            questionsToolStripMenuItem.Text = "Вопросы";
            // 
            // addQuestionToolStripMenuItem
            // 
            addQuestionToolStripMenuItem.Name = "addQuestionToolStripMenuItem";
            addQuestionToolStripMenuItem.Size = new Size(224, 26);
            addQuestionToolStripMenuItem.Text = "Добавить вопрос";
            addQuestionToolStripMenuItem.Click += addQuestionToolStripMenuItem_Click;
            // 
            // removeQuestionToolStripMenuItem
            // 
            removeQuestionToolStripMenuItem.Name = "removeQuestionToolStripMenuItem";
            removeQuestionToolStripMenuItem.Size = new Size(224, 26);
            removeQuestionToolStripMenuItem.Text = "Удалить вопрос";
            removeQuestionToolStripMenuItem.Click += remoteQuestionToolStripMenuItem_Click;
            // 
            // mainForm
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(questionNumberLabel);
            Controls.Add(userAnswerTextBox);
            Controls.Add(questionTextLabel);
            Controls.Add(nextButton);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Гений идиот";
            Load += mainForm_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button nextButton;
        private Label questionTextLabel;
        private TextBox userAnswerTextBox;
        private Label questionNumberLabel;
        private Label label2;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem restartGameToolStripMenuItem;
        private ToolStripMenuItem lookResultToolStripMenuItem;
        private ToolStripMenuItem questionsToolStripMenuItem;
        private ToolStripMenuItem addQuestionToolStripMenuItem;
        private ToolStripMenuItem removeQuestionToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}
