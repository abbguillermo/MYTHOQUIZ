using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador_Flecahas : MonoBehaviour
{
    public GameObject[] piezas;
    // Start is called before the first frame update
    void Start()
    {
        nuevapieza();

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void nuevapieza()
    {
        Instantiate(piezas[Random.Range(0, piezas.Length)], transform.position, Quaternion.identity);

    }
}
