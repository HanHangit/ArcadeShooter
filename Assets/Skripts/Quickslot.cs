using UnityEngine;
using System.Collections;

public class Quickslot : MonoBehaviour {
    Powerup[] Inventar;
    bool[] FreeSpace;
    public int Slots;

	// Use this for initialization
	void Awake () {
        FreeSpace = new bool[Slots];
        Inventar = new Powerup[Slots];
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
                break;
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

    public Powerup GetItem(int Number) //Item an Position Number
    {
        if (!FreeSpace[Number])
        {
            return Inventar[Number];
        }
        else
            return new Empty();
            
    }
    

}
