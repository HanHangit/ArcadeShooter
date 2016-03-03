using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GegnerAnzeige : MonoBehaviour {

    GUIVerwalter GUIINstanz;
    Text Anzeige;
	// Use this for initialization
	void Start () {
        GUIINstanz = GameObject.FindGameObjectWithTag("Verwaltung").GetComponent<GUIVerwalter>();
        Anzeige = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        Anzeige.text = GUIINstanz.GetGegnerAnzeige();
	}
}
