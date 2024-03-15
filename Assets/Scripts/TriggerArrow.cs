using UnityEngine;

public class TriggerArrow : MonoBehaviour
{
    [SerializeField] private GameObject arrow;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            arrow.SetActive(true);
        }
    }
}
