namespace Program
{
    internal class Program
    {
        private static void Merge_Sort(int[] array , int start, int end)
        {
            if (start < end)
            {
                int mid = (start + end) / 2;

                Merge_Sort(array, start, mid);
                Merge_Sort(array, mid + 1, end);

                Merge(array, start, mid, end);
            }
        }

        private static void Merge(int[] array, int start, int mid, int end)
        {
            int[] leftSide = new int[mid - start + 1];
            int[] rightSide = new int[end - mid];

            int beginIndex = start;
            int leftIndex;
            int rightIndex;

            for (leftIndex = 0; leftIndex <= mid; leftIndex++, beginIndex++) 
            {
                leftSide[leftIndex] = array[beginIndex];
            }

            beginIndex = start;

            for (rightIndex = 0; rightIndex <= end; rightIndex++, beginIndex++) 
            {
                rightSide[rightIndex] = array[beginIndex];
            }

            /*
            beginIndex = start;
            leftIndex = 0;
            rightIndex = 0;

            while (leftIndex < leftSide.Length && rightIndex < rightSide.Length)
            {
                if (leftSide[leftIndex] < rightSide[rightIndex])
                {
                    array[beginIndex] = leftSide[leftIndex];
                    leftIndex++;
                }
                else
                {
                    array[beginIndex] = rightSide[rightIndex];
                    rightIndex++;
                }

                beginIndex++;
            }

            leftIndex = 0;
            rightIndex = 0;

            while (leftIndex < leftSide.Length)
            {
                array[beginIndex] = leftSide[leftIndex];
                leftIndex++;
                beginIndex++;
            }

            while(rightIndex < rightSide.Length)
            {
                array[beginIndex] = rightSide[rightIndex];
                rightIndex++;
                beginIndex++;
            }
            */
        }

        static void Main()
        {
            #region 병합 정렬
            // 하나의 리스트를 두 개의 균등한 크기로 분할하고
            // 분할된 부분 리스트를 정렬한 다음, 두 개의 정렬된 부분
            // 리스트를 합하여 전체가 정렬된 리스트가 되게 하는 방법입니다.

            // 분할 : 입력 배열을 같은 크기의 2개의 부분 배열로 분할합니다.

            // 정복 : 부분 배열을 정렬하며, 부분 배열의 크기가 충분히 작지 않으면
            //        순환 호출을 이용하여 다시 분할 정복을 실행합니다.

            // 결합 : 정렬된 부분 배열들을 하나의 배열에 병합합니다.

            int[] array = new int[10] { 6, 9, 2, 7, 5, 8, 3, 10, 4, 1 };

            Console.Write("정렬 전 : ");
            foreach(int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("\n");

            Merge_Sort(array, 0, array.Length - 1);

            Console.Write("정렬 후 : ");
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("");

            #endregion
        }
    }
}