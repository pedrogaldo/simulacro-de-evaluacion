using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evaluacion2 : MonoBehaviour
{
    public int monto;
    public int precio1;
    public int precio2;
    public int precio3;
    
    // Start is called before the first frame update
    void Start()
    {
        int preciototal = precio1 + precio2 + precio3;
        int faltan = preciototal - monto;
        int sobran = monto - preciototal;

        if (preciototal > monto)

        {
            Debug.Log("no alcanza el monto disponible, faltan $" + faltan);
        }

        else if (preciototal<=monto)
        {
            Debug.Log("alcanza el monto disponible y sobran $" + sobran);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
