using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMapLibrary : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] mapPrefabs;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public GameObject GetMapPrefab()
    {
        return mapPrefabs[1];
    }
}
