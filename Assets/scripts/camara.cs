using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Camera.main.fieldOfView==50)
        {
            StartCoroutine("mov");
        }
        

        //Debug.Log(Camera.main.fieldOfView -= 0.05f);
    }

    private IEnumerator mov()
    {
        yield return new WaitForSeconds(3f);
        if (Camera.main.fieldOfView > 45)
        {
            Camera.main.fieldOfView -= 0.02f;
        }

    }


   

}
