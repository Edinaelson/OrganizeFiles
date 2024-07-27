namespace FileChecks.controller;

public class MoveMusic
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
            if(!files.Name.Equals(files.Name))
            {
                files.MoveTo(Path.Combine(destiny, files.Name));
            }
            else
            {
                files.MoveTo(Path.Combine(destiny, files.Name));
            }
            
        }
        
    }
    
    public static string moveMusic()
    {
        
        // caminho da pasta de Musicas
        
        string[] archivesMp3 = Directory.GetFiles(@Names.path, "*.mp3");
        string[] archivesM4a = Directory.GetFiles(@Names.path, "*.m4a");
        string[] archivesWav = Directory.GetFiles(@Names.path, "*.wav");
        string[] archivesWma = Directory.GetFiles(@Names.path, "*.wma");
        string[] archivesAu = Directory.GetFiles(@Names.path, "*.au");
        
        string destiny = @Names.path + "\\Music";
        
        utils.moveArchive(archivesMp3, destiny);
        utils.moveArchive(archivesM4a, destiny);
        utils.moveArchive(archivesWav, destiny);
        utils.moveArchive(archivesWma, destiny);
        utils.moveArchive(archivesAu, destiny);
        
        Color.color("Música");
    }
    
}