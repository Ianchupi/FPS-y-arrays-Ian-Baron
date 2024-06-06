using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlimentoScript : MonoBehaviour
{



    // Start is called before the first frame update
    public int NivelHambre;

    void TomarAlimento(int ValorAlimentario)
    {
        NivelHambre -= ValorAlimentario;
    }
    private void OnTriggerEnter(Collider other)
    {
        AlimentoScript alimento;
        alimento = other.GetComponent<AlimentoScript>();
    }
}
