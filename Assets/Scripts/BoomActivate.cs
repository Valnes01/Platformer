using UnityEngine;

public class BoomActivate : MonoBehaviour
{
    [SerializeField] private GameObject flameBoom;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            if (other.GetComponent<PointEffector2D>() != null)
            {
                other.GetComponent<PointEffector2D>().enabled = true;
            }
            flameBoom.SetActive(true);
        }
    }
}
