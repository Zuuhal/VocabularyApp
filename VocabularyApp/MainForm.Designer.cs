namespace VocabularyApp
{
    partial class MainForm
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
        private Panel panelAdd;
        private Panel panelList;
        private Panel panelPractice;

        private Label lblEnglish;
        private TextBox txtEnglish;
        private Label lblTurkish;
        private TextBox txtTurkish;
        private Button btnAdd;


        private void InitializeComponent()
        {
            btnAddWord = new Button();
            btnListWord = new Button();
            btnPractice = new Button();
            panelAdd = new Panel();
            lblEnglish = new Label();
            txtEnglish = new TextBox();
            lblTurkish = new Label();
            txtTurkish = new TextBox();
            btnClose2 = new Button();
            btnAdd = new Button();
            panelList = new Panel();
            btnDeleteWord = new Button();
            btnClose = new Button();
            dgwWords = new DataGridView();
            panelPractice = new Panel();
            btnClosePractice = new Button();
            btnNext = new Button();
            btnCheck = new Button();
            txtUserAnswer = new TextBox();
            lblResult = new Label();
            lblEnglishWord = new Label();
            btnLogout = new Button();
            btnManageUsers = new Button();
            label1 = new Label();
            panelAdd.SuspendLayout();
            panelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwWords).BeginInit();
            panelPractice.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddWord
            // 
            btnAddWord.Location = new Point(134, 83);
            btnAddWord.Name = "btnAddWord";
            btnAddWord.Size = new Size(75, 23);
            btnAddWord.TabIndex = 0;
            btnAddWord.Text = "Add Word";
            btnAddWord.UseVisualStyleBackColor = true;
            btnAddWord.Click += btnAddWord_Click;
            // 
            // btnListWord
            // 
            btnListWord.Location = new Point(363, 83);
            btnListWord.Name = "btnListWord";
            btnListWord.Size = new Size(75, 23);
            btnListWord.TabIndex = 1;
            btnListWord.Text = "Word List";
            btnListWord.UseVisualStyleBackColor = true;
            btnListWord.Click += btnListWord_Click;
            // 
            // btnPractice
            // 
            btnPractice.Location = new Point(531, 83);
            btnPractice.Name = "btnPractice";
            btnPractice.Size = new Size(75, 23);
            btnPractice.TabIndex = 2;
            btnPractice.Text = "Practice";
            btnPractice.UseVisualStyleBackColor = true;
            btnPractice.Click += btnPractice_Click;
            // 
            // panelAdd
            // 
            panelAdd.Controls.Add(lblEnglish);
            panelAdd.Controls.Add(txtEnglish);
            panelAdd.Controls.Add(lblTurkish);
            panelAdd.Controls.Add(txtTurkish);
            panelAdd.Controls.Add(btnClose2);
            panelAdd.Controls.Add(btnAdd);
            panelAdd.Location = new Point(0, 123);
            panelAdd.Name = "panelAdd";
            panelAdd.Size = new Size(800, 327);
            panelAdd.TabIndex = 2;
            panelAdd.Visible = false;
            // 
            // lblEnglish
            // 
            lblEnglish.Location = new Point(50, 20);
            lblEnglish.Name = "lblEnglish";
            lblEnglish.Size = new Size(100, 20);
            lblEnglish.TabIndex = 0;
            lblEnglish.Text = "English:";
            // 
            // txtEnglish
            // 
            txtEnglish.Location = new Point(50, 45);
            txtEnglish.Name = "txtEnglish";
            txtEnglish.Size = new Size(200, 23);
            txtEnglish.TabIndex = 1;
            // 
            // lblTurkish
            // 
            lblTurkish.Location = new Point(50, 80);
            lblTurkish.Name = "lblTurkish";
            lblTurkish.Size = new Size(100, 20);
            lblTurkish.TabIndex = 2;
            lblTurkish.Text = "Turkish:";
            // 
            // txtTurkish
            // 
            txtTurkish.Location = new Point(50, 105);
            txtTurkish.Name = "txtTurkish";
            txtTurkish.Size = new Size(200, 23);
            txtTurkish.TabIndex = 3;
            // 
            // btnClose2
            // 
            btnClose2.Location = new Point(363, 173);
            btnClose2.Name = "btnClose2";
            btnClose2.Size = new Size(75, 25);
            btnClose2.TabIndex = 5;
            btnClose2.Text = "Close";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(50, 140);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 25);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.Click += BtnAdd_Click;
            // 
            // panelList
            // 
            panelList.Controls.Add(btnDeleteWord);
            panelList.Controls.Add(btnClose);
            panelList.Controls.Add(dgwWords);
            panelList.Location = new Point(0, 123);
            panelList.Name = "panelList";
            panelList.Size = new Size(800, 327);
            panelList.TabIndex = 1;
            panelList.Visible = false;
            // 
            // btnDeleteWord
            // 
            btnDeleteWord.Location = new Point(608, 62);
            btnDeleteWord.Name = "btnDeleteWord";
            btnDeleteWord.Size = new Size(97, 23);
            btnDeleteWord.TabIndex = 7;
            btnDeleteWord.Text = "Delete Word";
            btnDeleteWord.UseVisualStyleBackColor = true;
            btnDeleteWord.Click += btnDeleteWord_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(355, 280);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dgwWords
            // 
            dgwWords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwWords.Location = new Point(209, 62);
            dgwWords.Name = "dgwWords";
            dgwWords.Size = new Size(352, 198);
            dgwWords.TabIndex = 2;
            // 
            // panelPractice
            // 
            panelPractice.Controls.Add(btnClosePractice);
            panelPractice.Controls.Add(btnNext);
            panelPractice.Controls.Add(btnCheck);
            panelPractice.Controls.Add(txtUserAnswer);
            panelPractice.Controls.Add(lblResult);
            panelPractice.Controls.Add(lblEnglishWord);
            panelPractice.Font = new Font("Segoe UI", 9F);
            panelPractice.Location = new Point(0, 123);
            panelPractice.Name = "panelPractice";
            panelPractice.Size = new Size(800, 327);
            panelPractice.TabIndex = 0;
            panelPractice.Visible = false;
            panelPractice.Click += btnClose_Click;
            // 
            // btnClosePractice
            // 
            btnClosePractice.Location = new Point(363, 289);
            btnClosePractice.Name = "btnClosePractice";
            btnClosePractice.Size = new Size(75, 23);
            btnClosePractice.TabIndex = 5;
            btnClosePractice.Text = "Close";
            btnClosePractice.UseVisualStyleBackColor = true;
            btnClosePractice.Click += btnClose_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(363, 40);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 4;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(132, 188);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(75, 23);
            btnCheck.TabIndex = 3;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // txtUserAnswer
            // 
            txtUserAnswer.Location = new Point(132, 80);
            txtUserAnswer.Name = "txtUserAnswer";
            txtUserAnswer.Size = new Size(100, 23);
            txtUserAnswer.TabIndex = 2;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(132, 140);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(39, 15);
            lblResult.TabIndex = 1;
            lblResult.Text = "Result";
            // 
            // lblEnglishWord
            // 
            lblEnglishWord.AutoSize = true;
            lblEnglishWord.Location = new Point(132, 40);
            lblEnglishWord.Name = "lblEnglishWord";
            lblEnglishWord.Size = new Size(77, 15);
            lblEnglishWord.TabIndex = 0;
            lblEnglishWord.Text = "English Word";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(683, 83);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnManageUsers
            // 
            btnManageUsers.Location = new Point(134, 34);
            btnManageUsers.Name = "btnManageUsers";
            btnManageUsers.Size = new Size(116, 23);
            btnManageUsers.TabIndex = 4;
            btnManageUsers.Text = "Manage Users";
            btnManageUsers.UseVisualStyleBackColor = true;
            btnManageUsers.Click += btnManageUsers_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.ForeColor = Color.Fuchsia;
            label1.Location = new Point(355, 32);
            label1.Name = "label1";
            label1.Size = new Size(143, 25);
            label1.TabIndex = 5;
            label1.Text = "Vocabulary App!";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnManageUsers);
            Controls.Add(btnLogout);
            Controls.Add(panelPractice);
            Controls.Add(panelList);
            Controls.Add(panelAdd);
            Controls.Add(btnPractice);
            Controls.Add(btnListWord);
            Controls.Add(btnAddWord);
            Name = "MainForm";
            Text = "MainForm";
            FormClosed += MainForm_FormClosed;
            panelAdd.ResumeLayout(false);
            panelAdd.PerformLayout();
            panelList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgwWords).EndInit();
            panelPractice.ResumeLayout(false);
            panelPractice.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }


        #endregion

        private Button btnAddWord;
        private Button btnListWord;
        private Button btnPractice;
        private Button btnClose;
        private DataGridView dgwWords;
        private Button btnClose2;
        private Button btnCheck;
        private TextBox txtUserAnswer;
        private Label lblResult;
        private Label lblEnglishWord;
        private Button btnClosePractice;
        private Button btnNext;
        private Button btnDeleteWord;
        private Button btnLogout;
        private Button btnManageUsers;
        private Label label1;
    }
}