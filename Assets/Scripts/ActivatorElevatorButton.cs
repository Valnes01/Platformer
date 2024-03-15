using UnityEngine;

public class ActivatorElevatorButton : MonoBehaviour
{
    [SerializeField] private GameObject elevator;
    [SerializeField] private GameObject buttonStartElevatorOne;
    [SerializeField] private GameObject buttonStartElevatorTwo;
    [SerializeField] private Sprite activeButtonSprite;
    [SerializeField] private Sprite deactiveButtonSprite;
    private SpriteRenderer oneButtonSprite;
    private SpriteRenderer twoButtonSprite;
    private float maxElevatorPosition = 6.9f;
    private float minElevatorPosition = -4.2f;

    private void Awake()
    {
        oneButtonSprite = buttonStartElevatorOne.GetComponent<SpriteRenderer>();
        twoButtonSprite = buttonStartElevatorTwo.GetComponent<SpriteRenderer>();
    }

    private void ActivatorButton()
    {
        if (elevator.transform.position.y >= maxElevatorPosition)
        {
            oneButtonSprite.sprite = activeButtonSprite;
        }
        else if (elevator.transform.position.y <= minElevatorPosition)
        {
            twoButtonSprite.sprite = activeButtonSprite;
        }
        else
        {
            oneButtonSprite.sprite = twoButtonSprite.sprite = deactiveButtonSprite;
        }
    }

    private void Update()
    {
        ActivatorButton();
    }
}
