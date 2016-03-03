using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InventarAnzeige : MonoBehaviour {

    Quickslot QuickSlotInstanz;
    Sprite InventarPicture;
    public int iInventarPlatz;



	// Use this for initialization
	void Start () {
        QuickSlotInstanz = GameObject.FindGameObjectWithTag("Player").GetComponent<Quickslot>();
        InventarPicture = QuickSlotInstanz.GetItem(iInventarPlatz).GetImage();
        
	}
	
	// Update is called once per frame
	void Update () {
        //GUI.DrawTexture(GetComponent<RectTransform>().rect, InventarPicture);
        GetComponent<Image>().sprite = InventarPicture;
	}
}
