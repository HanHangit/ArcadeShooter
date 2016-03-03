using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class Shield : Powerup
{
    float Duration;


    public Sprite Picture;
    public Shield(float SetDuration)
    {
        Duration = SetDuration;
        SetName("Schild");
        SetImage(Picture);
    }
    public override void Use()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerLife>().ActivateShield(Duration);
    }

    
}
