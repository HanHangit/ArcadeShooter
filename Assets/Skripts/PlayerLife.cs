using UnityEngine;
using System.Collections;

public class PlayerLife : MonoBehaviour
{

    bool shield;
    float fHp;
    float ShieldClock;
    float SpeedClock;
    float Speed;
    float GroundSpeed;

    public float GetHp()
    {
        return fHp;
    }
    public void Sethp(float Life)
    {
        fHp = Life;
    }
    public float GetSpeed()
    {
        return Speed;
    }
    public void SetSpeed(float set)
    {
        Speed = GroundSpeed = set;
    }

    public void ActivateSpeed(float time, float power)
    {
        SpeedClock = time;
        Speed = GroundSpeed * power;
    }

    public void DeactivateSpeed()
    {
        Speed = GroundSpeed;
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
        if (Life > 0 || (Life < 0 && !shield))
            fHp += Life;
        if (fHp <= 0)
        {
            Respawn();
        }
    }

    void Respawn()
    {
        Debug.Log("Respawn");
    }

    void Update()
    {
        if (shield)
        {
            ShieldClock -= Time.deltaTime;
            if (ShieldClock <= 0)
                DeactivateShield();
        }
        if (SpeedClock > 0)
            SpeedClock -= Time.deltaTime;
        if (SpeedClock <= 0)
            DeactivateSpeed();
    }



}
