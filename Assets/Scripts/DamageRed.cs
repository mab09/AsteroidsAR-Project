using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageRed : MonoBehaviour
{
    public void OnDamage()
    {
        StartCoroutine(RedDamageRoutine());
    }

    IEnumerator RedDamageRoutine()
    {
        
        gameObject.GetComponent<Image>().color = Color.red;
        yield return null;
        gameObject.GetComponent<Image>().color = Color.clear;
    }
}
