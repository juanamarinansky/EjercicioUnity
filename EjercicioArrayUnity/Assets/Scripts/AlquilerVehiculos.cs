using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlquilerVehiculos : MonoBehaviour
{
    public Vehiculo[] vehiculos;

    // Start is called before the first frame update
    void Start()
    {
        vehiculos = FindObjectsOfType<Vehiculo>();
        vehiculos[0].gameObject.SetActive(false);
        vehiculos[0].CartelPromo.SetActive(false);
        ResetearVehiculos();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {

        }   
    }

    void ResetearVehiculos()
    {

    }
}
