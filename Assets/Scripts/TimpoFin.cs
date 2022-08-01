using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimpoFin : MonoBehaviour
{
    float Tiempo;
    [SerializeField]float TiempoInicial;
    [SerializeField]TextMeshProUGUI ContadorText;
    // Start is called before the first frame update
    void Start()
    {
        Tiempo = TiempoInicial;
    }

    // Update is called once per frame
    void Update()
    {
        Tiempo -= 1 * Time.deltaTime;
        ContadorText.text = Tiempo.ToString("0");

        if (Tiempo <= 0)
        {
            Tiempo = 0;
            GameManager.manager.GameOver();
        }
    }
}
