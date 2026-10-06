using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BibliotecaScript : MonoBehaviour
{
    public LibroScript[] libros;
    public GameObject cartelReservado;

    // Start is called before the first frame update
    void Start()
    {
        libros = FindObjectsOfType<LibroScript>();
        for (int i = 0; i <libros.Length;i++)
        {
            libros[i].color = Random.Range(0,6);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ReservarLibro(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ReservarLibro(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ReservarLibro(2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            ReservarLibro(3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            ReservarLibro(4);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            ReservarLibro(5);
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            ReservarLibro(6);
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            ReservarLibro(7);
        }
    }

    void ReservarLibro(int index)
    {
        if(!libros[index].reservado)
        {
            libros[index].reservado = true;
            libros[index].color = 0;
        }
        else
        {
            MostrarMensajeReservado();
        }
    }
    void MostrarMensajeReservado()
    {
        cartelReservado.SetActive(true);
        Invoke(nameof(OcultarMensajeReservado),2);
    }

    void OcultarMensajeReservado()
    {
        cartelReservado.SetActive(false);
    }
}
