using UnityEngine;
using System.Collections;
using System;

public class Empty : Powerup
{
    public override void Use()
    {
        throw new NotImplementedException();
    }
    public Empty()
    {
        SetName("Empty");
    }
}
