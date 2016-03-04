using UnityEngine;
using System.Collections;
using System;

public class Empty : Powerup
{
    Sprite Picture;

    private string Name;

    public override void Use()
    {
        throw new NotImplementedException();
    }

    public override string GetName()
    {
        return Name;
    }

    public override Sprite GetImage()
    {
        return Picture;
    }

    public Empty()
    {
        Name = "Empty";
        Picture = Resources.Load<Sprite>("Sprites/Book");
    }
}
