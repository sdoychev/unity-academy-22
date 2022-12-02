using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorScript : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Animator>().SetBool("isInBattle", true);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            GetComponent<Animator>().SetBool("isInBattle", false);
        }
    }
}
