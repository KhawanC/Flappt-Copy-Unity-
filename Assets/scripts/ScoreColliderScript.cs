using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreColliderScript : MonoBehaviour
{
    private LogicController logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "passaro")
        {
            logic.addScore();
        }
    }
}
