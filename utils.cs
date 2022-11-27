namespace FileChecks;

public static class utils
{
    public static void moveArchive(string[] archive, string destiny)
    {
        
        /**
         * files move for folder and create folder if not exists*
         */
        
        if (!Directory.Exists(destiny))
        {
            Directory.CreateDirectory(destiny);
        }
        
        for (int i = 0; i < archive.Length; i++)
        {
            var files = new FileInfo(archive[i]);
            files.MoveTo(Path.Combine(destiny, files.Name));
        }
        
    }
}