using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassaroLogic : MonoBehaviour
{

    public new Rigidbody2D rigidbody;
    public float fisicaForca;
    private LogicController logicController;
    [SerializeField] GameObject logic;
    private PassaroController passaro;

    private void Awake()
    {
        passaro = new PassaroController();
        logicController = logic.GetComponent<LogicController>();
    }

    void Start()
    {
        passaro.setControleAtivado(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && passaro.isControleAtivado())
        {
            rigidbody.velocity = Vector2.up * fisicaForca;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            passaro.setControleAtivado(false);
            logicController.gameOver();
        }
    }

    public PassaroController getPassaro()
    {
        return passaro;
    }
}
