namespace ExercicioMatrizes {
    internal class Program {
        static void Main(string[] args) {
            string[] matSize = Console.ReadLine().Split(" ");

            int matLine = int.Parse(matSize[0]);
            int matCollumn = int.Parse(matSize[1]);

            int[,] mat = new int[matLine, matCollumn];

            for (int i = 0; i < matLine; i++) {
                string[] lineData = Console.ReadLine().Split(" ");
                for (int j = 0; j < matCollumn; j++) {
                    mat[i, j] = int.Parse(lineData[j]);
                }
            }

            int searchedNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < matLine; i++) {
                for (int j = 0; j < matCollumn; j++) {
                    if (mat[i, j] == searchedNumber) {
                        Console.WriteLine("Position {0},{1}: ", i, j);
                        if (j > 0) {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (j < matCollumn-1) {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i > 0) {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (i < matLine-1) {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
