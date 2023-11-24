namespace Class12th
{
    internal class Program
    {
        private static void Quick_Sort(int[] array, int start, int end)
        {
            // 원소가 1개인 경우 함수 종료
            if (start >= end) return;

            // pivot 값 설정 (배열의 첫번째 값)
            int pivot = start;

            // left 값 : pivot의 다음 배열 번호
            int left = start + 1;

            // right : 배열의 마지막 번호
            int right = end;

            // 서로 엇갈릴 때까지 반복
            while (left <= right)
            {
                // pivot 값보다 큰 값을 만날 때까지 오른쪽으로 한칸씩 이동
                while (left <= end && array[left] <= array[pivot]) left++;

                // pivot 값보다 작은 값을 만날 때까지 왼쪽으로 한칸씩 이동
                while (right > start && array[right] >= array[pivot]) right--;

                if (left > right)
                {
                    Swap(array, right, pivot);
                }
                else
                {
                    Swap(array, left, right);
                }
            }

            Quick_Sort(array, start, right - 1); // 왼쪽 정렬 수행
            Quick_Sort(array, right + 1, end);   // 오른쪽 정렬 수행
        }

        private static void Swap(int[] arr, int a, int b)
        {
            (arr[b], arr[a]) = (arr[a], arr[b]);
        }

        static void Main()
        {
            #region 퀵 정렬
            // 기준점을 획득한 다음 해당 기준점을 기준으로
            // 배열을 나누고 한 쪽에는 기준점보다 작은 항목들이
            // 위치하고 다른 쪽에는 기준점 보다 큰 항목들이 위치합니다.

            // 나뉘어진 하위 배열에 대해 재귀적으로 퀵 정렬을 호출하여
            // 모든 배열이 기본 배열이 될 때까지 반복하면서 정렬하는 알고리즘입니다.

            // 시간 복잡도 : O(log n)

            /*
            int[] array = new int[10] { 5, 7, 10, 4, 1, 9, 3, 8, 6, 2 };

            Console.Write("정렬 전 : ");
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("\n");

            Quick_Sort(array, 0, array.Length - 1);

            Console.Write("정렬 후 : ");
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("");*/

            #endregion
        }
    }
}