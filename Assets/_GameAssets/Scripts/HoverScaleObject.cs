using UnityEngine;

public class HoverScale : MonoBehaviour
{
    [SerializeField] float scale = 1.1f;

    Vector3 originalScale;

    void Start()
    {
        originalScale = transform.localScale;
    }
    void OnMouseEnter()
    {
        transform.localScale = Vector3.one * scale;
    }

    void OnMouseExit()
    {
        transform.localScale = originalScale;
    }
}
