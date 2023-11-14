namespace Class4th
{
    public abstract class Unit
    {
        int health;
        int attack;
        int defense;

        public virtual void Information()
        {
            Console.WriteLine("health : " + health);
            Console.WriteLine("attack : " + attack);
            Console.WriteLine("defense : " + defense);
        }

        public abstract void Skill();
    }
}