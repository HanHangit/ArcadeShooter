using UnityEngine;
using System.Collections;
using System;

public class Speed : Powerup
{
    float Power;
    Speed(float power)
    {
        Power = power;
    }
    public override void Use()
    {
        throw new NotImplementedException();
    }
}
