using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cronometro : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI tiempoCronometrado;
    [SerializeField]
    public float time;
    bool contar = false;
    [SerializeField]
    GameObject cronometro;

    public void Update()
    {
        if (contar == true)
        {
            time = time + (-Time.deltaTime);
            tiempoCronometrado.text = TimeToSeconds(time);
            
        }
    }
    public void Cuenta()
    {
        contar = !contar;
    }

    public string TimeToSeconds(float totalTime)
    {
        float seconds = totalTime % 60f;

        return seconds.ToString("00");
    }
}
