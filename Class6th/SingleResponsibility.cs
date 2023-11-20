namespace Class6th
{
    #region 단일 책임 원칙
    // 하나의 객체는 반드시 하나의 동작만을 수행해야 합니다.

    public class Monster
    {
        public string name;
        public int attack;
        public int health;

        public Monster(string name, int attack, int health)
        {
            this.name = name;
            this.attack = attack;
            this.health = health;
        }

        public void Patrol()
        {
            Console.WriteLine("순찰하는 중...");
        }

        // Monster의 정보를 보내주는 함수
        public string Representation()
        {
            return "\n이름 : " + name + "\n체력 : " + health + "\n공격력 : " + attack;
        }
    }

    public class Information
    {
        public void MonseterInfo(Monster monster)
        {
            Console.WriteLine(monster.Representation());
        }
    }

    #endregion
}