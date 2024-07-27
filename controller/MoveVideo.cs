namespace FileChecks.controller;

public class MoveVideo
{
    public static void moveVideo()
    {
        string[] archivesMp4 = Directory.GetFiles(@Names.path, "*.mp4");
        string[] archivesAvi = Directory.GetFiles(@Names.path, "*.avi");
        string[] archivesMov = Directory.GetFiles(@Names.path, "*.mov");
        string[] archivesMpg = Directory.GetFiles(@Names.path, "*.mpg");
        string[] archivesMpeg = Directory.GetFiles(@Names.path, "*.mpeg");
        string[] archivesWmv = Directory.GetFiles(@Names.path, "*.wmv");
        string[] archivesFlv = Directory.GetFiles(@Names.path, "*.flv");
        string[] archivesMkv = Directory.GetFiles(@Names.path, "*.mkv");

        string destiny = @Names.path + "\\Video";

        utils.moveArchive(archivesMp4, destiny);
        utils.moveArchive(archivesAvi, destiny);
        utils.moveArchive(archivesMov, destiny);
        utils.moveArchive(archivesMpg, destiny);
        utils.moveArchive(archivesMpeg, destiny);
        utils.moveArchive(archivesWmv, destiny);
        utils.moveArchive(archivesFlv, destiny);
        utils.moveArchive(archivesMkv, destiny);

        Color.color("Videos");
    }
}