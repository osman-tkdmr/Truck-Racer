using UnityEngine;

public class SectionTrigger : MonoBehaviour
{
    [SerializeField] GameObject[] roadSection;
    int len;
    private void Start()
    {   
        len = roadSection.Length;
        Instantiate(roadSection[0], new Vector3(0, 0, 0), Quaternion.identity);
        Instantiate(roadSection[Random.Range(1, len)], new Vector3(50, 0, 0), Quaternion.identity);
        Instantiate(roadSection[Random.Range(1, len)], new Vector3(100 , 0, 0), Quaternion.identity);
        Instantiate(roadSection[Random.Range(1, len)], new Vector3(150, 0, 0), Quaternion.identity);
    }

    private void OnTriggerEnter(Collider other)
    {
        
        int rand = Random.Range(0, len);
        if (other.gameObject.CompareTag("Trigger")){
            Instantiate(roadSection[rand], new Vector3(other.transform.parent.position.x + 200 ,0,0), Quaternion.identity) ;
        }
    }
}
