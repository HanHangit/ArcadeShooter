using UnityEngine;
using System.Collections;
using System;

public class Speed : Powerup
{
    float Power;
    float Time;
    public Speed(float time, float power)
    {
        Time = time;
        Power = power;
        SetName("Speed");
    }
    public override void Use()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerLife>().ActivateSpeed(Time, Power);
    }
}
