using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class Shield : Powerup
{
    float Duration;
    private string Name;

    Sprite Picture;
    public Shield(float SetDuration)
    {
        Picture = Resources.Load<Sprite>("Sprites/Shield");
        Name = "Schild";
        Duration = SetDuration;
    }
    public override void Use()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerLife>().ActivateShield(Duration);
    }

    public override string GetName()
    {
        return Name;
    }

    public override Sprite GetImage()
    {
        return Picture;
    }
}
