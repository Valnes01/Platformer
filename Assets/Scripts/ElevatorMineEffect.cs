using UnityEngine;

/// <summary>
/// Класс для увеличения-уменьшения цепи лифта
/// </summary>
public class ElevatorMineEffect : MonoBehaviour
{
    [SerializeField] private GameObject leftChain;
    [SerializeField] private GameObject rightChain;
    [SerializeField] private GameObject elevatorObject;
    private SpriteRenderer leftChainSprite;
    private SpriteRenderer rightChainSprite;
    private float heightLeftChain;
    private float heightRightChain;
    private float elevatorMaxHeight;
    private float elevatorHeight;

    private void Awake()
    {
        leftChainSprite = leftChain.GetComponent<SpriteRenderer>();
        rightChainSprite = rightChain.GetComponent<SpriteRenderer>();
        heightLeftChain = leftChainSprite.size.y;
        heightRightChain = rightChainSprite.size.y;
        elevatorMaxHeight = elevatorObject.transform.position.y;
    }

    private void Update()
    {
        elevatorHeight = elevatorMaxHeight - elevatorObject.transform.position.y;
        leftChainSprite.size = new Vector2(leftChainSprite.size.x, heightLeftChain + elevatorHeight);
        rightChainSprite.size = new Vector2(rightChainSprite.size.x, heightRightChain + elevatorHeight);
    }
}