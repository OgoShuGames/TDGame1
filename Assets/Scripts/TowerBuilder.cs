using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBuilder : MonoBehaviour
{
    public long money = 5000;
    public GameObject tower;
    
    void Update()
    {
        if (!Input.GetMouseButtonDown(0))
            return;
        const long price = 100;
        if (money < price)
            return;
        RaycastHit hit;
        if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity, 1))
            return;
        money -= price;
        Instantiate(tower, hit.point, Quaternion.identity);
    }
}
