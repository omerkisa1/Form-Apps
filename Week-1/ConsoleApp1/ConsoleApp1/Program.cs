using System;
using System.Collections.Generic;

namespace OOPExercises
{
    // Robot positions
    public struct Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

  
    public struct Step
    {
        public Position Position { get; set; }
        public int Steps { get; set; }

        public Step(Position position, int steps)
        {
            Position = position;
            Steps = steps;
        }
    }

    // 1. Spiral Matrix
    public class SpiralMatrix
    {
        private int N;
        private int[,] matrix;

        public SpiralMatrix(int size)
        {
            N = size;
            matrix = new int[N, N];
            FillSpiral();
        }

        private void FillSpiral()
        {
            int value = 1;
            int top = 0, bottom = N - 1;
            int left = 0, right = N - 1;

            while (top <= bottom && left <= right)
            {
                // to the right
                for (int i = left; i <= right; i++)
                {
                    matrix[top, i] = value++;
                }
                top++;

                // to the bottom
                for (int i = top; i <= bottom; i++)
                {
                    matrix[i, right] = value++;
                }
                right--;

                // to the left
                if (top <= bottom)
                {
                    for (int i = right; i >= left; i--)
                    {
                        matrix[bottom, i] = value++;
                    }
                    bottom--;
                }

                // to the top
                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--)
                    {
                        matrix[i, left] = value++;
                    }
                    left++;
                }
            }
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }

    // 2. Matrix Multiplication
    public class MatrixMultiplication
    {
        private int[,] matrixA;
        private int[,] matrixB;
        private int N;
        private int[,] result;

        public MatrixMultiplication(int[,] a, int[,] b)
        {
            if (a.GetLength(0) != b.GetLength(0) || a.GetLength(1) != b.GetLength(1))
                throw new ArgumentException("Matrices must be of the same size.");

            N = a.GetLength(0);
            matrixA = a;
            matrixB = b;
            result = new int[N, N];
        }

        public int[,] Multiply()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < N; k++)
                    {
                        result[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }
            return result;
        }

        public void PrintResult()
        {
            Multiply();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(result[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }

    // 3. Sum of Primes up to N
    public class PrimeSum
    {
        private int N;

        public PrimeSum(int n)
        {
            N = n;
        }

        public long CalculateSum()
        {
            if (N < 2)
                return 0;

            bool[] isPrime = new bool[N + 1];
            for (int i = 2; i <= N; i++)
                isPrime[i] = true;

            for (int i = 2; i * i <= N; i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * i; j <= N; j += i)
                        isPrime[j] = false;
                }
            }

            long sum = 0;
            for (int i = 2; i <= N; i++)
            {
                if (isPrime[i])
                    sum += i;
            }
            return sum;
        }
    }

    // 4. Robots Saving Nodes
    public class RobotsSaveNodes
    {
        private int[,] grid;
        private int N;
        private List<Position> robotPositions;
        private bool[,] visited;
        private int totalSaved;

        public RobotsSaveNodes(int[,] gridInput, List<Position> robots)
        {
            grid = gridInput;
            N = grid.GetLength(0);
            robotPositions = robots;
            visited = new bool[N, N];
            totalSaved = 0;
        }

        public int CalculateSavedNodes()
        {
            foreach (var robot in robotPositions)
            {
                BFS(robot.X, robot.Y);
            }
            return totalSaved;
        }

        private void BFS(int startX, int startY)
        {
            if (startX < 0 || startX >= N || startY < 0 || startY >= N)
                return;
            if (grid[startX, startY] == 0 || visited[startX, startY])
                return;

            Queue<Position> queue = new Queue<Position>();
            Position start = new Position(startX, startY);
            queue.Enqueue(start);
            visited[startX, startY] = true;
            totalSaved++;

            int[] dx = { -1, 1, 0, 0 };
            int[] dy = { 0, 0, -1, 1 };

            while (queue.Count > 0)
            {
                Position current = queue.Dequeue();

                for (int dir = 0; dir < 4; dir++)
                {
                    int newX = current.X + dx[dir];
                    int newY = current.Y + dy[dir];

                    if (newX >= 0 && newX < N && newY >= 0 && newY < N &&
                        grid[newX, newY] == 1 && !visited[newX, newY])
                    {
                        Position newPos = new Position(newX, newY);
                        queue.Enqueue(newPos);
                        visited[newX, newY] = true;
                        totalSaved++;
                    }
                }
            }
        }
    }

    // 5. Labyrinth Shortest Path
    public class LabyrinthShortestPath
    {
        private int[,] grid;
        private int N;

        public LabyrinthShortestPath(int[,] gridInput)
        {
            grid = gridInput;
            N = grid.GetLength(0);
        }

        public string FindShortestPath()
        {
            if (grid[0, 0] == 0 || grid[N - 1, N - 1] == 0)
                return "Yol Yok";

            bool[,] visited = new bool[N, N];
            Queue<Step> queue = new Queue<Step>();
            Position startPos = new Position(0, 0);
            Step startStep = new Step(startPos, 0);
            queue.Enqueue(startStep);
            visited[0, 0] = true;

            int[] dx = { -1, 1, 0, 0 };
            int[] dy = { 0, 0, -1, 1 };

            while (queue.Count > 0)
            {
                Step current = queue.Dequeue();
                Position pos = current.Position;
                int steps = current.Steps;

                if (pos.X == N - 1 && pos.Y == N - 1)
                    return $"En Kısa Yol: {steps} adım";

                for (int dir = 0; dir < 4; dir++)
                {
                    int newX = pos.X + dx[dir];
                    int newY = pos.Y + dy[dir];

                    if (newX >= 0 && newX < N && newY >= 0 && newY < N &&
                        grid[newX, newY] == 1 && !visited[newX, newY])
                    {
                        Position newPos = new Position(newX, newY);
                        Step newStep = new Step(newPos, steps + 1);
                        queue.Enqueue(newStep);
                        visited[newX, newY] = true;
                    }
                }
            }

            return "Yol Yok";
        }
    }

    // Main Program to Call the Classes
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Spiral Matrix Example
            Console.WriteLine("1. Spiral Matrix:");
            SpiralMatrix spiral = new SpiralMatrix(5);
            spiral.PrintMatrix();
            Console.WriteLine();

            // 2. Matrix Multiplication Example
            Console.WriteLine("2. Matrix Multiplication:");
            int[,] matrixA = {
                {1, 2, 3, 4, 5},
                {6, 7, 8, 9, 10},
                {11, 12, 13, 14, 15},
                {16, 17, 18, 19, 20},
                {21, 22, 23, 24, 25}
            };
            int[,] matrixB = {
                {25, 24, 23, 22, 21},
                {20, 19, 18, 17, 16},
                {15, 14, 13, 12, 11},
                {10, 9, 8, 7, 6},
                {5, 4, 3, 2, 1}
            };
            MatrixMultiplication multiply = new MatrixMultiplication(matrixA, matrixB);
            multiply.PrintResult();
            Console.WriteLine();

            // 3. Sum of Primes up to N
            Console.WriteLine("3. Sum of Primes up to N:");
            PrimeSum primeSum = new PrimeSum(10);
            Console.WriteLine($"Sum of primes up to 10: {primeSum.CalculateSum()}");
            Console.WriteLine();

            // 4. Robots Saving Nodes Example
            Console.WriteLine("4. Robots Saving Nodes:");
            int[,] grid = {
                {1, 1, 0, 1},
                {0, 1, 0, 0},
                {1, 1, 1, 0},
                {0, 0, 1, 1}
            };
            List<Position> robots = new List<Position>
            {
                new Position(0, 0),
                new Position(2, 2),
                new Position(3, 3)
            };
            RobotsSaveNodes robotsSave = new RobotsSaveNodes(grid, robots);
            Console.WriteLine($"Total Saved Nodes: {robotsSave.CalculateSavedNodes()}");
            Console.WriteLine();

            // 5. Labyrinth Shortest Path Example
            Console.WriteLine("5. Labyrinth Shortest Path:");
            int[,] labyrinth = {
                {1, 0, 0, 0},
                {1, 1, 0, 1},
                {0, 1, 1, 1},
                {0, 0, 0, 1}
            };
            LabyrinthShortestPath labyrinthPath = new LabyrinthShortestPath(labyrinth);
            Console.WriteLine(labyrinthPath.FindShortestPath());
            Console.WriteLine("\nProgramı sonlandırmak için bir tuşa basın...");
            Console.ReadKey(); 
        }
    }
}
