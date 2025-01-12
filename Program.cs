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
        
        MoveVideo.imprimirContagemVideos();
        MoveDocs.imprimirContagemDocumentos();
        MoveProgram.imprimirContagemProgramas();
        MovePictures.imprimirContagemImagens();
        MoveMusic.imprimirContagemMusicas();
        
        stopwatch.Stop();
        
        Console.WriteLine($"Tempo decorrido: {stopwatch.ElapsedMilliseconds} ms");
    }
}