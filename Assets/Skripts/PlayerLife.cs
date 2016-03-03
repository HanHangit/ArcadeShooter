using UnityEngine;
using System.Collections;

public class PlayerLife : MonoBehaviour
{
    public float fHp;
    public float GroundSpeed;
    public int iRespawn;
    bool shield;
    float ShieldClock;
    float SpeedClock;
    float Speed;

    void Start()
    {
        Speed = GroundSpeed;
    }
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
        if (iRespawn > 0)
            Debug.Log("Respawn");
        else
            Debug.Log("TOD");
    }

    public int GetRespawn()
    {
        return iRespawn;
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
