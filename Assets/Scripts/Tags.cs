using UnityEngine;

public static class Tags {
    public static string BALL = "BALL";
    public static string LEVEL_MANAGER = "LevelManager";
    public static string GAME_MANAGER = "GameManager";
    public static string CAMERA_MANAGER = "CameraManager";
    public static string GOAL = "Goal";
    public static string FAIL = "Fail";
    public static string SOUND_MANAGER = "SoundManager";
    public static string TIME_MANAGER = "Counter";
}

public static class Buttons
{
    public static string JUMP = "Jump";
    public static string PAUSE = "Pause";
}

public static class Scenes
{
    public static string MAIN_MENU = "MenuScene";
    public static string PLAYING_SCENE = "PlayingScene";
    public static string LEVEL_PICKER_SCENE = "LevelPickerScene";
}

public static class PrefKeys
{
    public static string VOLUME = "VOLUME";
    public static string USE_PROCESSING = "USE_PROCESSING";
}

public enum Clips
{
    AWW=1,
    CLAP=2,
}