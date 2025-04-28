using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mudanzas : MonoBehaviour
{

    public float cantidadDeCargaEnKilos;
    public int distanciaAdondeLlegarEnKm;

    int cantHoras;
    int precioHora;
    float precioTotalHoras;
    float cargaMinima = 100;
    float disatnciaMinima = 1;
    float precioVehiculoActual;
    float precioUtilitario = 3000;
    float precioPickup = 4500;
    float precioCamion = 7000;
    int cantidadDeKmminimos = 25;


    // Start is called before the first frame update
    void Start()
    {
        if (cantidadDeCargaEnKilos < cargaMinima)
        {
            Debug.Log("La carga minima es de 100 kilos");

        }
        else if (distanciaAdondeLlegarEnKm < disatnciaMinima)
        {
            Debug.Log("La distancia minima es de 1Km");
        }
        else
        {
            if (cantidadDeCargaEnKilos < 2000)
            {
                precioVehiculoActual = precioUtilitario;
            }
            else if (cantidadDeCargaEnKilos < 5000 && cantidadDeCargaEnKilos > 2000)
            {
                precioVehiculoActual = precioPickup;
            }
            else if (cantidadDeCargaEnKilos < 10000 && cantidadDeCargaEnKilos > 5000)
            {
                precioVehiculoActual = precioCamion;
            }else
            {
                Debug.Log("La carga maxima es de 10000 kilos");
                return;
            }

   



        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
