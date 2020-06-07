using System;
public static class LevelPickerData
{
    public static int CurrentPickedLevel { get; set; }


    static LevelPickerData()
    {
        CurrentPickedLevel = 0;
    }

}