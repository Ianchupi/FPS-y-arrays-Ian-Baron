using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeScript : MonoBehaviour
{

    public int nivelHambre;

    // Start is called before the first frame update


    // Update is called once per frame



    void TomarAlimento(int ValAlimentario)
    {
        nivelHambre -= ValAlimentario;
    }
    private void OnTriggerEnter(Collider other)
    {
        AlimentoScript alimento;
        alimento = other.GetComponent<AlimentoScript>();
        if (alimento)
        {
            TomarAlimento(alimento.ValAlimentario);
        }
    }
}
