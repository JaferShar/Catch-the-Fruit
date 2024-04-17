using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float moveSpeed = 0.01f;
    public GameObject player;
    private new Transform transform;
    // Start is called before the 
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, moveSpeed, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" || collision.gameObject.name == "BorderBottom") 
        {
            gameObject.SetActive(false);
        }
    }
}
