using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGui : MonoBehaviour
{
    public int XButtonLocation;
    public int YLocation1;
    public int YLocation2;
    public Texture btnTexture;
    public bool Guiswitch;
    public int intensity=0;
    public int KlunkaKonsekvens;
  
    

    private void Start() {


        XButtonLocation = Screen.width/2;
        Guiswitch = false;
    }
    void OnGUI()
    {

        if (Guiswitch == false)
        {

            if (GUI.Button(new Rect(XButtonLocation, YLocation1, 100, 75), "Casual"))
            {
                Guiswitch = true;
                intensity = 1;


            }
            if (GUI.Button(new Rect(XButtonLocation, YLocation2, 100, 75), "Intense"))
            {
                Guiswitch = true;
                intensity = 2;
            }


        }



        if (Guiswitch == true)
        {
            if (GUI.Button(new Rect(0, 0, 50, 30), "Return"))
            {
                Guiswitch = false;
                intensity = 0;
                KlunkaKonsekvens=0;
            }


                if (GUI.Button(new Rect(0, YLocation1, 100, 75), "Klunka"))
                {
                KlunkaKonsekvens = 1;
                }
                if (GUI.Button(new Rect(0, YLocation2, 100, 75), "Konsekvens"))
                {
                KlunkaKonsekvens = 2;
                }


        }
    }
}
