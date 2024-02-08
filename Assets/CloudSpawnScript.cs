using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawnScript : MonoBehaviour
{
    public GameObject cloud;
    public GameObject smilingCloud;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;
    public float step = 3;

    // Start is called before the first frame update
    void Start()
    {
        spawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnCloud();
            timer = 0;
        }
    }

    void spawnCloud()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float heighestPoint = transform.position.y + heightOffset;

        if ((int) Mathf.Round(Random.Range(0, step)) % 2 == 0)
        {
            Instantiate(cloud, new Vector3(transform.position.x, Random.Range(lowestPoint, heighestPoint), 2), transform.rotation);
        }
        else
        {
            Instantiate(smilingCloud, new Vector3(transform.position.x, Random.Range(lowestPoint, heighestPoint), 1), transform.rotation);
        }
    }
}
