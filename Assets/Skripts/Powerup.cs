using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public abstract class Powerup : MonoBehaviour {

    public abstract void Use();
    public abstract string GetName();
    public abstract Sprite GetImage();


}
