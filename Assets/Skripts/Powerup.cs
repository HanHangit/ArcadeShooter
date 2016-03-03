using UnityEngine;
using System.Collections;

public abstract class Powerup : MonoBehaviour {
    string Name;

    public void SetName(string bezeichnung)
    {
        Name = bezeichnung;
    }
    public abstract void Use();

    public string GetName()
    {
        return Name;
    }
}
