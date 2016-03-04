using UnityEngine;
using System.Collections;
using System;

public class Speed : Powerup
{
    Sprite Picture;

    string Name;
    float Power;
    float Time;
    public Speed(float time, float power)
    {
        Picture = Resources.Load<Sprite>("Sprites/Boots");
        Name = "Speed";
        Time = time;
        Power = power;
    }

    public override Sprite GetImage()
    {
        return Picture;
    }

    public override string GetName()
    {
        return Name;
    }

    public override void Use()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerLife>().ActivateSpeed(Time, Power);
    }
}
