using UnityEngine;

public class ejericicio5 : MonoBehaviour
{
    int opcion = 0;
    void Start()
    {
        do
        {
            Debug.Log("Presiona 1 para salir");

            opcion = 1;

        } while (opcion != 1);

        Debug.Log("Programa finalizado");
     
    }
     // Update is called once per frame
    void Update()
    {
        
    }
}
