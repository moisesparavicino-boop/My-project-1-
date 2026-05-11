using UnityEngine;

public class ejercicio6 : MonoBehaviour
{
    string[] Enemigos = { "Zombie", "Esqueleto", "Dragon", "Bruja" };
    int i = 0;
    void Start()
    {
        while (i < Enemigos.Length) 
        {
            Debug.Log("Buscando: " + Enemigos[i]);

            if (Enemigos[i] == "Dragon")
            {
                Debug.Log("Dragon Encontrado");
                break;
            }
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
