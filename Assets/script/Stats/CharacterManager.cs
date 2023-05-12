 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public CharacterData stats;
    public string Name;
    private string type;
    private Sprite IMG;
    private int LV;
    private int HP;
    private int STR;
    private int SPD;
    private int DEF;
    public Sprite GetIMG(){
        return stats.IMG;
    }
    public int getLV(){
        return this.LV;
    }
    public int getHP(){
        return this.HP;
    }
    public int getSTR(){
        return this.STR;
    }
    public int getSPD(){
        return this.SPD;
    }
    public int getDEF(){
        return this.DEF;
    }
    
    private void setStats(CharacterData stats)
    {
        Name = stats.Name;
        this.type = stats.type;
        this.IMG = stats.IMG;
        this.LV = stats.LV;
        this.HP = stats.HP;
        this.STR = stats.STR;
        this.SPD = stats.SPD;
        this.DEF = stats.DEF;
    }
    public void decHP(int value)
    {
        this.HP -= value;
    }
    public void incHP(int value)
    {
        this.HP += value;
    }
    public void incspd(int value)
    {
        this.SPD += value;
    }
    public void decspd(int value){
        this.SPD -= value;
    }
    public void incdecdef(int value)
    {
        this.DEF += value;
    }
    public void decdef(int value){
        this.DEF -= value;
    }
    public void Attack(GameObject Enemy){
        int EnemyDef = Enemy.GetComponent<CharacterManager>().getDEF();
        Enemy.GetComponent<CharacterManager>().decHP(this.STR - EnemyDef);
    }

    private void Awake() {
        setStats (stats);
    }
}
