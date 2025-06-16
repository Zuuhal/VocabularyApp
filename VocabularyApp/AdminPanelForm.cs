using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VocabularyApp
{
    public partial class AdminPanelForm : Form
    {
        private User currentUser;
        private List<User> users;

        public AdminPanelForm(User currentUser, List<User> users)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.users = users;

            this.dataGridViewUsers.SelectionChanged += dataGridViewUsers_SelectionChanged;

            this.Load += AdminPanelForm_Load; 

        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(currentUser, users);
            mainForm.Show();
            this.Close();
        }
        private void AdminPanelForm_Load(object sender, EventArgs e)
        {
            LoadUsersGrid();
        }

        private void LoadUsersGrid()
        {
            var userList = users.Select(u => new
            {
                u.Username,
                IsAdmin = u.IsAdmin ? "Yes" : "No"
            }).ToList();

            dataGridViewUsers.DataSource = userList;
        }
        private void dataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewUsers.CurrentRow == null) return;

            string selectedUsername = dataGridViewUsers.CurrentRow.Cells["Username"].Value.ToString();

            User selectedUser = users.FirstOrDefault(u => u.Username == selectedUsername);
            if (selectedUser != null)
            {
                dataGridViewUserWords.DataSource = selectedUser.Words.Select(w => new
                {
                    w.English,
                    w.Turkish,
                    IsLearned = w.IsLearned ? "Yes" : "No"
                }).ToList();
            }
        }
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.CurrentRow == null)
            {
                MessageBox.Show("Please select a user.");
                return;
            }

            string selectedUsername = dataGridViewUsers.CurrentRow.Cells["Username"].Value.ToString();

            if (selectedUsername == currentUser.Username)
            {
                MessageBox.Show("You cannot delete yourself!");
                return;
            }

            if (selectedUsername == "admin")
            {
                MessageBox.Show("You cannot delete admin!");
                return;
            }

            var userToRemove = users.FirstOrDefault(u => u.Username == selectedUsername);
            if (userToRemove != null)
            {
                users.Remove(userToRemove);
                SaveUsersToFile();
                LoadUsersGrid();
                dataGridViewUserWords.DataSource = null;
                MessageBox.Show($"{selectedUsername} deleted successfully.");
            }
        }
        private void SaveUsersToFile()
        {
            string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("users.json", json);
        }

        private void btnMakeAdmin_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.CurrentRow == null)
            {
                MessageBox.Show("Please select a user.");
                return;
            }

            string selectedUsername = dataGridViewUsers.CurrentRow.Cells["Username"].Value.ToString();

            var userToMakeAdmin = users.FirstOrDefault(u => u.Username == selectedUsername);
            if (userToMakeAdmin != null)
            {
                userToMakeAdmin.IsAdmin = true;
                SaveUsersToFile();
                LoadUsersGrid();
                MessageBox.Show($"{selectedUsername} is now admin.");
            }
        }

        private void btnRemoveAdmin_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.CurrentRow == null)
            {
                MessageBox.Show("Please select a user.");
                return;
            }

            string selectedUsername = dataGridViewUsers.CurrentRow.Cells["Username"].Value.ToString();


            if (selectedUsername == currentUser.Username)
            {
                MessageBox.Show("You cannot remove yourself!");
                return;
            }

            if (selectedUsername == "admin")
            {
                MessageBox.Show("You cannot remove admin!");
                return;
            }
            var userToMakeAdmin = users.FirstOrDefault(u => u.Username == selectedUsername);
            if (userToMakeAdmin != null)
            {
                userToMakeAdmin.IsAdmin = false;
                SaveUsersToFile();
                LoadUsersGrid();
                MessageBox.Show($"{selectedUsername} is not admin anymore.");
            }

        }
    }
}
