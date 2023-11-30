namespace Class15th
{
    internal class Program
    {
        static void Main()
        {
            #region 너비 우선 탐색(BFS, Breadth-First Search)
            // root 노드에서 시작해서 인접한 노드를 먼저 탐색하는 방법입니다.

            /*
            AdjacencyListMatrix listMatrix = new(7);

            listMatrix.InsertEdge(0, 1);
            listMatrix.InsertEdge(0, 2);
            listMatrix.InsertEdge(1, 3);
            listMatrix.InsertEdge(1, 4);
            listMatrix.InsertEdge(2, 5);
            listMatrix.InsertEdge(2, 6);

            listMatrix.Breadth_First_Search(0);
            */

            #endregion

            #region 깊이 우선 탐색(DFS, Depth-First Search)
            // root 노드에서 시작해서 다음 분기로 넘어가기 전에
            // 해당 분기를 완벽하게 탐색하는 방법입니다.

            /*
            AdjacencyListMatrix listMatrix = new(7);

            listMatrix.InsertEdge(0, 1);
            listMatrix.InsertEdge(0, 2);
            listMatrix.InsertEdge(1, 3);
            listMatrix.InsertEdge(1, 4);
            listMatrix.InsertEdge(2, 5);
            listMatrix.InsertEdge(2, 6);

            listMatrix.Depth_First_Search(0);*/

            #endregion
        }
    }
}
