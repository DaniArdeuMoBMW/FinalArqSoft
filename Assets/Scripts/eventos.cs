using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class eventos : MonoBehaviour
{
    public static eventos current;

    //singleton  para este script
    private void Awake()
    {
        current = this;
    }

    public event Action onColision;
    public void colision()
    {
        //hacemos que se aseguro de que la Action no es null antes de invocarla
        if (onColision != null)
        {
            onColision();
        }
    }
}
