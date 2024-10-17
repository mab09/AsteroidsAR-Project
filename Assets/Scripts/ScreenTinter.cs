using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenTinter : MonoBehaviour
{
    private bool _lock = false;

    public void OnDamage()
    {
        if (_lock) {  return; }
        StartCoroutine(RedDamageRoutine());
    }

    public void OnHeal()
    {
        if (_lock) { return; }
        StartCoroutine(GreenHealRoutine());
    }

    public void OnPowerUp()
    {
        StopAllCoroutines();
        StartCoroutine(PurplePowerRoutine());
    }

    IEnumerator RedDamageRoutine()
    {
        gameObject.GetComponent<Image>().color = Color.red;
        yield return null;
        if (!_lock) gameObject.GetComponent<Image>().color = Color.clear;
    }

    IEnumerator GreenHealRoutine()
    {
        gameObject.GetComponent<Image>().color = new Color(0.0f, 1.0f, 0.0f, 0.05f);
        yield return new WaitForSeconds(0.5f);
        if(!_lock) gameObject.GetComponent<Image>().color = Color.clear;
    }

    IEnumerator PurplePowerRoutine()
    {

        _lock = true;
        gameObject.GetComponent<Image>().color = new Color(0.62f, 0.12f, 0.94f, 0.05f);
        yield return new WaitForSeconds(10.0f);
        gameObject.GetComponent<Image>().color = Color.clear;
        _lock = false;
    }
}
