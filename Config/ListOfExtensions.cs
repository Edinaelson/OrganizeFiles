using FileChecks.controller;

namespace FileChecks;

public class ListOfExtensions
{
    public static string[] DoscList()
    {
        string[] docs = {
            ".rar", ".docx", ".doc", ".pdf", ".zip", ".txt", ".xml",
            ".xps", ".csv", ".ods", ".xls", ".xlsb", ".xltm",
            ".bmp", ".odp", ".ppt", ".pptx", ".rtf", ".odg", ".odt", ".docm", ".excalidraw"
        };
        return docs;
    }

    public static string[] MusicList()
    {
        string[] docs =
        { ".mp3", ".m4a", ".wav", ".wma", ".au"};
        return docs;
    }

    public static string[] PicturesList()
    {
        string[] docs = { ".jpg", ".jpeg", ".png", ".psd", ".svg", ".gif" };
        return docs;
    }

    public static string[] ProgramList()
    {
        string[] docs = { ".exe", ".iso", ".dll", ".pdb", ".json", ".msi" };
        return docs;
    }

    public static string[] VideoList()
    {
        string[] docs = { ".mp4", ".avi", ".mov", ".mpg", ".mpeg", ".flv", ".mkv", ".wmv" };
        return docs;
    }
    
}