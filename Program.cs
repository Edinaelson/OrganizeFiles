using System.Diagnostics;
using FileChecks.controller;
class Program
{
    static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();
        
        stopwatch.Start();
        
        MoveDocs.MoveDocumentos();
        MoveVideo.moveVideo();
        MoveMusic.moveMusic();
        MovePictures.MoveImg();
        MoveProgram.MoveProgramas();
        
        MoveVideo.printContVideos();
        MoveDocs.printContDocs();
        MoveProgram.printContPrograms();
        MovePictures.printContImagens();
        MoveMusic.printContMusics();
        
        stopwatch.Stop();
        
        Console.WriteLine($"Tempo decorrido: {stopwatch.ElapsedMilliseconds} ms");
    }
}