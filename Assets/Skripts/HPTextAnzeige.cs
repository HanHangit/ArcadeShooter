using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HPTextAnzeige : MonoBehaviour
{

    //Public


    //private
    Text Anzeige;

    GUIVerwalter AnzeigeFuerLeben;


    // Use this for initialization
    void Start()
    {
        AnzeigeFuerLeben = GameObject.FindGameObjectWithTag("Verwaltung").GetComponent<GUIVerwalter>();
        Anzeige = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        Anzeige.text = "HP: " + AnzeigeFuerLeben.getLeben();
    }

}
