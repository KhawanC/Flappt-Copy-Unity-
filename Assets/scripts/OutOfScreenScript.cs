using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfScreenScript : MonoBehaviour
{

    PassaroLogic passaroLogic;
    [SerializeField] GameObject passaro;
    PassaroController passaroController;
    LogicController logicController;
    [SerializeField] GameObject logic;

    private void Awake()
    {
        passaroLogic = passaro.GetComponent<PassaroLogic>();
        passaroController = passaroLogic.getPassaro();
        logicController = logic.GetComponent<LogicController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "passaro")
        {
            passaroController.setControleAtivado(false);
            logicController.gameOver();
        }
    }
}
