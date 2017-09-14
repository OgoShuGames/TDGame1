using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBuilder : MonoBehaviour
{
    public static readonly float gridSize = .5f;

    public long money = 5000; // TODO: move to Faction
    public GameObject tower;
    public GameObject towerGhost;

    private void Awake()
    {
        towerGhost = Instantiate(tower);
        foreach (MonoBehaviour x in towerGhost.GetComponentsInChildren<MonoBehaviour>())
            Destroy(x);
        foreach (Collider x in towerGhost.GetComponentsInChildren<Collider>())
            Destroy(x);
        foreach (Renderer x in towerGhost.GetComponentsInChildren<Renderer>())
            x.material.color = Color.LerpUnclamped(x.material.color, Color.green, .5f);
        towerGhost.SetActive(false);
    }

    void Update()
    {
        RaycastHit hit;
        if (!Ground.coll.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity))
        {
            towerGhost.SetActive(false);
            return;
        }
        hit.point = (hit.point / gridSize).Round() * gridSize;
        towerGhost.transform.position = hit.point;
        towerGhost.SetActive(true);
        if (!Input.GetMouseButtonDown(0))
            return;
        const long price = 100; // TODO: move to tower
        if (money < price)
            return;
        money -= price;
        Instantiate(tower, hit.point, Quaternion.identity);
    }
}
