namespace Class5th
{
    internal class Wizard : Job
    {
        new int attack = 100;

        // this와 base 키워드 중에서는
        // this 키워드의 우선순위가 더 높습니다.
        public Wizard() : base(100)
        {
            Console.WriteLine("attack의 값 : " + base.attack);
            Console.WriteLine("health의 값 : " + health);
        }
    }
}