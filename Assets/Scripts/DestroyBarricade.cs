using UnityEngine;

public class DestroyBarricade : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            Destroy(collision.gameObject, 4f);
            Destroy(gameObject, 5f);
        }
    }
}
