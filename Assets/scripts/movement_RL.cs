using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement_RL : MonoBehaviour
{
    public GameObject[] objetos;
    int indice = 0;
    void Start()
    {
        for (int i = 0; i < objetos.Length; i++)
        {
            objetos[i].SetActive(false);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            objetos[indice].SetActive(false);
            indice--;
            //if (indice < 0)
            //{
            //    indice = objetos.Length;
            //}
            objetos[indice].SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            objetos[indice].SetActive(false);
            indice++;
            //if (indice > objetos.Length)
            //{
            //    indice = 0;
            //}
            objetos[indice].SetActive(true);
        }
    }
}
