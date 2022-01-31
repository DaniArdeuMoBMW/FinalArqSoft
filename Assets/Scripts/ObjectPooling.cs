using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{
    //le decimos cual es el prefab
    [SerializeField] private GameObject bullet;
    //creamos la lista de objetos que vamos a tener
    [SerializeField] private List<GameObject> List;
    //le decimos el tama�o de la lista
    [SerializeField] private int ListSize = 10;
   
    //hacemos un singleton para que solo se llame al script una vez
    public static ObjectPooling instance;
    public static ObjectPooling Instance { get { return instance; } }


    private void Awake()
    {
        if (instance==null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //nada m�s empezar le decimos que llame a esta funci�n
    void Start()
    {
        AddBulletsToPool(ListSize);
    }

    //hacemos que se cree un objeto, se desactive y se lo comunique a la lista tantas veces como celdas tenga la lista. Adem�s todos los objetos que cree ser�n hechos hijos del objeto que tenga este script
    private void AddBulletsToPool(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            GameObject Bullet = Instantiate(bullet);
            Bullet.SetActive(false);
            List.Add(Bullet);
            Bullet.transform.parent = transform;


        }
    }

    //hacemos que por cada objeto de la lista, si no est� activado, lo activamos y vuelva a la lista
    public GameObject Spawn()
    {

        for (int i = 0; i < List.Count; i++)
        {
            if (!List[i].activeSelf)
            {
                List[i].SetActive(true);
                return List[i];
            }
        }
        return null;

    }

    //llamamos a la instanciaci�n de los objetos de la lista en una posici�n aleatoria dentro de un rango en la posici�n del objeto que lleve este script
    public void Update()
    {
        GameObject bullet = ObjectPooling.Instance.Spawn();
        bullet.transform.position = this.transform.position + new Vector3 (Random.Range(-15, 15), 0, Random.Range(-5, 5));
    }




}
