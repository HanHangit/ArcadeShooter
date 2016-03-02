using UnityEngine;
using System.Collections;

public class PlayerLife : MonoBehaviour {

    bool shield;
    float fHp;
    float ShieldClock;
    float SpeedClock;

    public float GetHp()
    {
        return fHp;
    }
    public void Sethp(float Life)
    {
        fHp = Life;
    }

    public void ActivateSpeed(float time, float power)
    {
        SpeedClock = time;
    }

    public void DeactivateSpeed()
    {

    }

    public void ActivateShield(float time)
    {
        shield = true;
        ShieldClock = time;
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
            ShieldClock -= Time.deltaTime;
            if (ShieldClock <= 0)
                DeactivateShield();
        }
    }



}
