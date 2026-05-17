using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int MaxHealth = 100;
    private int CurrentHealth;

    void Start()
    {
        CurrentHealth = MaxHealth;
    }

    public void Damage(int value)
    {
        CurrentHealth = CurrentHealth - value;
        Debug.Log(gameObject.name + " Health :" + CurrentHealth);

        if (CurrentHealth <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Debug.Log("Enemy Destroy");

        if (WaveManager.Instance != null)
        {
            WaveManager.Instance.EnemyDied();
        }

        Destroy(gameObject);
    }
}
