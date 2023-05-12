using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsManager : MonoBehaviour
{
    public GameObject Character;
    public GameObject Enemy;

    private void OnMouseDown() 
    {
        Character = gameObject;
    }
    private void OnMouseUp() {
        if(Character != null && Enemy != null)
        {
            Character.GetComponent<CharacterManager>().Attack(Enemy);
        }
    }
    private void OnMouseOver() {
        if (Input.GetMouseButtonDown(0))
        {
            if (Character != null){
                Enemy = gameObject;
            }
        }
    }
}
