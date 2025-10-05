using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int money = 1000;
    public int bankSavings = 0;

    public void Deposit(int amount)
    {
        money -= amount;
        bankSavings += amount;
    }
}
