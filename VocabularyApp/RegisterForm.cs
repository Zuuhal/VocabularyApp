using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace VocabularyApp
{
    public partial class RegisterForm : Form
    {
        private string userFile = "users.json";
        private List<User> users = new List<User>();

        public RegisterForm()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            if (File.Exists(userFile))
            {
                string json = File.ReadAllText(userFile);
                users = JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username or password cannot be left blank.");
                return;
            }
            if(password.Length < 6)
            {
                MessageBox.Show("Your password must be at least 6 characters long!");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            if (users.Exists(u => u.Username == username))
            {
                MessageBox.Show("This username is already taken.");
                return;
            }

            users.Add(new User { Username = username, Password = password });

            string json = JsonSerializer.Serialize(users);
            File.WriteAllText(userFile, json);

            this.Close(); 
        }
    }
}

