using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObstacle : MonoBehaviour
{
    [SerializeField] private PlayerControler pc;
    [SerializeField] GameObject obsPrefab;
    [SerializeField] private Transform[] spawnPoint;
    private float timer = 6f;
    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(1,2);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * pc.moveSpeed);
        if(timer<=0)
        {
          Instantiate(obsPrefab, spawnPoint[Random.Range(0, spawnPoint.Length)].position, Quaternion.identity);
            
            timer = Random.Range(1,2);

        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}
