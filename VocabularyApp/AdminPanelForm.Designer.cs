namespace VocabularyApp
{
    partial class AdminPanelForm
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
            dataGridViewUsers = new DataGridView();
            dataGridViewUserWords = new DataGridView();
            btnDeleteUser = new Button();
            btnMakeAdmin = new Button();
            label1 = new Label();
            label2 = new Label();
            btnBackToMain = new Button();
            btnRemoveAdmin = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUserWords).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(70, 57);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.Size = new Size(240, 150);
            dataGridViewUsers.TabIndex = 0;
            // 
            // dataGridViewUserWords
            // 
            dataGridViewUserWords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUserWords.Location = new Point(70, 252);
            dataGridViewUserWords.Name = "dataGridViewUserWords";
            dataGridViewUserWords.Size = new Size(240, 150);
            dataGridViewUserWords.TabIndex = 1;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(432, 57);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(98, 23);
            btnDeleteUser.TabIndex = 2;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnMakeAdmin
            // 
            btnMakeAdmin.Location = new Point(432, 114);
            btnMakeAdmin.Name = "btnMakeAdmin";
            btnMakeAdmin.Size = new Size(98, 23);
            btnMakeAdmin.TabIndex = 3;
            btnMakeAdmin.Text = "Make Admin";
            btnMakeAdmin.UseVisualStyleBackColor = true;
            btnMakeAdmin.Click += btnMakeAdmin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 30);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 4;
            label1.Text = "Users";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 220);
            label2.Name = "label2";
            label2.Size = new Size(128, 15);
            label2.TabIndex = 5;
            label2.Text = "Words of Selected User";
            // 
            // btnBackToMain
            // 
            btnBackToMain.Location = new Point(441, 379);
            btnBackToMain.Name = "btnBackToMain";
            btnBackToMain.Size = new Size(139, 23);
            btnBackToMain.TabIndex = 6;
            btnBackToMain.Text = "Back to Main Page";
            btnBackToMain.UseVisualStyleBackColor = true;
            btnBackToMain.Click += btnBackToMain_Click;
            // 
            // btnRemoveAdmin
            // 
            btnRemoveAdmin.Location = new Point(432, 168);
            btnRemoveAdmin.Name = "btnRemoveAdmin";
            btnRemoveAdmin.Size = new Size(98, 23);
            btnRemoveAdmin.TabIndex = 7;
            btnRemoveAdmin.Text = "Remove Admin";
            btnRemoveAdmin.UseVisualStyleBackColor = true;
            btnRemoveAdmin.Click += btnRemoveAdmin_Click;
            // 
            // AdminPanelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRemoveAdmin);
            Controls.Add(btnBackToMain);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnMakeAdmin);
            Controls.Add(btnDeleteUser);
            Controls.Add(dataGridViewUserWords);
            Controls.Add(dataGridViewUsers);
            Name = "AdminPanelForm";
            Text = "AdminPanelForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUserWords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewUsers;
        private DataGridView dataGridViewUserWords;
        private Button btnDeleteUser;
        private Button btnMakeAdmin;
        private Label label1;
        private Label label2;
        private Button btnBackToMain;
        private Button btnRemoveAdmin;
    }
}