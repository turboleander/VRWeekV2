using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public float maxEnemyHP = 100;

    public UnityEvent OnTakeDamage;
    public UnityEvent OnDead;

    public float currentHealth;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxEnemyHP;
    }

    public void takeDamage(float damageAmount)
    {
        if (!IsDead())
        {
            OnTakeDamage.Invoke();
            currentHealth -= damageAmount;

            if (IsDead())
            {
                OnDead.Invoke();
            }
        }
    }

    public bool IsDead()
    {
        return currentHealth <= 0;
    }
    
}
