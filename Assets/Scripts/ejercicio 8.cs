using UnityEngine;

public class ejercicio8 : MonoBehaviour
{
    int monedas = 0;
    void Start()
    {
        while (monedas < 100) ;
        {
            monedas += 10;
            Debug.Log("monedas : " + monedas);
        }
        
            Debug.Log("Haz alcanzado 100 monedas");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
