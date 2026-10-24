public class Turtle : Character
{
    public Turtle(int h = 2000000000) : base(h) { }

    public int PyramidPounce()
    {
        int damage = 10000000;
        ChangeStamina(damage);
        return damage;
    }

    public int TestudineTumble()
    {
        int damage = 1000000;
        ChangeStamina(damage);
        return damage;
    }

    public int SupernovaExplosion()
    {
        int damage = 1000000000;
        ChangeStamina(damage);
        return damage;
    }

    public int SlowStabbing()
    {
        int damage = 100000;
        ChangeStamina(damage);
        return damage;
    }
}
