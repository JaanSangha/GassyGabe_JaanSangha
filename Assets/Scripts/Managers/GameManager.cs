using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Cinemachine;

public class GameManager : Singleton<GameManager>
{
    public TMP_Text HintBar;
    public TMP_Text ResultText;
    public bool cursorActive = true;
    public GameObject EndScreen;
    public GameObject pauseScreen;
    public GameObject textBG;
    public bool IsPaused;
    public bool isDriving = false;
    public CinemachineVirtualCamera camera;
    public Transform playerTarget;
    public Transform carTarget;
    public GameObject playerRef;
    public GameObject carRef;

    private SkinnedMeshRenderer renderer;
    //sound manager
    public AudioSource audioSource;
    public AudioClip runMusic;
    public AudioClip menuMusic;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        IsPaused = false;
        Time.timeScale = 1;
        renderer = playerRef.GetComponentInChildren<SkinnedMeshRenderer>();
    }
    void EnableCursor(bool enable)
    {
        if (enable)
        {
            cursorActive = true;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            cursorActive = false;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    public void SwapPlayer()
    {
        if (isDriving)
        {
            isDriving = !isDriving;
            carRef.GetComponent<Rigidbody>().velocity = Vector3.zero;
            camera.Follow = playerTarget;
            renderer.enabled = true;
            Debug.Log("Is Driving: " + isDriving);
            playerRef.transform.parent = null;
            playerRef.transform.position = new Vector3(carRef.transform.position.x - 3, carRef.transform.position.y, carRef.transform.position.z);
        }
        else
        {
            isDriving = !isDriving;
            camera.Follow = carTarget;
            playerRef.transform.parent = carRef.transform;
            renderer.enabled = false;
            Debug.Log("Is Driving: " + isDriving);
        }

    }

        private void OnEnable()
    {
        AppEvents.MouseCursorEnabled += EnableCursor;
    }
    private void OnDisable()
    {
        AppEvents.MouseCursorEnabled -= EnableCursor;
    }

    public void SetHintBar(string message)
    {
        HintBar.SetText(message);
    }

    public void GameOver(string result)
    {
        Time.timeScale = 0;
        HintBar.gameObject.SetActive(false);
        EndScreen.SetActive(true);
        ResultText.SetText(result);
        textBG.SetActive(false);
        audioSource.clip = menuMusic;
        audioSource.Play();
    }

    public void PauseGame()
    {
        if (IsPaused) return;
        pauseScreen.SetActive(true);
        Time.timeScale = 0;
        HintBar.gameObject.SetActive(false);
        IsPaused = true;
        textBG.SetActive(false);
    }

    public void ResumeGame()
    {
        pauseScreen.SetActive(false);
        Time.timeScale = 1;
        HintBar.gameObject.SetActive(true);
        IsPaused = false;
        textBG.SetActive(true);
    }

    public void SetRunMusic()
    {
        audioSource.clip = runMusic;
        audioSource.Play();
    }

    public void MainMenuPressed()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitPressed()
    {
        Application.Quit();
    }

    public void RestartPressed()
    {
        SceneManager.LoadScene("Main");
    }
}