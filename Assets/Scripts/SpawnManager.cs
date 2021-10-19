using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obsPrefab;
    private Vector3 spawnpos = new Vector3(0, 2, 56);
    private PlayerController playerCtrl;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObs", 3, 2);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnObs()
    {
        {
            Instantiate(obsPrefab, spawnpos, obsPrefab.transform.rotation);
        }
    }
}
