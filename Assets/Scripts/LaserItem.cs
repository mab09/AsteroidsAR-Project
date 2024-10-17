using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LaserItem : MonoBehaviour
{
    [SerializeField] private string _tagToCompare = "Player";
    [SerializeField] private int _powerUp = -10;
    [SerializeField] private UnityEvent OnPowerUp;

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag(_tagToCompare))
        {
            if (other.TryGetComponent(out Health health))
            {

                health.GainHealthandPowerUp(_powerUp);
                OnPowerUp?.Invoke();

            }
        }
    }
}
