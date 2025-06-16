using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace VocabularyApp
{
    public partial class LoginForm : Form
    {
        private List<User> users = new List<User>();
        private string userFile = "users.json";

        public LoginForm()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            if (!File.Exists(userFile))
            {
                users = new List<User>(); 
                return;
            }

            string json = File.ReadAllText(userFile);
            users = JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            var currentUser = users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (currentUser != null)
            {
                MainForm mainForm = new MainForm(currentUser, users);
                this.Hide(); 
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password.");
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
            LoadUsers(); 
        }
    }
}
