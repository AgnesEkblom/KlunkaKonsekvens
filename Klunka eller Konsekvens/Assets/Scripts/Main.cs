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
    public int randomCasualKonsekvens;
    public int randomIntenseKlunka;
    public int randomIntenseKonsekvens;

    public void Awake() {
        SG = GetComponent<StartGui>();
    }

  void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (SG.intensity==1)
            Casual();
            if (SG.intensity == 2)
            Intense();
        }
    }



    public void Casual()
    {
        if (SG.KlunkaKonsekvens == 1)
        {
           randomCasualKlunka = Random.Range(0, CasualKlunka.Length);
            
            print(randomCasualKlunka);

        }
        if (SG.KlunkaKonsekvens == 2)
        {
            randomCasualKonsekvens = Random.Range(0, CasualKonsekvens.Length);

            print(randomCasualKonsekvens);

        }


    }
    public void Intense()
    {
        if (SG.KlunkaKonsekvens == 1)
        {
            randomIntenseKlunka = Random.Range(0, IntenseKlunka.Length);

            print(randomIntenseKlunka);
        }
        if (SG.KlunkaKonsekvens == 2)
        {
            randomIntenseKonsekvens = Random.Range(0, IntenseKonsekvens.Length);

            print(randomIntenseKonsekvens);
        }
    }

}
