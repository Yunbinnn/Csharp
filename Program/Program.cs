namespace Program
{
    internal class Program
    {
        static void Main()
        {
            #region 너비 우선 탐색(BFS, Breadth-First Search)

            AdjacencyListMatrix listMatrix = new(7);

            listMatrix.InsertEdge(0, 1);
            listMatrix.InsertEdge(0, 2);
            listMatrix.InsertEdge(1, 3);
            listMatrix.InsertEdge(1, 4);
            listMatrix.InsertEdge(2, 5);
            listMatrix.InsertEdge(2, 6);

            listMatrix.Breadth_First_Search(0);

            #endregion

            #region 깊이 우선 탐색(DFS, Depth-First Search)



            #endregion
        }
    }
}