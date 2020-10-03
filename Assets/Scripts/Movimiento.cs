using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    public float velocidad = 1f, aceleracionCohete = 9.8f;

    float iny;
    float pos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        iny = Mathf.Clamp(Input.GetAxis("Vertical"),-0.5f,0.5f);

        velocidad = 0.99999f * (velocidad + (iny * aceleracionCohete * Time.deltaTime));
        pos = (velocidad * Time.deltaTime) + (0.5f * (iny * aceleracionCohete * Mathf.Pow(Time.deltaTime, 2f)));

        transform.Translate(0f, 0f,pos);
    }
}
