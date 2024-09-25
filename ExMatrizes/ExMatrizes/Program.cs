namespace ExMatrizes {
    internal class Program {
        static void Main(string[] args) {
            //double[,] mat = new double[2, 3];
            //Console.WriteLine(mat.Length);
            //Console.WriteLine(mat.GetLength(0));
            //Console.WriteLine(mat.GetLength(1));

            int size = int.Parse(Console.ReadLine());

            int[,] mat = new int[size, size];

            for (int i = 0; i < size; i++) {
                string[] vetLine = Console.ReadLine().Split();

                for (int j = 0; j < size; j++) {
                    mat[i, j] = int.Parse(vetLine[j]);
                }
            }

            Console.WriteLine("--------------");

            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < size; i++) { 
            Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            Console.Write("Negative numbers = ");
            int negativeNumbers = 0;
            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size; j++) {
                    if (mat[i, j] < 0) {
                        negativeNumbers++;
                    }
                }
            }
            Console.WriteLine(negativeNumbers);
        }
    }
}
