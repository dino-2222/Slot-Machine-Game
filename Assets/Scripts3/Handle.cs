using UnityEngine;

public class SpriteSwapOnCollision : MonoBehaviour
{
    [Header("Sprite Renderers")]
    public SpriteRenderer spriteToDisable;
    public SpriteRenderer spriteToEnable;

    public bool hasTriggered = false;

    private void Start()
    {
        // Make sure the second sprite starts disabled
        if (spriteToEnable != null)
            spriteToEnable.enabled = false;
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (hasTriggered) return;

    //    hasTriggered = true;

    //    if (spriteToDisable != null)
    //        spriteToDisable.enabled = false;
            
    //    if (spriteToEnable != null)
    //        spriteToEnable.enabled = true;
    //}
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (hasTriggered) return;

        hasTriggered = true;

        spriteToDisable.enabled = false;
        spriteToEnable.enabled = true;
    }
}