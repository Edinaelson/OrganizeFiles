using FileChecks;

public class ListOfExtensions
{
    public static string[] DoscList()
    {
        string[] docs = {
            ".rar", ".docx", ".doc", ".pdf", ".zip", ".txt", ".xml", ".cbs", ".conf", ".ext", ".7z", ".bml",
            ".xps", ".csv", ".ods", ".xls", ".xlsx", ".xltm",
            ".bmp", ".odp", ".ppt", ".pptx", ".rtf", ".odg", ".odt", ".docm", ".excalidraw", ".torrent"
        };
        return docs;
    }

    public static string[] MusicList()
    {
        string[] docs = { ".mp3", ".m4a", ".wav", ".wma", ".au"};
        return docs;
    }

    public static string[] PicturesList()
    {
        string[] docs = { ".jpg", ".jpeg", ".png", ".psd", ".svg", ".gif", ".icon", ".ico", ".webp" };
        return docs;
    }

    public static string[] ProgramList()
    {
        string[] docs = { ".exe", ".iso", ".dll", ".pdb", ".json", ".msi", ".apk" };
        return docs;
    }

    public static string[] VideoList()
    {
        string[] docs = { ".mp4", ".avi", ".mov", ".mpg", ".mpeg", ".flv", ".mkv", ".wmv" };
        return docs;
    }

    /// <summary>
    /// Verifica se a extensão do arquivo pertence à lista fornecida (case-insensitive)
    /// </summary>
    public static bool IsExtensionInList(string filePath, string[] extensionList)
    {
        string fileExtension = Path.GetExtension(filePath).ToLower();
        return extensionList.Any(ext => ext.ToLower() == fileExtension);
    }

    /// <summary>
    /// Obtém todas as extensões registradas
    /// </summary>
    public static string[] GetAllRegisteredExtensions()
    {
        var allExtensions = DoscList()
            .Concat(MusicList())
            .Concat(PicturesList())
            .Concat(ProgramList())
            .Concat(VideoList())
            .Distinct()
            .ToArray();
        return allExtensions;
    }

    /// <summary>
    /// Verifica se o arquivo está em uma das categorias registradas
    /// </summary>
    public static bool IsCategorized(string filePath)
    {
        return IsExtensionInList(filePath, DoscList()) ||
               IsExtensionInList(filePath, MusicList()) ||
               IsExtensionInList(filePath, PicturesList()) ||
               IsExtensionInList(filePath, ProgramList()) ||
               IsExtensionInList(filePath, VideoList());
    }
}