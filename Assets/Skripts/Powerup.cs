using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public abstract class Powerup : MonoBehaviour {
    string Name;
    Sprite Picture;

    public void SetName(string bezeichnung)
    {
        Name = bezeichnung;
    }
    public abstract void Use();

    public string GetName()
    {
        return Name;
    }

    public void SetImage(Sprite ImagePicture)
    {
        Picture = ImagePicture;
    }
    public Sprite GetImage()
    {
        return Picture;
    }


}
