using UnityEngine;

public class SecretEarthWision : MonoBehaviour
{
    private SpriteRenderer secretSprite;
    private Color spriteColor;

    private void Awake()
    {
        secretSprite = GetComponent<SpriteRenderer>();
        spriteColor = secretSprite.color;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            spriteColor.a = 0.8f;
            secretSprite.color = spriteColor;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            spriteColor.a = 1f;
            secretSprite.color = spriteColor;
        }
    }
}
