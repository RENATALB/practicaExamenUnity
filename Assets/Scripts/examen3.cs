using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class examen3 : MonoBehaviour
{
    public string codigoMascota;
    public int diasAQuedarse;
    public int precioAlimento = 80;
    int totalGramos;
    float costoAlimento;

    int gramosAlimentoPorDia;

    // Start is called before the first frame update
    void Start()
    {
        if (diasAQuedarse < 3 || codigoMascota != "G" || codigoMascota != "PP" || codigoMascota != "PG")
        {
            print("Formato inválido");
        }
        else if (codigoMascota == "G")
        {
            gramosAlimentoPorDia = 300;
        }
        else if (codigoMascota == "PP")
        {
            gramosAlimentoPorDia = 400;
        }
        else if (codigoMascota == "PG")
        {
            gramosAlimentoPorDia = 700;
        }


        totalGramos = gramosAlimentoPorDia * diasAQuedarse;
        costoAlimento = totalGramos / 100 * 80;

        Debug.Log("Para ese período se necesitan " + totalGramos + "gramos de alimento");

        Debug.Log("Costo de esa cantidad de alimento: $" + costoAlimento);


    }
}