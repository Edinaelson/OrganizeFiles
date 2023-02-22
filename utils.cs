using System.IO;
using System.Runtime.CompilerServices;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace FileChecks;
using static FileChecks.Color;

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

    public static void moveVideos()
    {
        colorUkraine();
        //string[] directory = Directory.GetDirectories(@"C:\\Users\\sedin\\Downloads\\Video");
        string path = @"C:\\Users\\sedin\\Downloads\\Video";
        string[] archives = Directory.GetFiles(path, "*mkv");
        
        string destiny = path + "\\";

        //for para achar arquivos repetidos
        int contName = 0;
        
        for (int i = 0; i < archives.Length; i++)
        {
            var files = new FileInfo(archives[i]);
            
            if (files.Name.Substring(0,3).Equals(files.Name.Substring(0,3)))
            {
                contName += 1;
            }

            if (contName >=1)
            {
                if (!Directory.Exists(destiny + files.Name.Substring(0,3)))
                {
                    Directory.CreateDirectory(files.Name.Substring(0, 3));
                    Console.WriteLine("Pasta criado com sucesso!");
                }
                
                //bloco para enviar os archivos parecidos.
                for (int j = 0; j < archives.Length; j++)
                {
                    if (files.Name.Substring(0,3).Equals(files.Name.Substring(0,3)))
                    {
                        files.MoveTo(Path.Combine(destiny+files.Name.Substring(0,3), files.Name));
                        Console.WriteLine("arquivos enviados para pasta nova.");
                    }
                }
            }

            Console.WriteLine("Quantidade: " + contName);
            Console.WriteLine("Existe arquivos com nomes parecidos.");
        }
        
        /**
        string[] directory = Directory.GetDirectories(@"C:\\Users\\sedin\\Downloads\\Video");
        string paths = @"C:\Users\sedin\Downloads\\Video";
        string[] archives = Directory.GetFiles(paths, "*.mp4");

        for (int i = 0; i < archives.Length; i++)
        {
            var files = new FileInfo(archives[i]);
            string namePast = files.Name.Substring(0, 3);
            
            //criar pasta
            if (!Directory.Exists(files.Name.Substring(0,3)))
            {
                Directory.CreateDirectory(files.Name.Substring(0, 3));
            }
            
            Console.WriteLine("Criado com sucesso");
            files.MoveTo(Path.Combine(paths, files.Name));
            //Console.WriteLine("Nome: " + files.Name);
        }
        **/

        /**
        foreach (string a in archives)
        {
            Console.WriteLine(a);
        }
        Console.WriteLine("Quantidade: " + cont);
        */

        //string texto = "edinaelson";
        //Console.WriteLine("texto: " + texto.Substring(0,3));
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