using UnityEngine;

public class soapKill : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Monster"))
        {
            collision.gameObject.SetActive(false);
        }
    }
}
