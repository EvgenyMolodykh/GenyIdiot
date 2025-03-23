namespace GeniyIdiotWinFormsApp
{
    partial class UserNameForm
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
            label2 = new Label();
            userNameTextBox = new TextBox();
            startGameButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(72, 80);
            label1.Name = "label1";
            label1.Size = new Size(664, 38);
            label1.TabIndex = 0;
            label1.Text = "Добро пожаловать в игру Гений - Идиот!";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(72, 201);
            label2.Name = "label2";
            label2.Size = new Size(308, 38);
            label2.TabIndex = 1;
            label2.Text = "Введите свое имя:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            userNameTextBox.Location = new Point(390, 195);
            userNameTextBox.Margin = new Padding(3, 3, 3, 30);
            userNameTextBox.MaximumSize = new Size(400, 0);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(346, 47);
            userNameTextBox.TabIndex = 2;
            // 
            // startGameButton
            // 
            startGameButton.BackColor = SystemColors.ActiveCaption;
            startGameButton.DialogResult = DialogResult.OK;
            startGameButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            startGameButton.Location = new Point(295, 307);
            startGameButton.Name = "startGameButton";
            startGameButton.Size = new Size(198, 57);
            startGameButton.TabIndex = 3;
            startGameButton.Text = "Начать игру";
            startGameButton.UseVisualStyleBackColor = false;
            startGameButton.Click += startGameButton_Click;
            // 
            // UserNameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(startGameButton);
            Controls.Add(userNameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserNameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserName";
            FormClosing += UserNameForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        public TextBox userNameTextBox;
        public Button startGameButton;
    }
}