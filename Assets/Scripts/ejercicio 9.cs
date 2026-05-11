using UnityEngine;

public class ejercicio9 : MonoBehaviour
{
    string contraseña = "";
    void Start()
    {
        do
        {
            Debug.Log("Ingresando contraseña...");
            contraseña = "admin";
        } while (contraseña != "admin");

        Debug.Log("Contraseña correcta");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
