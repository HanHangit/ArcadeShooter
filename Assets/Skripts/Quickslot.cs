using UnityEngine;
using System.Collections;

public class Quickslot : MonoBehaviour {
    Powerup[] Inventar;
    bool[] FreeSpace;
	// Use this for initialization
	void Awake () {
        FreeSpace = new bool[9];
        Inventar = new Powerup[9];
        for (int i = 0; i < FreeSpace.Length; ++i)
            FreeSpace[i] = true;
	}

    public void AddItem(Powerup ToAdd)
    {
        for(int i = 0; i < FreeSpace.Length; ++i)
        {
            if (FreeSpace[i])
            {
                Inventar[i] = ToAdd;
                FreeSpace[i] = false;
            }
        }
    }

    public void UseItem(int Number)
    {
        Number--;
        if (!FreeSpace[Number])
        {
            Inventar[Number].Use();
            FreeSpace[Number] = true;
            Debug.Log(Inventar[Number].GetName() + " aktiviert");
        }
    }
}
