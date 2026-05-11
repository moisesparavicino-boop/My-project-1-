using UnityEngine;

public class ejercicio10 : MonoBehaviour
{
    string[] pociones = { "Vida", "Velocidad", "Mana", "Fuerza" };
    int i = 0;
    void Start()
    {
        while (i < pociones.Length)
        {
            Debug.Log("poción: " + pociones[i]);
            i++;
        }
        Debug.Log("cantidad de pociones: " + pociones.Length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
