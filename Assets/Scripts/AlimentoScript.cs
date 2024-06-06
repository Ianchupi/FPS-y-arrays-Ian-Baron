using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlimentoScript : MonoBehaviour
{
   
    public int nivelhambre;

    void TomarAlimento(int ValAlimentario)
    {
        nivelhambre -= ValAlimentario;
    }
    private void OnTriggerEnter(Collider other)
    {
        AlimentoScript alimento;
        alimento = other.GetComponent<AlimentoScript>();
        if (alimento)
        {
            TomarAlimento (alimento.ValAlimentario);
        }
    }
}
}
