using TMPro;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    [SerializeField] private GameObject battlePanel;
    [SerializeField] private TMP_Text duckHpText;
    [SerializeField] private TMP_Text turtleHpText;
    [SerializeField] private TMP_Text battleLog;
    [SerializeField] private TestDuckMovement duckMovement;
    private Duck duck;
    private Turtle turtle;
    private bool inBattle;
    public void StartBattle() 
    {
        duck = new Duck(1_000_000_000);
        turtle = new Turtle();
        battlePanel.SetActive(true);
        duckMovement.enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        inBattle = true;
        battleLog.text = "Turtie blocks your way!";
        UpdateTexts();
    }
    public void UpdateTexts()
    {
        duckHpText.text = "Duck HP: " + duck.GetHP().ToString("N0");
        turtleHpText.text = "Turtie HP: " + turtle.GetHP().ToString("N0");
    }
    public void UsePecks()
    {
        if (!inBattle) return;
        int damage = duck.DeathByThousandPecks();
        turtle.TakeDamage(damage);
        battleLog.text = "Duck used Thousand Pecks! " + damage.ToString("N0") + " damage!";
        UpdateTexts();
        if (CheckEnd()) return;
        TurtleTurn();
    }
    public void UseQuack()
    {
        if (!inBattle) return;
        int damage = duck.SonicQuack();
        turtle.TakeDamage(damage);
        battleLog.text = "Duck used Sonic Quack! " + damage.ToString("N0") + " damage!";
        UpdateTexts();
        if (CheckEnd()) return;
        TurtleTurn();
    }
    public void UseFlippers()
    {
        if (!inBattle) return;
        int damage = duck.FlamingFlippers();
        turtle.TakeDamage(damage);
        battleLog.text = "Duck used Flaming Flippers! " + damage.ToString("N0") + " damage!";
        UpdateTexts();
        if (CheckEnd()) return;
        TurtleTurn();
    }
    public void UseBash()
    {
        if (!inBattle) return;
        int damage = duck.BillBash();
        turtle.TakeDamage(damage);
        battleLog.text = "Duck used Bill Bash! " + damage.ToString("N0") + " damage!";
        UpdateTexts();
        if (CheckEnd()) return;
        TurtleTurn();
    }
    private void TurtleTurn()
    {
        int roll = Random.Range(0, 100);
        int damage;
        string moveName;
        if (roll < 5) { damage = turtle.SupernovaExplosion(); moveName = "Supernova Explosion"; }
        else if (roll < 37) { damage = turtle.PyramidPounce(); moveName = "Pyramid Pummel"; }
        else if (roll < 69) { damage = turtle.TestudineTumble(); moveName = "Testudine Tumble"; }
        else { damage = turtle.SlowStabbing(); moveName = "Slow Stabbing"; }
        duck.TakeDamage(damage);
        battleLog.text += "\nTurtie used " + moveName + "! " + damage.ToString("N0") +" damage!";
        UpdateTexts();
        CheckEnd();
    }
    private bool CheckEnd()
    {
        if(turtle.GetHP() <= 0)
        {
            battleLog.text += "\nYOU WIN!";
            inBattle = false;
            return true;
        }
        else if(duck.GetHP() <= 0)
        {
            battleLog.text += "\nYOU LOSE!";
            inBattle = false;
            return true;
        }
        else { return false; }
    }
}
