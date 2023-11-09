namespace First_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 자료형
            //byte stream = 1;
            //bool boolean = false;
            //char character = 'a';
            //short data = 100;
            //int integer = 200;
            //long longData = 300;

            //float[] buffer = new float[3];

            //buffer[0] = 1.15f;
            //buffer[1] = 1.25f;
            //buffer[2] = 1.35f;

            //double pi = 3.141592;
            //decimal decimalData;

            // Console.WriteLine() : 문자열을 출력하는 함수
            //Console.WriteLine("stream : " + stream);
            //Console.WriteLine("boolean : " + boolean);
            #endregion

            #region 박싱(BOXING)
            // 값 형식의 데이터를 참조 형식으로 변환하는 과정입니다.
            //int data = 5;

            //object obj = data;
            //Console.WriteLine("data의 값 : " + data);
            //Console.WriteLine("object의 값 : " + obj);
            #endregion

            #region 언박싱(UNBOXING)
            // 참조 타입의 데이터를 값 타입으로 변환하는 과정입니다.
            int count = 10;
            object obj1 = count;
            int result = (int)obj1;

            #endregion
        }
    }
}