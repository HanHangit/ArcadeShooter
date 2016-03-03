using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HPTextAnzeige : MonoBehaviour {

    //Public
   

    //private
    Text Anzeige;

    GUIVerwalter AnzeigeFuerLeben;


	// Use this for initialization
	void Start () {
        AnzeigeFuerLeben = GameObject.FindGameObjectWithTag("Player").GetComponent<GUIVerwalter>();
        AnzeigeFuerLeben.getLeben();
        //Anzeige = gameObject.GetComponent<Text>();
        Debug.Log(AnzeigeFuerLeben.getLeben());
        
    }
	
	// Update is called once per frame
	void Update () {
        Anzeige.text = "HPLebenhihi: "; //+ AnzeigeFuerLeben.ToString();
        Anzeige.text.ToString();
    }
   
}
