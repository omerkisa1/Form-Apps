using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string selectedWord;
        private char[] displayWord;
        private string displayMessage = "";
        private int wrongGuessCount = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] words = { "PROGRAMMING", "SOFTWARE", "NESNE", "YAPAY ZEKA" };
            Random random = new Random();
            selectedWord = words[random.Next(words.Length)];

            displayWord = new string('_', selectedWord.Length).ToCharArray();
            WordLabel.Text = string.Join(" ", displayWord);
        }

        private void txtGuess_TextChanged(object sender, EventArgs e)
        {
            string guess = txtGuess.Text;

            if (guess.Length > 1)
            {
                txtGuess.Text = guess.Substring(0, 1);
                txtGuess.SelectionStart = txtGuess.Text.Length;
            }
            if (guess.Length > 0 && !char.IsLetter(guess[0]))
            {
                txtGuess.Clear();
            }
        }

        private void btnCheckGuess_Click(object sender, EventArgs e)
        {
            string guess = txtGuess.Text.ToUpper();

            if (string.IsNullOrWhiteSpace(guess))
            {
                MessageBox.Show("Empty guess made!");
                return;
            }

            if (selectedWord.Contains(guess))
            {
                for (int i = 0; i < selectedWord.Length; i++)
                {
                    if (selectedWord[i].ToString() == guess)
                    {
                        displayWord[i] = guess[0];
                    }
                }

                WordLabel.Text = string.Join(" ", displayWord);
            }
            else
            {
                if (!displayMessage.Contains(guess))
                {
                    displayMessage += guess + " ";
                    wrongWordLabel.Text = displayMessage;
                    wrongGuessCount++;

                    DisplayHangman(wrongGuessCount);

                    if (wrongGuessCount >= 7)
                    {
                        MessageBox.Show("Game Over! The correct word was: " + selectedWord);
                        btnCheckGuess.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("This letter is already in the list: " + guess);
                }
            }

            txtGuess.Clear();
        }

        // Hangman'i gösteren fonksiyon
        private void DisplayHangman(int tries)
        {
            string[] stages =
            {
                @"
               --------
               |      |
               |      
               |    
               |      
               |     
               -",
                @"
               --------
               |      |
               |      O
               |    
               |      
               |     
               -",
                @"
               --------
               |      |
               |      O
               |      |
               |      
               |     
               -",
                @"
               --------
               |      |
               |      O
               |     \|
               |      
               |     
               -",
                @"
               --------
               |      |
               |      O
               |     \|/
               |      
               |     
               -",
                @"
               --------
               |      |
               |      O
               |     \|/
               |      |
               |     
               -",
                @"
               --------
               |      |
               |      O
               |     \|/
               |      |
               |     / 
               -",
                @"
               --------
               |      |
               |      O
               |     \|/
               |      |
               |     / \
               -"
            };

            hangmanLabel.Text = stages[tries]; // ASCII sanatını gösteren label
        }

        private void wrongWordLabel_Click(object sender, EventArgs e)
        {
            // Button actions
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void WordLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
