﻿using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    private static GameManager _instance;  
    private ScoreManager _scoreManager;
    private string _difficulty;
    private float _bgmVolume;
    private float _sfxVolume;
    private bool _isGamePaused;
    private bool _isGameLost;
    private bool _isGameWon;
    private string _userName;
    private float _score;

    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                DontDestroyOnLoad(GameManager.Instance);
                Debug.LogError("Game Manager is NULL");
            }
            return _instance;
        }
    }
    public ScoreManager ScoreManager
    {
        get { return _scoreManager; }
        set { _scoreManager = value; }
    }
    public string Difficulty
    {
        get
        {
            return _difficulty;
        }

        set
        {
            _difficulty = value;
        }
    }
    public float BGMVolume
    {
        get
        {         
            return (_bgmVolume / 100);
        }
        set
        {
            _bgmVolume = value;           
        }
    }
    public float SFXVolume
    {
        get
        {            
            return (_sfxVolume / 100);
        }
        set
        {
            _sfxVolume = value;
            PlayerPrefs.SetFloat("SFX", value);
            PlayerPrefs.Save();
        }
    }
    public bool IsGamePaused
    {
        get { return _isGamePaused; }
        set { 
            _isGamePaused = value;
            if(value)
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            else
                Cursor.visible = false;
        }
    }
    public bool IsGameLost
    {
        get { return _isGameLost; }
        set
        {
            _isGameLost= value;
            _scoreManager.AddScore(UserName, Score);
            SceneManager.LoadScene("GameOver");
        }
    }
    public bool IsGameWon
    {
        get { return _isGameWon; }
        set
        {
            _isGamePaused = value;
            _scoreManager.AddScore(UserName, Score);
            SceneManager.LoadScene("GameWon");
        }
    }
    /// <summary>
    /// Player Username
    /// </summary>
    public string UserName
    {
        get
        {
            return _userName;
        }
        set
        {
            _userName = value;
        }
    }
    /// <summary>
    /// PLayer Score
    /// </summary>
    public float Score
    {
        get
        {
            return _score;
        }
        set
        {
            _score = value;
        }
    }
    //Awake is always called before any Start functions
    void Awake()
    {
        _instance = this;
        DontDestroyOnLoad(GameManager.Instance);      
        _scoreManager = new ScoreManager();
    }
        // Use this for initialization
    void Start () {
        _LoadPlayerSettings();
        _scoreManager.LoadScores();
    }
    private void _LoadPlayerSettings()
    {
        _difficulty = PlayerPrefs.GetString("Difficulty");
        _bgmVolume = PlayerPrefs.GetFloat("BGM");
        _sfxVolume = PlayerPrefs.GetFloat("SFX");
    }
    private void _savePlayerSettings()
    {
        PlayerPrefs.SetString("Difficulty", Difficulty);
        PlayerPrefs.SetFloat("SFX", SFXVolume);
        PlayerPrefs.SetFloat("BGM", BGMVolume);      
        PlayerPrefs.Save();
    }
    public void Quit()
    {
        _savePlayerSettings();
        _scoreManager.SaveScores();
        Application.Quit();
    }
}
