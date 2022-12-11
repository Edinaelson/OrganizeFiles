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

    /**
     * fazer metodo para criar pasta com o nome do arquivo.
     * criacao de pasta // estudar criação de pastas e subpastas
     * checkvideo = files.Name.Substring(0, 7);
     */

    public static void moveprograms(string[] archive, string destiny)
    {
        if (!Directory.Exists(destiny))
        {
            Directory.CreateDirectory(destiny);
        }
        
        for (int i = 0; i < archive.Length; i++)
        {
            var files = new FileInfo(archive[i]);
            if (!files.Name.Equals("FileChecks.exe"))
            {
                files.MoveTo(Path.Combine(destiny, files.Name));
            }
        }
    }

}