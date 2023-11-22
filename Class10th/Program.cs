namespace Class10th
{
    internal class Program
    {
        static void Main()
        {
            #region 등차 수열 알고리즘

            // 등차 수열
            /*
            int firstTerm;       // 첫 항
            int commonDifferece; // 공차
            int size;            // 배열의 크기

            // Console.ReadLine() : string 타입으로만 값을 반환합니다.
            // string name = Console.ReadLine();

            // int.Parse() : int 타입으로 값을 반환합니다.
            Console.Write("첫 항의 값을 입력 : ");
            firstTerm = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("공차의 값 입력 : ");
            commonDifferece = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("배열의 크기 입력 : ");
            size = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            int[] array = new int[size];
            int[] array2 = new int[size];

            for (int i = 0; i < array2.Length; i++) array2[i] = i;

            Console.Write("for문 사용 : ");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] += firstTerm + commonDifferece * i;
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("\n");

            Console.Write("foreach문 사용 : ");

            foreach (var element in array2)
            {
                array2[element] = firstTerm + commonDifferece * element;
                Console.Write(array2[element] + " ");
            }

            Console.WriteLine("");*/

            #endregion

            #region 등비 수열 알고리즘

            /*
            int firstTerm;
            int commonRatio;
            int size;

            Console.Write("첫 항의 값을 입력 : ");
            firstTerm = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("공비의 값 입력 : ");
            commonRatio = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("배열의 크기 입력 : ");
            size = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            int[] array = new int[size];

            Console.Write("결과 : ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = firstTerm;
                Console.Write(array[i] + " ");
                firstTerm *= commonRatio;
            }
            Console.WriteLine("");*/

            #endregion

            #region 무명 형식

            /*
            // 이름이 존재하지 않는 객체 또는 변수를 의미합니다.
            var data = new { Name = "Data", Value = 10 };

            // 무명 형식의 경우 값을 읽기만 할 수 있습니다.
            // data.Name = "data"; <- Error

            Console.WriteLine("data.Name : " + data.Name);
            Console.WriteLine("data.Value : " + data.Value);*/

            #endregion
        }
    }
}