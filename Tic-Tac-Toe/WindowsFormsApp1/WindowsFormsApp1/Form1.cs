using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private bool isXTurn = true; // Track if it's X's turn or O's
        private bool isVsComputer = false; // Game mode: true if vs computer
        private Random random = new Random(); // For computer's random move

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Attach event handler to each button on the grid
            btn00.Click += new EventHandler(button_Click);
            btn01.Click += new EventHandler(button_Click);
            btn02.Click += new EventHandler(button_Click);
            btn10.Click += new EventHandler(button_Click);
            btn11.Click += new EventHandler(button_Click);
            btn12.Click += new EventHandler(button_Click);
            btn20.Click += new EventHandler(button_Click);
            btn21.Click += new EventHandler(button_Click);
            btn22.Click += new EventHandler(button_Click);

            // Set game mode (vs Computer or vs Friend)
            btnComputer.Click += delegate { isVsComputer = true; ResetBoard(); };
            btnFriend.Click += delegate { isVsComputer = false; ResetBoard(); };
        }

        // Handles the player's move
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // Check if the button is empty before marking it
            if (button.Text == "")
            {
                // Mark with X or O depending on the turn
                button.Text = isXTurn ? "X" : "O";
                isXTurn = !isXTurn; // Switch turn
                CheckForWinner(); // Check if anyone won

                // If playing vs computer and it's computer's turn, make computer move
                if (isVsComputer && !isXTurn)
                {
                    ComputerMove();
                    CheckForWinner();
                }
            }
            else
            {
                MessageBox.Show("This button is already taken, choose another.");
            }
        }

        // Computer makes a random move
        private void ComputerMove()
        {
            Button[] buttons = { btn00, btn01, btn02, btn10, btn11, btn12, btn20, btn21, btn22 };
            Button emptyButton;

            // Keep choosing a random button until we find an empty one
            do
            {
                emptyButton = buttons[random.Next(buttons.Length)];
            } while (emptyButton.Text != "");

            emptyButton.Text = "O"; // Computer marks O
            isXTurn = !isXTurn; // Switch back to player's turn
        }

        // Check if there's a winner or a tie
        private void CheckForWinner()
        {
            string[,] board = new string[3, 3];

            // Copy button texts into a 2D array for easier checks
            board[0, 0] = btn00.Text; board[0, 1] = btn01.Text; board[0, 2] = btn02.Text;
            board[1, 0] = btn10.Text; board[1, 1] = btn11.Text; board[1, 2] = btn12.Text;
            board[2, 0] = btn20.Text; board[2, 1] = btn21.Text; board[2, 2] = btn22.Text;

            // Check if X or O has a winning line
            if (CheckLines(board, "X"))
            {
                MessageBox.Show("X wins!");
                ResetBoard();
            }
            else if (CheckLines(board, "O"))
            {
                MessageBox.Show("O wins!");
                ResetBoard();
            }
            else if (IsBoardFull())
            {
                MessageBox.Show("It's a tie!");
                ResetBoard();
            }
        }

        // Checks for 3 in a row for the given player
        private bool CheckLines(string[,] board, string player)
        {
            for (int i = 0; i < 3; i++)
            {
                // Check rows and columns
                if ((board[i, 0] == player && board[i, 1] == player && board[i, 2] == player) ||
                    (board[0, i] == player && board[1, i] == player && board[2, i] == player))
                    return true;
            }

            // Check diagonals
            if ((board[0, 0] == player && board[1, 1] == player && board[2, 2] == player) ||
                (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player))
                return true;

            return false;
        }

        // Checks if all buttons are filled (for a tie)
        private bool IsBoardFull()
        {
            foreach (Control control in Controls)
            {
                Button button = control as Button;
                if (button != null && button.Text == "")
                    return false;
            }
            return true;
        }

        // Reset the board for a new game
        private void ResetBoard()
        {
            foreach (Control control in Controls)
            {
                Button button = control as Button;
                if (button != null)
                    button.Text = "";
            }
            isXTurn = true; // X starts again
        }
        private void btn22_Click(object sender, EventArgs e)
        {
            // just pass this
        }

        private void btnComputer_Click(object sender, EventArgs e)
        {
            // just pass this
        }
    }
}
