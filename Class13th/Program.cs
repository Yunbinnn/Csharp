namespace Class13th
{
    internal class Program
    {
        private static void Merge_Sort(int[] array, int start, int end)
        {
            if (start < end)
            {
                int mid = (start + end) / 2;

                Merge_Sort(array, start, mid);
                Merge_Sort(array, mid + 1, end);

                C_Merge(array, start, mid, end);
            }
        }

        private static void Merge(int[] array, int start, int mid, int end)
        {
            Console.WriteLine("배열 정렬 및 결합 실행중...\n");

            int[] leftSide = new int[mid - start + 1];
            int[] rightSide = new int[end - mid];

            int beginIndex = start;
            int leftIndex;
            int rightIndex;

            for (leftIndex = 0; leftIndex < leftSide.Length; leftIndex++, beginIndex++)
            {
                leftSide[leftIndex] = array[beginIndex];
            }

            Console.Write("왼쪽 배열 : ");
            foreach (var element in leftSide)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("\n");

            for (rightIndex = 0; rightIndex < rightSide.Length; rightIndex++, beginIndex++)
            {
                rightSide[rightIndex] = array[beginIndex];
            }

            Console.Write("오른쪽 배열 : ");
            foreach (var element in rightSide)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("\n");

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

            while (leftIndex < leftSide.Length)
            {
                array[beginIndex] = leftSide[leftIndex];
                leftIndex++;
                beginIndex++;
            }

            while (rightIndex < rightSide.Length)
            {
                array[beginIndex] = rightSide[rightIndex];
                rightIndex++;
                beginIndex++;
            }
        }

        static void C_Merge(int[] array, int start, int middle, int end)
        {
            int[] leftArray = new int[middle - start + 1];
            int[] rightArray = new int[end - middle];

            int index = start;
            int left;
            int right;

            for (left = 0; index <= middle; left++)
            {
                leftArray[left] = array[index++];
            }

            for (right = 0; index <= end; right++)
            {
                rightArray[right] = array[index++];
            }

            index = start;

            left = 0;
            right = 0;

            while (left < leftArray.Length && right < rightArray.Length)
            {
                if (leftArray[left] < rightArray[right])
                {
                    array[index] = leftArray[left++];
                }
                else
                {
                    array[index] = rightArray[right++];
                }

                index++;
            }

            while (left < leftArray.Length)
            {
                array[index++] = leftArray[left++];
            }

            while (right < rightArray.Length)
            {
                array[index++] = rightArray[right++];
            }
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

            /*
            int[] array = new int[] { 6, 9, 2, 7, 5, 8, 3, 10, 4, 1 };

            Console.Write("정렬 전 : ");
            foreach (int element in array)
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
            Console.WriteLine("");*/

            #endregion
        }
    }
}