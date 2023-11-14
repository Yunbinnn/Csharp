namespace Program
{
    internal class Resolution
    {
        private const int width = 1440;

        // 런타임 상수는 생성자에서 단 한번 초기화를 할 수 있습니다.
        private readonly int height;

        public Resolution()
        {
            height = 3200;
        }
    }
}