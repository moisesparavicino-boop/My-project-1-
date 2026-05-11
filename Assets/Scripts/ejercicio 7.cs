using UnityEngine;

public class ejercicio7 : MonoBehaviour
{
    string[] inventario = { "Espada", "Pocion", "Escudo", "Arco" };
    int i = 0;
    void Start()
    {
        while (i < inventario.Length) 
        {
            Debug.Log("Objeto: " + inventario[i]);
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
