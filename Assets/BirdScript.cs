using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool active = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && active)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
        if (transform.position.y < -50 || transform.position.y > 50)
        {
            logic.gameOver();
            active = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        logic.gameOver();
        active = false;
    }
}
