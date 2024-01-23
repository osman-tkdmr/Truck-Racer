using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // Oyuncu nesnesi
    public float followSpeed = 5f; // Kameran�n oyuncuyu takip etme h�z�

    void Update()
    {
        if (target != null)
        {
            Vector3 targetPosition = new Vector3(target.position.x - 20, transform.position.y, transform.position.z);
            // Y�kseklik ve uzakl�k sabit oldu�u i�in sadece x ekseni �zerinde takip yap�l�r.

            transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);
            // Lerp kullanarak yumu�ak bir takip sa�lan�r.
        }
    }
}
