using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMovement : MonoBehaviour
{
    public float speedModifier = 0.05f;
    public GameObject[] mapPrefabs;
    private bool reproduced = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += new Vector3(-speedModifier, 0, 0);
        if(transform.position.x < 0 && !reproduced)
        {
            var clone = Instantiate(mapPrefabs[Random.Range(0,mapPrefabs.Length)], new Vector3(39.5f,0,0), Quaternion.identity);
            //remove of the (Clone) titles
            clone.name = "MapPart";
            reproduced = true;
        }
        if (transform.position.x < -40)
        {
            Destroy(this.gameObject);
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
