using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllergicReaction : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float fapstrength;
    public LogicScr logic;
    public bool VemolAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScr>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && VemolAlive)
        {
            myRigidbody.velocity = Vector2.up * fapstrength;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        VemolAlive = false;
    }
}

