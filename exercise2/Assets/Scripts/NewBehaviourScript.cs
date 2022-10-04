using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public enum Direccion{Arriba, Abajo, Izquierda, Derecha};
    public float vida = 100;
    public float velocidad;
    public Direccion direccion;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void MoverJugador()
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

    public void CurarJugador(int vidaCurada = 1)
    {
        if (vida == 100)
            Debug.Log("Máximo de vida");
        else 
            vida += vidaCurada * Time.deltaTime;
    }

    public void DaniarJugador(int danioHecho = 1)
    {
        if (vida == 0)
            Debug.Log("Murió");
        else
            vida -= danioHecho * Time.deltaTime;
    }
}
