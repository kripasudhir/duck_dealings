using System;

public class Duck : Character
{
    public Duck(int h) : base(h) { }

    public int DeathByThousandPecks()
    {
        // Using C#'s Random instead of ThreadLocalRandom
        int damage = 100000 * Random.Shared.Next(100, 1001);
        ChangeStamina(damage);
        return damage;
    }

    public int SonicQuack() // turtle hp - 100000 for next two turns
    {
        int damage = 10000000;
        ChangeStamina(damage);
        return damage;
    }

    public int FlamingFlippers() // turtle hp - 100000 for next two turns
    {
        int damage = 1000000;
        ChangeStamina(damage);
        return damage;
    }

    public int BillBash()
    {
        int damage = 1000000;
        ChangeStamina(damage);
        return damage;
    }
}
