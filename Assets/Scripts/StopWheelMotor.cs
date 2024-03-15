using UnityEngine;

public class StopWheelMotor : MonoBehaviour
{

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            GetComponent<WheelJoint2D>().useMotor = false; 
        }
    }
}
