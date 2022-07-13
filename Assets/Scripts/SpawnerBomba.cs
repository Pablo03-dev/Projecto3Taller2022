using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBomba : MonoBehaviour
{
    public GameObject objeto;
    public float timer = 0f;
    public float timeToSpawn = 2f;

    public GameObject aux;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timeToSpawn && aux == null)
        {
            aux = Instantiate(objeto, transform.position, Quaternion.identity);
            timer = 0f;

        }
    }
}
