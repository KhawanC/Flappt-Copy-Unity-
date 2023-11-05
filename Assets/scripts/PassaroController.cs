using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassaroController : MonoBehaviour
{
    private bool controleAtivado;

    public bool isControleAtivado()
    {
        return controleAtivado;
    }

    public void setControleAtivado(bool valor)
    {
        this.controleAtivado = valor;
    }
}
