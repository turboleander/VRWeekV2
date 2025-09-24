using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public float maxEnemyHP = 100;

    public UnityEvent OnTakeDamage;
    public UnityEvent OnDead;

    private float currentEnemyHP;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentEnemyHP = maxEnemyHP;
    }

    public void takeDamage(float damageAmount)
    {
        if (!IsDead())
        {
            OnTakeDamage.Invoke();
            currentEnemyHP -= damageAmount;

            if (IsDead())
            {
                OnDead.Invoke();
            }
        }
    }

    public bool IsDead()
    {
        return currentEnemyHP <= 0;
    }
    
}
