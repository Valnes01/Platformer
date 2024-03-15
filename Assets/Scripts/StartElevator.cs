using UnityEngine;

public class StartElevator : MonoBehaviour
{
    [SerializeField] private SliderJoint2D elevator;
    private JointMotor2D elevatorSlider;
    private float elevatorUpSpeed = 1f;
    private float elevatorDownSpeed = -1f;

    private void Awake()
    {
        elevatorSlider = elevator.motor;
    }

    public void GoStartDownElevator()
    {
        elevatorSlider.motorSpeed = elevatorDownSpeed;
        elevator.motor = elevatorSlider; 
    }

    public void GoStartUpElevator()
    {
        elevatorSlider.motorSpeed = elevatorUpSpeed;
        elevator.motor = elevatorSlider;
    }

}
