using System.Diagnostics;
using System.Reflection;
using FileChecks;
class Program
{
    static void Main(string[] args)
    {

        //var assembly = Assembly.GetExecutingAssembly();
        //Console.WriteLine($"AssemblyVersion: {assembly.GetName().Version}");

        //var fileVersion = assembly.GetCustomAttribute<AssemblyFileVersionAttribute>()?.Version;
        //Console.WriteLine($"FileVersion: {fileVersion}");

        //var infoVersion = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;
        //Console.WriteLine($"InformationalVersion: {infoVersion}");

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
        Color.Sucess("Aperte qualquer tecla para sair!");
        Console.ReadKey();
    }
}