using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public enum ArmorType
    {
        stone,
        steel,
        energetic
    };

    public UnityEvent death;
    [SerializeField]
    ArmorType armType;
    [SerializeField]
    float armor;
    [SerializeField]
    float hp;

    private void Start()
    {
        death.AddListener(Death);
    }

    public void GetDmg(float dmg, Damage.Type dmgType)
    {
        float newhp = hp - CalculateDmg(dmg, dmgType, armor, armType);
        if (newhp <= 0)
            death.Invoke();
        else
            hp = newhp;
    }

    public float CalculateDmg(float dmg, Damage.Type dmgType, float armor, ArmorType armType)
    {
        return dmg;
    }

    public void Death()
    {
        Destroy(gameObject);
    }
}
