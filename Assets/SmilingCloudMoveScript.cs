using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmilingCloudMoveScript : MonoBehaviour
{
    public float moveSpeed = 4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < -35)
        {
            Debug.Log("Cloud deleted");
            Destroy(gameObject);
        }
    }
}
