using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Rigidbody Player;
    public float HorizontalInput;
    public float Speed;
    public int puntos=0;
    public Text puntuacion;

   
    void Start()
    {
        Player=GetComponent<Rigidbody>();
        

        //ovserba al evento y se ejecuta cuando ocurre 
        eventos.current.onColision += sumarPuntos;
    }

    //movimiento del jugador en un eje
    void Update()
    {
        
        HorizontalInput = Input.GetAxisRaw("Horizontal");
        
    }

    private void FixedUpdate()
    {
        //le decimos al objeto de texto el texto que tiene que llevar, en este caso un texto estático y una variable que lleva la puntuación
        puntuacion.text = "Puntos: " + puntos;


        //movimiento del jugador en un eje

        Vector3 movement = new Vector3(HorizontalInput, 0) * Speed * Time.deltaTime;
        Player.MovePosition(Player.position+ movement);
    }


    //se suman puntos
    void sumarPuntos()
    {
        puntos++;
        
    }
}
