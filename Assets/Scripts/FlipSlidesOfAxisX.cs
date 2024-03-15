using UnityEngine;

/// <summary>
/// Поворот спрайтов воды в пещере
/// </summary>
public class FlipSlidesOfAxisX : MonoBehaviour
{
    private SpriteRenderer SpriteRender;
    private bool isFlipX = false;
    private float maxFlip = 0.5f;
    private float speedFlip = 0f;

    private void Awake()
    {
        SpriteRender = GetComponent<SpriteRenderer>();
    }

    private void FlipSprite()
    {
        if (isFlipX)
        {
            SpriteRender.flipX = isFlipX;
            isFlipX = !isFlipX;
        }
        else
        {
            SpriteRender.flipX = isFlipX;
            isFlipX = !isFlipX;
        }
    }

    private void FixedUpdate()
    {
        speedFlip += Time.deltaTime;
        if (speedFlip >= maxFlip)
        {
            FlipSprite();
            speedFlip = 0f;
        }
    }
}
