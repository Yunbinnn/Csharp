namespace Program
{
    internal class Program
    {
        public static int BinarySearch(int[] arr, int target, int left, int right)
        {
            if (left > right) return -1;

            // 1. 배열의 가운데 요소의 인덱스를 pivot으로 설정합니다.
            int pivot = (left + right) / 2;

            // 2. [pivot]의 값이 찾고자 하는 요소가 같다면 검색완료
            if (arr[pivot] == target) return pivot;

            // 3. [pivot의 값이 찾는 값보다 크다면 left ~ pivot 사이를 검색합니다.]
            else if (arr[pivot] > target)
                return BinarySearch(arr, target, left, pivot - 1);

            // 4. [pivot의 값이 찾는 값보다 작다면 pivot ~ right 사이를 검색합니다.]
            else return BinarySearch(arr, target, pivot + 1, right);
        }

        static void Main()
        {
            #region 이진 탐색
            // 오름차순으로 정렬된 리스트에서 특정한 값의 위치를 찾는 알고리즘입니다.

            int[] arr = new int[10] { 5, 7, 1, 6, 3, 4, 9, 10, 8, 2 };
            Array.Sort(arr);

            Console.WriteLine(BinarySearch(arr, 10, 0, arr.Length - 1));

            #endregion
        }
    }
}