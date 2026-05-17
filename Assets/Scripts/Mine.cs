using UnityEngine;

public class Mine : MonoBehaviour
{
    public int coinsPerTick = 2;      
    public float tickInterval = 1f;  

    void Start()
    {
        InvokeRepeating(nameof(Produce), tickInterval, tickInterval);
    }

    void Produce()
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.AddCoins(coinsPerTick);
        }
    }

}
