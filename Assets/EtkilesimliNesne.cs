using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EtkilesimliNesne : MonoBehaviour
{
    public GameObject spawnNesnesi; // Sahnenizdeki spawn edilecek nesne

    // Etkile�im ba�lad���nda bu fonksiyon �a�r�l�r
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EtkilesimNesnesiTag")) // Etkile�im nesnesinin tag'ini kullanabilirsiniz
        {
            SpawnNesne();
        }
    }

    // Yeni bir nesne spawn etmek i�in bu fonksiyonu �a��r�n
    private void SpawnNesne()
    {
        Instantiate(spawnNesnesi, transform.position, Quaternion.identity);
    }
}

