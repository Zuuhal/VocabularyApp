using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;


namespace VocabularyApp
{
    public partial class MainForm : Form
    {
        private List<Word> practiceWords;
        private int currentIndex = -1;
        private Random random = new Random();
        private List<User> users;


        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(User currentUser, List<User> users)
        {
            InitializeComponent();

            this.currentUser = currentUser;
            this.users = users;

            btnManageUsers.Visible = currentUser.IsAdmin;


            btnClose2.Click += btnClose_Click;
            btnCheck.Click += btnCheck_Click;
            btnNext.Click += btnNext_Click;

            if (currentUser != null && currentUser.Words != null)
            {
                practiceWords = currentUser.Words
                    .Where(w => w != null && !w.IsLearned)
                    .OrderBy(x => random.Next())
                    .ToList();
            }
            else
            {
                practiceWords = new List<Word>();
            }

            currentIndex = -1; 

            if (practiceWords.Count > 0)
            {
                ShowNextWord();
            }
            else
            {
                lblEnglishWord.Text = "No words to practice!";
                txtUserAnswer.Enabled = false;
                btnCheck.Enabled = false;
                btnNext.Enabled = false;
            }
        }


        private void LoadUsers()
        {
            try
            {
                string filePath = "users.json";
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    users = JsonSerializer.Deserialize<List<User>>(json);

                    if (users != null && users.Count > 0)
                    {
                        if (currentUser == null)
                        {
                            currentUser = users[0]; 
                        }
                        else
                        {
                            currentUser = users.FirstOrDefault(u => u.Username == currentUser.Username) ?? currentUser;
                        }
                    }
                    else
                    {
                        users = new List<User>();
                        currentUser = new User { Username = "testuser", Words = new List<Word>() };
                        users.Add(currentUser);
                    }
                }
                else
                {
                    users = new List<User>();
                    currentUser = new User { Username = "testuser", Words = new List<Word>() };
                    users.Add(currentUser);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load user data: " + ex.Message);
                users = new List<User>();
                currentUser = new User { Username = "testuser", Words = new List<Word>() };
                users.Add(currentUser);
            }
        }

        private void SaveUsers()
        {
            try
            {
                string filePath = "users.json";

                var existingUser = users.FirstOrDefault(u => u.Username == currentUser.Username);
                if (existingUser != null)
                {
                    users.Remove(existingUser);
                }
                users.Add(currentUser);

                string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save user data: " + ex.Message);
            }
        }




        private void ShowNextWord()
        {
            if (practiceWords == null || practiceWords.Count == 0)
            {
                lblEnglishWord.Text = "No words to practice!";
                txtUserAnswer.Enabled = false;
                btnCheck.Enabled = false;
                btnNext.Enabled = false;
                return;
            }

            if (currentIndex < 0 || currentIndex >= practiceWords.Count)
            {
                lblEnglishWord.Text = "You have completed all words!";
                txtUserAnswer.Enabled = false;
                btnCheck.Enabled = false;
                btnNext.Enabled = false;
                return;
            }

            var word = practiceWords[currentIndex];
            if (word == null)
            {
                lblEnglishWord.Text = "Invalid word data!";
                return;
            }

            lblEnglishWord.Text = word.English;
            txtUserAnswer.Text = "";
            lblResult.Text = "";
            txtUserAnswer.Enabled = true;
            btnCheck.Enabled = true;
            btnNext.Enabled = false;
        }




        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (practiceWords == null || currentIndex < 0 || currentIndex >= practiceWords.Count)
                return;

            string userAnswer = txtUserAnswer.Text.Trim().ToLower();
            string correctAnswer = practiceWords[currentIndex].Turkish.ToLower();

            if (userAnswer == correctAnswer)
            {
                lblResult.Text = "Correct!";
                practiceWords[currentIndex].IsLearned = true;

                var wordInMainList = currentUser.Words.FirstOrDefault(w => w.English == practiceWords[currentIndex].English);
                if (wordInMainList != null)
                    wordInMainList.IsLearned = true;

                practiceWords.RemoveAt(currentIndex);

                currentIndex--;

                SaveUsers(); 

                btnNext.Enabled = true;
                btnCheck.Enabled = false;
                txtUserAnswer.Enabled = false;
            }
            else
            {
                lblResult.Text = $"Wrong! The correct answer is: {correctAnswer}";

                Word wrongWord = practiceWords[currentIndex];

                practiceWords.RemoveAt(currentIndex);
                practiceWords.Add(wrongWord);

                currentIndex--;

                btnNext.Enabled = true;
                btnCheck.Enabled = false;
                txtUserAnswer.Enabled = false;
            }
        }



        private void btnNext_Click(object sender, EventArgs e)
        {
            currentIndex++;

            if (practiceWords == null || practiceWords.Count == 0)
            {
                lblEnglishWord.Text = "No words to practice!";
                txtUserAnswer.Enabled = false;
                btnCheck.Enabled = false;
                btnNext.Enabled = false;
                return;
            }

            if (currentIndex < practiceWords.Count)
            {
                lblEnglishWord.Text = practiceWords[currentIndex].English;
                lblResult.Text = "";
                txtUserAnswer.Clear();
                txtUserAnswer.Enabled = true;
                btnCheck.Enabled = true;
                btnNext.Enabled = false;
            }
            else
            {
                lblEnglishWord.Text = "You have completed all words!";
                txtUserAnswer.Enabled = false;
                btnCheck.Enabled = false;
                btnNext.Enabled = false;
            }
        }



        private User currentUser;


        private void ShowPanel(Panel panelToShow)
        {
            panelAdd.Visible = false;
            panelList.Visible = false;
            panelPractice.Visible = false;

            if (panelToShow != null)
                panelToShow.Visible = true;
        }


        private void btnAddWord_Click(object sender, EventArgs e)
        {
            ShowPanel(panelAdd);
        }

        private void btnListWord_Click(object sender, EventArgs e)
        {
            RefreshWordTable(); 
            ShowPanel(panelList);
            LoadWordList();
        }
        private void LoadWordList()
        {
            dgwWords.DataSource = null;
            dgwWords.DataSource = currentUser.Words.Select(w => new
            {
                English = w.English,
                Turkish = w.Turkish,
                Learned = w.IsLearned ? "✔" : "✘"
            }).ToList();
        }


        private void btnPractice_Click(object sender, EventArgs e)
        {
            ShowPanel(panelPractice);

            lblEnglishWord.Text = "Click Next to start practicing!";
            lblResult.Text = "";
            txtUserAnswer.Enabled = false;
            btnCheck.Enabled = false;
            btnNext.Enabled = true;
            practiceWords = currentUser.Words.Where(w => !w.IsLearned).ToList();
            currentIndex = -1;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string english = txtEnglish.Text.Trim();
            string turkish = txtTurkish.Text.Trim();

            if (string.IsNullOrEmpty(english) || string.IsNullOrEmpty(turkish))
            {
                MessageBox.Show("Please enter both English and Turkish words.");
                return;
            }
            currentUser.Words.Add(new Word
            {
                English = english,
                Turkish = turkish,
                IsLearned = false
            });

            SaveUsers();

            MessageBox.Show($"Word added: {english} - {turkish}");
            txtEnglish.Clear();
            txtTurkish.Clear();
            RefreshWordTable();
        }
        private void RefreshWordTable()
        {
            dgwWords.DataSource = null;
            dgwWords.DataSource = currentUser.Words;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            ShowPanel(null);
        }
        private void btnDeleteWord_Click(object sender, EventArgs e)
        {
            if (dgwWords.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a word to delete.");
                return;
            }

            string englishToDelete = dgwWords.SelectedRows[0].Cells["English"].Value.ToString();

            var wordToRemove = currentUser.Words.FirstOrDefault(w => w.English == englishToDelete);
            if (wordToRemove != null)
            {
                currentUser.Words.Remove(wordToRemove);

                SaveUsers();              
                LoadWordList();

                MessageBox.Show($"'{englishToDelete}' has been deleted.");
            }
            else
            {
                MessageBox.Show("Word not found.");
            }
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            AdminPanelForm adminForm = new AdminPanelForm(currentUser, users);
            adminForm.Show();
            this.Hide();
        }
    }
}
