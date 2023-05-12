using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIRender : MonoBehaviour
{
    public GameObject Stastus;
    public Text Name;
    public Text LV;
    public Text HP;
    public Text ATK;
    public Text SPD;
    public Text DEF;

    void Start()
    {
        Name.text = Stastus.GetComponent<CharacterManager>().Name;
        LV.text = "LV: " + Stastus.GetComponent<CharacterManager>().getLV().ToString();
        HP.text =  Stastus.GetComponent<CharacterManager>().getHP().ToString();
        ATK.text = "ATK: " + Stastus.GetComponent<CharacterManager>().getSTR().ToString();
        SPD.text = "SPD: " + Stastus.GetComponent<CharacterManager>().getSPD().ToString();
        DEF.text = "DEF: " + Stastus.GetComponent<CharacterManager>().getDEF().ToString();
    }
}
