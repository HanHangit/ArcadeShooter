using UnityEngine;
using System.Collections;

public class PlayerLife : MonoBehaviour {

    bool shield;
    float fHp;
    float Clock;

    public float GetHp()
    {
        return fHp;
    }
    public void Sethp(float Life)
    {
        fHp = Life;
    }

    public void ActivateShield(float time)
    {
        shield = true;
        Clock = time;
    }

    void DeactivateShield()
    {
        shield = false;
    }

    public void AddLife(float Life)
    {
        if(Life > 0 || (Life < 0 && !shield))
            fHp += Life;
        if (fHp <= 0)
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if(shield)
        {
            Clock -= Time.deltaTime;
            if (Clock <= 0)
                DeactivateShield();
        }
    }



}
