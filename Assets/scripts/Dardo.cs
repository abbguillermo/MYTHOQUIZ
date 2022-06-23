using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dardo : MonoBehaviour
{
    Vector3 newPosition;
   
       
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "nueva";
        newPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (gameObject.CompareTag("nueva"))
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit))
                {
                    newPosition = hit.point;
                    transform.position = newPosition;
                    StartCoroutine("espera");
                }
            }

        }
       

        


    }
    private IEnumerator espera()
    {
        yield return new WaitForSeconds(0.1f);
        gameObject.tag = "usada";
        Invoke("nuevo", 3);
        
    }

  
   
    void nuevo()
    {
        FindObjectOfType<Generador_Flecahas>().nuevapieza();
    }
        
 
}
