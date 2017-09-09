using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
    public enum ArmorType { stone, steel, energetic };
    ArmorType armType;
    float armor;
    float hp;

    public void GetDmg(float dmg, Damage.Type dmgType)
    {
        float newhp = hp - CalculateDmg(dmg, dmgType, armor, armType);
        if (newhp <= 0)
            Death();
        else
            hp = newhp;
        
    }
    public float CalculateDmg(float dmg, Damage.Type dmgType, float armor, ArmorType armType)
    {
        return dmg;
    }
    public void Death()
    { }
  

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
