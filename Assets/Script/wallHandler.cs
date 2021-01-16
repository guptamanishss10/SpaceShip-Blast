using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallHandler : MonoBehaviour
{
    [SerializeField] private GameObject[] wallPrefabs;
    [SerializeField] private GameObject player;

    int currentpos=0;

    void Update()
    {
        if ((int)(player.transform.position.y) % 10 == 0 && currentpos!=(int)player.transform.position.y)
        {
            currentpos = (int)player.transform.position.y;
            GameObject x = Instantiate(wallPrefabs[Random.Range(0, 2)], new Vector3(transform.position.x,gameObject.transform.GetChild(transform.childCount-1).gameObject.transform.position.y+10,0), Quaternion.identity);
           x.transform.parent=gameObject.transform;
            Destroy(gameObject.transform.GetChild(0).gameObject);
        }
    }
}
