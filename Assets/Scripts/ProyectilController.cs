using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilController : MonoBehaviour
{
    public Rigidbody BulletRB;
    
    public float Speed;
    
    
    //Si se choca con el collider del muro, solo se desactiva para volver a estar disponible para el pool
    private void OnCollisionEnter()
    {
        
        gameObject.SetActive(false);
    }

    //Si choca con el trigger del jugador, se desactiva y y llamamos al observer
    private void OnTriggerEnter()
    {
        eventos.current.colision();
        gameObject.SetActive(false);
    }

    //Nada más activarse van hacia el jugador
    private void OnEnable()
    {
        BulletRB.velocity = Vector3.back * Speed;
    }
}
    
   
