using System;
public static class LevelPickerData
{
    private static int CurrentPickedLevel { get; set; }
    private static int MaxLevels { get; set; }

    static LevelPickerData()
    {
        CurrentPickedLevel = 0;
    }

    public static void SetMaxLevels(int max)
    {
        MaxLevels = max;
    }
    public static void GetNextLevel()
    {
        if (MaxLevels != CurrentPickedLevel + 1)
        {
            CurrentPickedLevel += 1;
        }
        else
        {
            throw new Exception("no More levels");
        }

    }
    public static void GetPreviousLevel()
    {
        if (CurrentPickedLevel - 1 >= 0)
        {
            CurrentPickedLevel -= 1;
        }
        else
        {
            throw new Exception("no More levels");
        }

    }
    public static int GetCurrentLevel() {
        return CurrentPickedLevel;
    }


}