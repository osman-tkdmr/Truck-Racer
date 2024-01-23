using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // Oyuncu nesnesi
    public float followSpeed = 5f; // Kameranýn oyuncuyu takip etme hýzý

    void Update()
    {
        if (target != null)
        {
            Vector3 targetPosition = new Vector3(target.position.x - 20, transform.position.y, transform.position.z);
            // Yükseklik ve uzaklýk sabit olduðu için sadece x ekseni üzerinde takip yapýlýr.

            transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);
            // Lerp kullanarak yumuþak bir takip saðlanýr.
        }
    }
}
