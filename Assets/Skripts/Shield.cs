using UnityEngine;
using System.Collections;
using System;

public class Shield : Powerup
{
    float Duration;
    public Shield(float SetDuration)
    {
        Duration = SetDuration;
        SetName("Schild");
    }
    public override void Use()
    {
        Debug.Log("Shield Activate");
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerLife>().ActivateShield(Duration);
    }
}
