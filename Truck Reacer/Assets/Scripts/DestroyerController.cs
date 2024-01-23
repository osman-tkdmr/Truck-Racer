using UnityEngine;

public class DestroyerController : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    private void Update()
    {
        transform.position = new Vector3(target.position.x - 80, transform.position.y, transform.position.z);
    }
}
