using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public enum Direccion{Arriba, Abajo, Izquierda, Derecha};
    public Vector3 escala;
    public float velocidad;
    public Direccion direccion;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
        transform.localScale += escala;
    }

    // Update is called once per frame
    void Update()
    {
        if (direccion == Direccion.Arriba)
            transform.position += transform.up * velocidad * Time.deltaTime;
        else if (direccion == Direccion.Abajo)
            transform.position -= transform.up * velocidad * Time.deltaTime;
        else if (direccion == Direccion.Izquierda)
            transform.position -= transform.right * velocidad * Time.deltaTime;
        else if (direccion == Direccion.Derecha)
            transform.position += transform.right * velocidad * Time.deltaTime;
    }
}
