namespace GeniyIdiotWinFormsApp
{
    partial class ResultsForm
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
            resultsDataGridView = new DataGridView();
            userNameColumn = new DataGridViewTextBoxColumn();
            CountRightAnswersColumn = new DataGridViewTextBoxColumn();
            userDiagnoseColumn = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            fileResultstFormToolStripMenuItem = new ToolStripMenuItem();
            exitResultstFormToolStripMenuItem = new ToolStripMenuItem();
            restartResultstFormToolStripMenuItem = new ToolStripMenuItem();
            questionToolStripMenuItem = new ToolStripMenuItem();
            deleteQuestionToolStripMenuItem = new ToolStripMenuItem();
            addQuestionToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // resultsDataGridView
            // 
            resultsDataGridView.AllowUserToAddRows = false;
            resultsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultsDataGridView.Columns.AddRange(new DataGridViewColumn[] { userNameColumn, CountRightAnswersColumn, userDiagnoseColumn });
            resultsDataGridView.Location = new Point(12, 76);
            resultsDataGridView.Name = "resultsDataGridView";
            resultsDataGridView.RowHeadersWidth = 51;
            resultsDataGridView.Size = new Size(776, 213);
            resultsDataGridView.TabIndex = 0;
            // 
            // userNameColumn
            // 
            userNameColumn.HeaderText = "Имя пользователя";
            userNameColumn.MinimumWidth = 6;
            userNameColumn.Name = "userNameColumn";
            userNameColumn.Width = 125;
            // 
            // CountRightAnswersColumn
            // 
            CountRightAnswersColumn.HeaderText = "Количество правильных ответов";
            CountRightAnswersColumn.MinimumWidth = 6;
            CountRightAnswersColumn.Name = "CountRightAnswersColumn";
            CountRightAnswersColumn.Width = 125;
            // 
            // userDiagnoseColumn
            // 
            userDiagnoseColumn.HeaderText = "Диагноз";
            userDiagnoseColumn.MinimumWidth = 6;
            userDiagnoseColumn.Name = "userDiagnoseColumn";
            userDiagnoseColumn.Width = 125;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileResultstFormToolStripMenuItem, questionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileResultstFormToolStripMenuItem
            // 
            fileResultstFormToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitResultstFormToolStripMenuItem, restartResultstFormToolStripMenuItem });
            fileResultstFormToolStripMenuItem.Name = "fileResultstFormToolStripMenuItem";
            fileResultstFormToolStripMenuItem.Size = new Size(59, 24);
            fileResultstFormToolStripMenuItem.Text = "Файл";
            // 
            // exitResultstFormToolStripMenuItem
            // 
            exitResultstFormToolStripMenuItem.Name = "exitResultstFormToolStripMenuItem";
            exitResultstFormToolStripMenuItem.Size = new Size(224, 26);
            exitResultstFormToolStripMenuItem.Text = "Выход";
            exitResultstFormToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // restartResultstFormToolStripMenuItem
            // 
            restartResultstFormToolStripMenuItem.Name = "restartResultstFormToolStripMenuItem";
            restartResultstFormToolStripMenuItem.Size = new Size(224, 26);
            restartResultstFormToolStripMenuItem.Text = "Рестарт";
            restartResultstFormToolStripMenuItem.Click += restartToolStripMenuItem_Click;
            // 
            // questionToolStripMenuItem
            // 
            questionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { deleteQuestionToolStripMenuItem, addQuestionToolStripMenuItem });
            questionToolStripMenuItem.Name = "questionToolStripMenuItem";
            questionToolStripMenuItem.Size = new Size(86, 24);
            questionToolStripMenuItem.Text = "Вопросы";
            // 
            // deleteQuestionToolStripMenuItem
            // 
            deleteQuestionToolStripMenuItem.Name = "deleteQuestionToolStripMenuItem";
            deleteQuestionToolStripMenuItem.Size = new Size(214, 26);
            deleteQuestionToolStripMenuItem.Text = "Удалить вопрос";
            // 
            // addQuestionToolStripMenuItem
            // 
            addQuestionToolStripMenuItem.Name = "addQuestionToolStripMenuItem";
            addQuestionToolStripMenuItem.Size = new Size(214, 26);
            addQuestionToolStripMenuItem.Text = "Добавить вопрос";
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultsDataGridView);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ResultsForm";
            Text = "ResultsForm";
            Load += ResultsForm_Load;
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView resultsDataGridView;
        private DataGridViewTextBoxColumn userNameColumn;
        private DataGridViewTextBoxColumn CountRightAnswersColumn;
        private DataGridViewTextBoxColumn userDiagnoseColumn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileResultstFormToolStripMenuItem;
        private ToolStripMenuItem exitResultstFormToolStripMenuItem;
        private ToolStripMenuItem restartResultstFormToolStripMenuItem;
        private ToolStripMenuItem questionToolStripMenuItem;
        private ToolStripMenuItem deleteQuestionToolStripMenuItem;
        private ToolStripMenuItem addQuestionToolStripMenuItem;
    }
}