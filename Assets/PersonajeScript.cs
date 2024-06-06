using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeScript : MonoBehaviour
{

    public int nivelHambre;
    
    // Start is called before the first frame update
   

    // Update is called once per frame
    
    void ConsumirAlimento(int ValorAlimentario)
    {
        nivelHambre -= ValorAlimentario;
    }
    
    void Update()


    {
        
    }
}
