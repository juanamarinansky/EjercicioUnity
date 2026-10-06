using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LibroScript : MonoBehaviour
{
    public bool reservado;
    public int color;
    MeshRenderer renderer;

    // Start is called before the first frame update
    void Start()
    {
         renderer = GetComponent<MeshRenderer>();        
    }

    private void Update()
    {
        AsignarColor();
    }

    void AsignarColor()
    {
        switch (color)
        {
            case 0:
                renderer.material.color = Color.black;
                break;
            case 1:
                renderer.material.color = Color.blue;
                break;
            case 2:
                renderer.material.color = Color.red;
                break;
            case 3:
                renderer.material.color = Color.green;
                break;
            case 4:
                renderer.material.color = Color.grey;
                break;
            case 5:
                renderer.material.color = Color.yellow;
                break;
        }
    }
}
