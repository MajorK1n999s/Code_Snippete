using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlayPauseScript : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject gmeObjPlayBtn, gmeObjPauseBtn, gmeObjPlayIcon, gmeObjPauseIcon, gmeObjHomeBtn, gmeObjBackBtn;

    private void OnEnable()
    {
        gmeObjPlayBtn.SetActive(false);
        gmeObjPlayIcon.SetActive(false);
        gmeObjPauseBtn.SetActive(true);
        gmeObjPauseIcon.SetActive(false);
        gmeObjHomeBtn.SetActive(false);
        gmeObjBackBtn.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void playVideo()
    {
        StopAllCoroutines();
        videoPlayer.Play();
        gmeObjPlayBtn.SetActive(false);
        gmeObjPlayIcon.SetActive(true);
        gmeObjPauseBtn.SetActive(true);
        gmeObjPauseIcon.SetActive(false);
        gmeObjHomeBtn.SetActive(false);
        gmeObjBackBtn.SetActive(false);
        StartCoroutine(hideVideoControllers());
    }

    public void pauseVideo()
    {
        StopAllCoroutines();
        videoPlayer.Pause();
        gmeObjPlayBtn.SetActive(true);
        gmeObjPlayIcon.SetActive(false);
        gmeObjPauseBtn.SetActive(false);
        gmeObjPauseIcon.SetActive(true);
        gmeObjHomeBtn.SetActive(true);
        gmeObjBackBtn.SetActive(true);
    }

    IEnumerator hideVideoControllers()
    {
        gmeObjPlayBtn.SetActive(true);
        gmeObjPlayIcon.SetActive(true);
        yield return new WaitForSeconds(2);
        gmeObjPlayBtn.SetActive(false);
        gmeObjPlayIcon.SetActive(false);
        gmeObjPauseBtn.SetActive(true);
        gmeObjPauseIcon.SetActive(false);
    }
}
