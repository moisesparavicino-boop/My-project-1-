using UnityEngine;
using System.Collections.Generic;

using NUnit.Framework;
public class Whilechanges : MonoBehaviour
{
    public List<string> nombres = new List<string>() { "A", "B", "C", "D", "E" };
    void Start()
    {
        // Debug.Log(nombres[nombres-Count -1]};
        int i = 0;

        while (i < nombres.Count)
        {
            Debug.Log(nombres[i]);
            if (nombres[i] == "C")
            {
                Debug.Log("El elemento C se encuentra en la posicion " + i);

            }

            i++;
        }


    }
    // Update is called once per frame
        void Update()
    {

    }
}