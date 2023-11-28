namespace Program
{
    public class AdjacencyListMatrix<T>
    {
        private int size;

        // 그래프의 인접 리스트
        private List<T>[] adjacencyList;
        private T[] vertex;

        public AdjacencyListMatrix(int matrixSize)
        {
            vertex = new T[matrixSize];
            adjacencyList = new List<T>[matrixSize];
        }

        public void InsertEdge(int x, T y)
        {
            adjacencyList[x].Add(y);
        }

        public void InsertVertex(T data)
        {
            vertex[size++] = data;
        }

        void Display()
        {
            for(int i =0; i <adjacencyList.Length; i++) 
            {
                Console.WriteLine(adjacencyList[i]);
            }
        }
    }
}