using UnityEngine;
using System.Collections;

public class PlayerLife : MonoBehaviour {


    float fHp;

    public float GetHp()
    {
        return fHp;
    }
    public void Sethp(float Life)
    {
        fHp = Life;
    }

    public void AddLife(float Life)
    {
        fHp += Life;
        if (fHp <= 0)
        {
            Destroy(gameObject);
        }
    }



}
