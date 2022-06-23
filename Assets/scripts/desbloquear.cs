using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class desbloquear : MonoBehaviour
{
    public Button[] NivelBTN;
    // Start is called before the first frame update
    void Start()
    {
        int nivel = PlayerPrefs.GetInt("nivel", 3);
        for (int i = 0; i < NivelBTN.Length; i++)
        {
            if (i + 3 > nivel)
            {
                NivelBTN[i].interactable = false;
            }
        }
    }

 
}
