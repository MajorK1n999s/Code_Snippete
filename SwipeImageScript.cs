using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeImageScript : MonoBehaviour
{
    public static SwipeImageScript insSwipeImageScript;

    private Vector3 firstTouchPosition;
    private Vector3 lastTouchPosition;
    private float minDragDistance;

    public Image imgImage;
    public List<Sprite> sprtImageSpritesList;
    private int imageIndex = 0;

    private void Awake()
    {
        insSwipeImageScript = this;
    }

    private void OnEnable() {
        imageIndex = 0;
        imgImage.sprite = sprtImageSpritesList[imageIndex];
    }

    // Start is called before the first frame update
    void Start()
    {
        minDragDistance = Screen.height * 15 / 100;

        imageIndex = 0;
        imgImage.sprite = sprtImageSpritesList[imageIndex];
    }

    // Update is called once per frame
    void Update()
    {
        this.triggerImageSwipper();
    }

    private void triggerImageSwipper()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                firstTouchPosition = touch.position;
                lastTouchPosition = touch.position;
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                lastTouchPosition = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                lastTouchPosition = touch.position;
                if (Mathf.Abs(lastTouchPosition.x - firstTouchPosition.x) > minDragDistance ||
                Mathf.Abs(lastTouchPosition.y - firstTouchPosition.y) > minDragDistance)
                {
                    if (Mathf.Abs(lastTouchPosition.x - firstTouchPosition.x) > Mathf.Abs(lastTouchPosition.y - firstTouchPosition.y))
                    {
                        if ((lastTouchPosition.x > firstTouchPosition.x))
                        {
                            this.swipeImageBackward();
                        }
                        else
                        {
                            this.swipeImageForward();
                        }
                    }
                }
            }
        }
    }

    public void swipeImageForward()
    {
        if (imageIndex == (sprtImageSpritesList.Count - 1))
        {
            imageIndex = 0;
        }
        else
        {
            imageIndex++;
        }
        imgImage.sprite = sprtImageSpritesList[imageIndex];
    }

    public void swipeImageBackward()
    {
        if (imageIndex > 0)
        {
            imageIndex--;
        }
        else
        {
            imageIndex = (sprtImageSpritesList.Count - 1);
        }
        imgImage.sprite = sprtImageSpritesList[imageIndex];
    }
}
