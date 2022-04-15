using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prueba : MonoBehaviour
{
    public int unidadesflota;
    public int diasdelluvia;
    public int diastotal;

    // Start is called before the first frame update
    void Start()
    {
        int diasnormales = diastotal - diasdelluvia;
        int preciodiasnormales = diasnormales * unidadesflota * 90 / 15 * 130;
        int preciodiaslluvia = diasdelluvia * unidadesflota * 120 / 15 * 130;
        int preciototal = preciodiaslluvia + preciodiasnormales;

        if (diastotal < 5)
        {
            Debug.Log("el numero de dias debera ser mayor a 5");
        }
        
        if (diasdelluvia < 0 && diasdelluvia > diastotal)
        {
            Debug.Log("Los dias de lluvia no pueden ser negativos o mayor a los dias totales");
        }
        else if (diastotal > 5 && diasdelluvia > 0 && diasdelluvia < diastotal)
        {
            Debug.Log("“Una flota de " + unidadesflota + " unidades trabajando durante " + diastotal + " días implicará un gasto de " + preciototal + " pesos en concepto de combustible");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
