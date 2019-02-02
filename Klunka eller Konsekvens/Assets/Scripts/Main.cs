using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public StartGui SG;
    public Text texst;
    public string[] CasualKlunka;
    public string[] IntenseKlunka;
    public string[] CasualKonsekvens;
    public string[] IntenseKonsekvens;

    public int randomCasualKlunka;
    public void Awake() {
        SG = GetComponent<StartGui>();
    }

    void Update()
    {
        if (SG.intensity == 1)
        {
            Casual();
            
        }
        if (SG.intensity == 2)
        {
            Intense();
        }

    }



    public void Casual()
    {
        if (SG.KlunkaKonsekvens == 1)
        {
           randomCasualKlunka = Random.Range(0, CasualKlunka.Length);
            string currentText;
            texst.text = randomCasualKlunka.ToString();
            print(texst);
            SG.KlunkaKonsekvens = 0;
        }
        if (SG.KlunkaKonsekvens == 2)
        {
            print("CasualKonsekvens");
        }


    }
    public void Intense()
    {
        if (SG.KlunkaKonsekvens == 1)
        {

        }
        if (SG.KlunkaKonsekvens == 2)
        {

        }
    }

}
