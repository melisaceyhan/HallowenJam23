using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EtkilesimliNesne : MonoBehaviour
{
    public GameObject spawnNesnesi; // Sahnenizdeki spawn edilecek nesne

    // Etkileþim baþladýðýnda bu fonksiyon çaðrýlýr
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EtkilesimNesnesiTag")) // Etkileþim nesnesinin tag'ini kullanabilirsiniz
        {
            SpawnNesne();
        }
    }

    // Yeni bir nesne spawn etmek için bu fonksiyonu çaðýrýn
    private void SpawnNesne()
    {
        Instantiate(spawnNesnesi, transform.position, Quaternion.identity);
    }
}

