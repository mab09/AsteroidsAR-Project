using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{

    [SerializeField] private int _maxHealth = 100;
    [SerializeField] private int _currentHealth = 100;
    [SerializeField] private UnityEvent<int> OnReceiveDamage;
    [SerializeField] private UnityEvent OnZeroHealth;
    [SerializeField] private UnityEvent<int> OnReceiveHealth;
    [SerializeField] private UnityEvent OnReceivePowerUp;

    private void Start()
    {
        _currentHealth = _maxHealth;
    }
    public int CurrentHealth
    {
        get => _currentHealth;
        set => _currentHealth = value;
    }

    public int MaxHealth
    {
        get => _maxHealth;
        set => _maxHealth = value;
    }

    public void ReceiveDamage(int damageAmount)
    {
        CurrentHealth -= damageAmount;
        OnReceiveDamage?.Invoke(CurrentHealth);
        if (CurrentHealth <= 0)
        {
            OnZeroHealth?.Invoke();
        }
    }

    public void GainHealthandPowerUp(int gainAmount)    //if gainAmount is negative, then its a powerUp
    {

        if (gainAmount < 0)
        {
            OnReceivePowerUp?.Invoke();
        }
        else
        {
            _currentHealth += gainAmount;
            _currentHealth = Mathf.Clamp(_currentHealth, 0, _maxHealth);
            OnReceiveHealth?.Invoke(_currentHealth);
        }
    }


}
