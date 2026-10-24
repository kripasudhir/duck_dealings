using System;

public class MainClass
{
    private static Duck duck = new Duck(1000000000);

    public static void Main(string[] args)
    {
        bool gameEnded = false;

        // Pseudocode - will replace with actual implementation in Unity later
        while (!gameEnded)
        {
            // Walking, movement, etc.

            // Trigger battle if he encounters a character
            (bool boss, string character) inter_result = Interaction();

            if (inter_result.boss) // Checking if interaction is with a boss
            {
                Battle(inter_result.character);
            }
        }
    }

    public static void Battle(string boss)
    {
        int turn = 1;
        if (boss.Equals("turtle", StringComparison.OrdinalIgnoreCase))
        {
            Turtle turtie = new Turtle(2000000000);
            int duck_hp = duck.GetHP();
            int duck_stam = duck.GetStamina();
            int turtle_hp = turtie.GetHP();
            int turtle_stam = turtie.GetStamina();

            while (turtle_hp > 0 && duck_hp > 0)
            {
                // Battle loop logic goes here
            }
        }
    }

    private static (bool boss, string character) Interaction()
    {
        // Placeholder for interaction system
        return (false, string.Empty);
    }
}
