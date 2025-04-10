using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heladeria : MonoBehaviour

{
    public string gusto;
    public float CantidadGramos;
    float precioFinal;
    // Start is called before the first frame update
    void Start()
    {
        if (CantidadGramos > 3000 || CantidadGramos < 250)
        {
            print("error");
            return;
        }
        else
        {
            if (gusto == "CHO" || gusto == "FRU" || gusto == "DDL")
            {
                precioFinal = (float)(CantidadGramos * 0.5);

                if (gusto == "FRU")
                {
                    precioFinal = precioFinal - (precioFinal * 10 / 100);
                }
                print("Tu pedido vale $ " + precioFinal);
            }
            else
            {
                print("error");
                return;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
