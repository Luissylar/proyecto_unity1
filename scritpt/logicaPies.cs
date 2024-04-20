using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logicapies : MonoBehaviour
{
    public logicapersonaje2 logicaPersonaje2;

    // Método llamado cuando otro collider entra y permanece dentro del trigger
    private void OnTriggerStay(Collider other)
    {
        logicaPersonaje2.puedoSaltar = true;
    }

    // Método llamado cuando otro collider sale del trigger
    private void OnTriggerExit(Collider other)
    {
        logicaPersonaje2.puedoSaltar = false;
    }
}
