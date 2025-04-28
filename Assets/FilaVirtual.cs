using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FilaVirtual : MonoBehaviour
{
    public string CodigoEntrada;
    public float CantEntradas;
    public string Prioridad;
    float precioTotal;
    float precioBasico = 800;
    float precioNormal = 1200;
    float precioPremium = 2000;
    

    void Start()
    {
        Debug.Log("Ingrese Codigo Entrada");
        if (CodigoEntrada != "b" | CodigoEntrada != "p" | CodigoEntrada != "n")
        {

            Debug.Log("Codigo entrada no valido");
            return;
        }
        Debug.Log("Ingrese Cantidad de Entradas");

        if (CantEntradas < 4 & CodigoEntrada == "b")
        {
            precioTotal = CantEntradas * precioBasico;
        }
        else
        {
            Debug.Log("Cantidad Entradas no valido");
            return;
        }
        if (CantEntradas < 6 & CodigoEntrada == "n")
        {
            precioTotal = CantEntradas * precioNormal;
        }
        else
        {
            Debug.Log("Cantidad Entradas no valido");
            return;
        }
        Debug.Log("DeseaFilaPremium");
        if (Prioridad == "si")
        {
            if (CantEntradas > 0 & CodigoEntrada == "p")
            {
                precioTotal = ((CantEntradas * precioPremium) * 15)/100; 
            }
            else
            {
                Debug.Log("Cantidad Entradas no valido");
                return;
            }
        }
        else if (Prioridad == "no")
        {
            if (CantEntradas > 0 & CodigoEntrada == "p")
            {
                precioTotal = (CantEntradas * 2000);
            }
            else
            {
                Debug.Log("Cantidad Entradas no valido");
                return;
            }

        }
        Debug.Log("Tipo de entrada:");
        Debug.Log(CodigoEntrada);
        Debug.Log("Cantidad ");
        Debug.Log(CantEntradas);
        Debug.Log("Precio Total ");
        Debug.Log(precioTotal);

    } 

}


