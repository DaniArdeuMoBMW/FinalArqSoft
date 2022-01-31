using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    //// Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    //if (Random.Range(0, 300) < 1)
    //    //{
    //        //ObjectPooling.Instance.Spawn();
    //    //}
    //}


    // Hacemos referencia al objeto que queremos hacer aparecer en este caso un balon
    //public GameObject bullet;

    void Start()
    {

    }

    void FixedUpdate()
    {
        
            GameObject bullet = ObjectPooling.Instance.Spawn();
            bullet.transform.position = this.transform.position /*+ new Vector3(Random.Range(-10, 10), 0, 0)*/;
        
        
             
        
    
        

        //Los balones apareceran si el numero aleatorio entre 0 y 300 sale menor que 1
        //if (Random.Range(0, 300) < 1)
        //{

        //    //Creamos una referencia al objeto de la lista de objetos creados mediante el Pool
        //    GameObject tal = ObjectPooling.instance.Get("Bullet");
        //    //Si el objeto que he recibido no está vacío(osea que se puede usar)
        //    if (tal != null)
        //    {
        //        //Le pasamos una posición a ese balon concreto
        //        tal.transform.position = this.transform.position + new Vector3(Random.Range(-10, 10), 0, 0);
        //        //Y activamos el balon
        //        tal.SetActive(true);
        //    }
        //}

    }
}
