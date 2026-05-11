using UnityEngine;

public class ejercicio4 : MonoBehaviour
{
    int energia = 100;
    void Start()
    {
        while (energia >= 0) ;
        Debug.Log("Energia: " + energia);
        energia -= 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
