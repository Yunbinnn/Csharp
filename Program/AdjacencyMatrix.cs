namespace Program
{
    public class AdjacencyMatrix<T>
    {
        // 속성
        // 1. 정점의 수   (size)
        private int size;

        // 2. 정점의 이름 (vertex)
        private T[] vertex;

        // 3. 인접 행렬   (2차원 배열)
        private int[,] matrix;

        public AdjacencyMatrix(int matrixSize)
        {
            size = 0;
            vertex = new T[matrixSize];
            matrix = new int[matrixSize, matrixSize];
            Console.WriteLine("vertex size : " + vertex.Length);
        }

        public void InsertEdge(int x, int y)
        {
            matrix[x, y] = 1;
            matrix[y, x] = 1;
        }

        public void InsertVertex(T data)
        {
            vertex[size++] = data;
        }

        public void Display()
        {
            Console.WriteLine("");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}