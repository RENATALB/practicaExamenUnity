using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class examen6 : MonoBehaviour
{
    public int entradaCampo;
    public int entradaPlatea;
    int recaudacionCampo;
    int recaudacionPlatea;
    int total;

    // Start is called before the first frame update
    void Start()
    {
        recaudacionCampo = entradaCampo * 1200;
        recaudacionPlatea = entradaPlatea * 2000;

        total = recaudacionCampo + recaudacionPlatea;
        print("La recaudacion total es: " + total);


        if (entradaCampo == 20400 || entradaPlatea == 16200)
        {
            print("¡Sold Out!");
        }

    }
}