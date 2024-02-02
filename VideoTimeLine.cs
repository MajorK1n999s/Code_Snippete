using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoTimeLine : MonoBehaviour
{
    public VideoPlayer player;

    bool isDragged = false;

    private void Update() {

        if (player.frameCount > 0 && !isDragged)
        {
            GetComponent<Slider>().value = (float)player.frame / (float)player.frameCount;
        }
        else 
        {
            if (Input.GetMouseButtonUp(0)) 
            {
                player.Pause();
                player.frame = (long)(player.frameCount * GetComponent<Slider>().value);
                isDragged = false;
                player.Play();
            }
        }
    }
    public void timeLineDragged()
    {
        isDragged = true;
    }

    public void timeLineDropped()
    {
        player.Pause();
        player.frame = (long)(player.frameCount * GetComponent<Slider>().value);   
        isDragged = false;
        player.Play();
    }

    public void timeLineClicked()
    {
        player.frame = (long)(player.frameCount * GetComponent<Slider>().value);
    }

}
