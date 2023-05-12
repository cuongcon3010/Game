using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New CharacterData", menuName = "CharacterData")]
public class CharacterData : ScriptableObject
{
    public string Name;
    public string type;
    public Sprite IMG;

    public int LV;

    public int HP;
    public int STR;
    public int SPD;
    public int DEF;
}
