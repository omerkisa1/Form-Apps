using System;
using System.Drawing;
using System.Windows.Forms;

namespace MainForm
{
    public partial class Form1 : Form
    { //this need better UI and development anyways 
        private const int GridSize = 20; 
        private const int ButtonSize = 30; 
        private Button[,] buttons = new Button[GridSize, GridSize];
        private bool[,] mines = new bool[GridSize, GridSize];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateGrid();
            PlaceMines();
        }

        private void CreateGrid()
        {
            for (int i = 0; i < GridSize; i++)
            {
                for (int j = 0; j < GridSize; j++)
                {
                    Button btn = new Button
                    {
                        Size = new Size(ButtonSize, ButtonSize),
                        Location = new Point(j * ButtonSize, i * ButtonSize),
                        Tag = new Point(i, j) 
                    };
                    btn.Click += Button_Click;
                    buttons[i, j] = btn;
                    Controls.Add(btn);
                }
            }
        }

        private void PlaceMines()
        {
            Random rand = new Random();
            int mineCount = 50; 
            while (mineCount > 0)
            {
                int row = rand.Next(GridSize);
                int col = rand.Next(GridSize);

                if (!mines[row, col])
                {
                    mines[row, col] = true;
                    mineCount--;
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                Point point = (Point)btn.Tag;
                int row = point.X;
                int col = point.Y;

                if (mines[row, col])
                {
                    btn.Text = "💣"; 
                    btn.BackColor = Color.Red;
                    MessageBox.Show("Oyun Bitti!");
                    RevealMines();
                }
                else
                {
                    btn.Enabled = false;
                    btn.Text = CountAdjacentMines(row, col).ToString();
                }
            }
        }

        private int CountAdjacentMines(int row, int col)
        {
            int count = 0;
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int newRow = row + i;
                    int newCol = col + j;

                    if (newRow >= 0 && newRow < GridSize && newCol >= 0 && newCol < GridSize)
                    {
                        if (mines[newRow, newCol])
                            count++;
                    }
                }
            }
            return count;
        }

        private void RevealMines()
        {
            for (int i = 0; i < GridSize; i++)
            {
                for (int j = 0; j < GridSize; j++)
                {
                    if (mines[i, j])
                    {
                        buttons[i, j].Text = "💣";
                        buttons[i, j].BackColor = Color.Red;
                    }
                }
            }
        }
    }
}
