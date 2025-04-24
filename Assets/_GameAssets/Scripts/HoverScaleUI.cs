using UnityEngine;
using UnityEngine.EventSystems;

public class HoverScaleUI : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] float scale;
    Vector3 originalScale;

    void Start()
    {
        originalScale = transform.localScale;
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.localScale = Vector3.one * scale;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.localScale = originalScale;
    }
}
