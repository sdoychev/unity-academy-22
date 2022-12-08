using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score;
    [SerializeField] private int magnitude;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Score: " + score);
    }

    void OnCollisionEnter(Collision collision)
    {
        Vector3 up = collision.transform.up * magnitude;
        collision.gameObject.GetComponent<Rigidbody>().AddForce(up);
        //Debug.Log("Score: " + ++score);
    }

}
