using Platformer.Inputs;
using UnityEngine;
using UnityEngine.UI;

public class TriggerForEPressed : MonoBehaviour
{
    private bool isPressedE = false;

    private void Update()
    {
        if (isPressedE)
        {
            gameObject.GetComponent<Button>().onClick.Invoke();
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<PlayerInput>().isActivatorEKyeDown = true;
            isPressedE = other.GetComponent<PlayerInput>().isActiveEButton;
        }      
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<PlayerInput>().isActivatorEKyeDown = false;
            isPressedE = other.GetComponent<PlayerInput>().isActiveEButton;
        }
    }
}
