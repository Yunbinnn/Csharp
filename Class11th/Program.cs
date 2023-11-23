namespace Class11th
{
    internal class Program
    {
        public static int BinarySearch_Recursive(int[] arr, int target, int left, int right)
        {
            if (left > right) return -1;

            Console.WriteLine(target + " 검색 시작\n");

            // 1. 배열의 가운데 요소의 인덱스를 pivot으로 설정합니다.
            int pivot = (left + right) / 2;

            Console.WriteLine("pivot 값 : " + pivot);
            Console.WriteLine("탐색 시작\n");

            // 2. [pivot]의 값이 찾고자 하는 요소가 같다면 검색완료
            if (arr[pivot] == target)
            {
                Console.WriteLine("탐색 완료");
                return pivot;
            }

            // 3. [pivot의 값이 찾는 값보다 크다면 left ~ pivot 사이를 검색합니다.]
            else if (arr[pivot] > target)
            {
                Console.WriteLine("재탐색 중...\n");
                return BinarySearch_Recurrsive(arr, target, left, pivot - 1);
            }

            // 4. [pivot의 값이 찾는 값보다 작다면 pivot ~ right 사이를 검색합니다.]
            else
            {
                Console.WriteLine("재탐색 중...\n");
                return BinarySearch_Recurrsive(arr, target, pivot + 1, right);
            }
        }

        public static void Binary_Search(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                // 1. 배열의 가운데 요소의 인덱스를 pivot으로 설정합니다.
                int pivot = (left + right) / 2;

                // 2. [pivot]의 값이 찾고자 하는 요소가 같다면 검색완료
                if (array[pivot] == target)
                {
                    Console.WriteLine("검색 완료\narray[pivot] : " + array[pivot]);
                    return;
                } // 3. [pivot의 값이 찾는 값보다 크다면 left ~ pivot 사이를 검색합니다.]
                else if (array[pivot] > target)
                {
                    right = pivot - 1;
                }
                else // 4. [pivot의 값이 찾는 값보다 작다면 pivot ~ right 사이를 검색합니다.]
                {
                    left = pivot + 1;
                }
            }

            Console.WriteLine("Not value Found");
        }

        static void Main()
        {
            #region 이진 탐색
            // 오름차순으로 정렬된 리스트에서 특정한 값의 위치를 찾는 알고리즘입니다.

            //int[] arr = new int[10] { 5, 7, 1, 6, 3, 4, 9, 10, 8, 2 };
            //Array.Sort(arr);       // 1, 2, 3, 4, 5, 6, 7, 8, 9, 10

            //Console.WriteLine("해당 값이 담긴 배열의 번호 : " + BinarySearch_Recursive(arr, 10, 0, arr.Length - 1));

            //Binary_Search(arr, 10);

            #endregion
        }
    }
}