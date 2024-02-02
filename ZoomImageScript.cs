using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ZoomImageScript : MonoBehaviour, IScrollHandler
{
    private Vector3 initialScale;
    [SerializeField]
    private float zoomSpeed = 0.1f;
    [SerializeField]
    private float maxZoom = 10f;
    public float zoomOutMin = 1f;
    public float zoomOutMax = 10f;

    private void Awake()
    {
        initialScale = transform.localScale;
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnEnable()
    {
        GetComponentInParent<ScrollRect>().enabled = false;
        GetComponentInParent<RectTransform>().anchoredPosition = new Vector2(0f, 0f);
        GetComponentInParent<RectTransform>().localScale = new Vector3(1f, 1f, 1f);
        GetComponentInParent<Image>().preserveAspect = true;
    }

    // Update is called once per frame
    void Update()
    {
        float difference = 0f;
        if (Input.touchCount == 2)
        {
            GetComponentInParent<ScrollRect>().enabled = false;
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            float prevMagnitude = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float currentMagnitude = (touchZero.position - touchOne.position).magnitude;

            difference = currentMagnitude - prevMagnitude;

            zoom(difference * 0.01f);
        }
        else if (Input.touchCount == 1)
        {
            GetComponentInParent<ScrollRect>().enabled = true;
            if (difference > 0)
            {
                var desiredScale = new Vector3(0.10f, 0.10f, 0.10f);
                desiredScale = ClampDesiredScale(desiredScale);
                transform.localScale = desiredScale;
            }
            else if (difference < 0)
            {
                var desiredScale = new Vector3(-0.10f, -0.10f, -0.10f);
                desiredScale = ClampDesiredScale(desiredScale);
                transform.localScale = desiredScale;
            }
        }
    }

    void zoom(float increment)
    {
        float factor = Mathf.Clamp(gameObject.transform.localScale.x + increment, zoomOutMin, zoomOutMax);
        gameObject.transform.localScale = new Vector3(factor, factor, 1);
        if (gameObject.transform.localScale == new Vector3(1.00f, 1.00f, 1.00f))
        {
            GetComponentInParent<RectTransform>().anchoredPosition = new Vector2(0f, 0f);
        }
    }

    public void OnScroll(PointerEventData eventData)
    {
        GetComponentInParent<ScrollRect>().enabled = true;
        var delta = Vector3.one * (eventData.scrollDelta.y * zoomSpeed);
        var desiredScale = transform.localScale + delta;
        if (GetComponentInParent<RectTransform>().localScale == new Vector3(1.00f, 1.00f, 1.00f))
        {
            GetComponentInParent<RectTransform>().anchoredPosition = new Vector2(0f, 0f);
        }
        desiredScale = ClampDesiredScale(desiredScale);
        transform.localScale = desiredScale;
    }

    private Vector3 ClampDesiredScale(Vector3 desiredScale)
    {
        desiredScale = Vector3.Max(initialScale, desiredScale);
        desiredScale = Vector3.Min(initialScale * maxZoom, desiredScale);
        return desiredScale;
    }
}
