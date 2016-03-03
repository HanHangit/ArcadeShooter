using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelPanel : MonoBehaviour {
    Text Anzeige;
    GUIVerwalter GUIInstanz;
    // Use this for initialization
    void Start () {

        GUIInstanz = GameObject.FindGameObjectWithTag("Verwaltung").GetComponent<GUIVerwalter>();
        Anzeige = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {

        Anzeige.text = "Level: " + GUIInstanz.GetLevel();
    }
}
