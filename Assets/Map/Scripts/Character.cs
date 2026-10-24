public class Character
{
    protected int hp;
    protected int stamina;

    public Character(int h)
    {
        hp = h;
        stamina = h / 1000;
    }

    public void UpdateHP(int h_mod)
    {
        hp += h_mod;
        stamina = hp / 1000;
    }

    public int GetHP() => hp;

    public int GetStamina() => stamina;

    public int TakeDamage(int d)
    {
        UpdateHP(-1 * d);
        return hp;
    }

    public void ChangeStamina(int d)
    {
        double s = stamina - d / (double)hp;
        stamina = (int)s;
    }
}
