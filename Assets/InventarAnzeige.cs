using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InventarAnzeige : MonoBehaviour {

    Quickslot QuickSlotInstanz;
    Sprite InventarPicture;
    public int iInventarPlatz;
    RectTransform PanelPosition;
    Canvas canvas;
    Vector2 Position2D;
    Image ImageInstanz;



	// Use this for initialization
	void Start () {
        QuickSlotInstanz = GameObject.FindGameObjectWithTag("Player").GetComponent<Quickslot>();
        PanelPosition = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
        Position2D = new Vector2(PanelPosition.sizeDelta.x, PanelPosition.sizeDelta.y);
        Debug.Log(Position2D);
        Debug.Log(PanelPosition.rect);
        ImageInstanz = GetComponent<Image>();
        
    }
	
	// Update is called once per frame
	void Update () {
        InventarPicture = QuickSlotInstanz.GetItem(iInventarPlatz).GetImage();
        ImageInstanz.sprite = InventarPicture;
        //Debug.Log(InventarPicture.name);
	}
}
