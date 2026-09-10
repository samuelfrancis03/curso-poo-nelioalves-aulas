using System.IO;


//FileFileInfoIOException();
FileStreamStreamReaderV1();
//FileStreamStreamReaderV2();
//UsingBlock();
//FileStreamWriter();
//DirectoryDirectoryInfo();
//FilePath();


void FileFileInfoIOException()
{
    //caminho de origem 
    string sourcePath = @"C:\Projetos\CursoPooNelioAlves\AulaArquivos\file1.txt"; //@ - evita usar duas barra no caminho Ex."C:\\Projetos\\...: 

    //caminho de destino
    string targetPath = @"C:\Projetos\CursoPooNelioAlves\AulaArquivos\file2.txt";

    try
    {
        FileInfo fileInfo = new FileInfo(sourcePath);
        fileInfo.CopyTo(targetPath); // CopyTo -> Faz uma copia o arquivo de origem

        string[] lines = File.ReadAllLines(sourcePath); // ReadAllLines -> Define todas as linhas do arquivo como um elemento do vertor
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }



    }
    catch (IOException e)
    {
        Console.WriteLine("An error occurred: " + e.Message);
    }

}


void FileStreamStreamReaderV1() //Versão com FileStream
{
    string path = @"C:\Projetos\CursoPooNelioAlves\AulaArquivos\file1.txt";

    FileStream fs = null; //server para acessar
    StreamReader sr = null; //serve para fazer operaçõe

    try
    {
        fs = new FileStream(path, FileMode.Open); //Instanciando o FileStream com agumentos do caminho e o modo que queremos operar sobre ele
        sr = new StreamReader(fs); // Instanciando o StreamReader com o a instancia do FileStream, para ler o documento aberto
        string line = sr.ReadLine(); //lendo a primeira linha
        Console.WriteLine(line);
    }
    catch (IOException e)
    {
        Console.WriteLine("An error occurred: " + e.Message);
    }
    finally //fechando as streams idependente de erro ou sucesso 
    {
        if (sr != null)
        {
            sr.Close();
        }
        if (fs != null) fs.Close();

    }
}

void FileStreamStreamReaderV2() //Versão simplificada com classe pai File
{
    string path = @"C:\Projetos\CursoPooNelioAlves\AulaArquivos\file1.txt";

    StreamReader sr = null; //serve para fazer operaçõe

    try
    {
        sr = File.OpenText(path); // File.OpenText -> Instancia o FileStream e StreamReader, em uma mesma operação para conseguir ler o arquivo
        while (!sr.EndOfStream)
        {
            string line = sr.ReadLine(); //lendo a primeira linha
            Console.WriteLine(line);
        }


    }
    catch (IOException e)
    {
        Console.WriteLine("An error occurred: " + e.Message);
    }
    finally //fechando as streams idependente de erro ou sucesso 
    {
        if (sr != null)
        {
            sr.Close();
        }


    }
}


void UsingBlock()
{

    try
    {
        string path = @"C:\Projetos\CursoPooNelioAlves\AulaArquivos\file1.txt";


        using (StreamReader sr = File.OpenText(path)) //Após a execução desse bloco, os recursos do File serão fechados automaticamente
        {
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine(); //lendo a primeira linha
                Console.WriteLine(line);
            }
        }

    }
    catch (IOException e)
    {
        Console.WriteLine("An error occurred: " + e.Message);
    }


}


void FileStreamWriter() 
{
    string sourcePath = @"C:\Projetos\CursoPooNelioAlves\AulaArquivos\file1.txt";
    string targetPath = @"C:\Projetos\CursoPooNelioAlves\AulaArquivos\file2.txt";

    try
    {
        string[] lines = File.ReadAllLines(sourcePath);

        using (StreamWriter sw = File.AppendText(targetPath))  // AppendText -> Adiciona o texto que sera escrito no final do arquivo
        {
            foreach (string line in lines) 
            {
                sw.WriteLine(line.ToUpper());
            }
        }




    }
    catch (IOException e)
    {
        Console.WriteLine("An error occurred: " + e.Message);
    }

}

void DirectoryDirectoryInfo() 
{
    //Diretorio de origem
    string path = @"C:\Projetos\CursoPooNelioAlves\AulaArquivos";

    try
    {
        //Listando pastas a partir de uma pasta informada
        IEnumerable<string> folders =  Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories); //Pega todas as subpastas a partir do diretorio de origem
        Console.WriteLine("FOLDERS: ");

        foreach (string s in folders) 
        {
            Console.WriteLine(s);
        }

        Console.WriteLine();

        //Listando arquivos a partir de uma pasta informada
        IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories); //Pega todas os arquivos a partir do diretorio de origem
        Console.WriteLine("FILES: ");

        foreach (string s in files)
        {
            Console.WriteLine(s);
        }

        Console.WriteLine();

        //Criando pasta 
        Directory.CreateDirectory(path + @"\Pasta3");
    }
    catch (IOException e)
    {
        Console.WriteLine("An error occurred: " + e.Message);
    }

}

void FilePath() 
{
    string path = @"C:\Projetos\CursoPooNelioAlves\AulaArquivos\file1.txt";

    Console.WriteLine("GetFileName: " + Path.GetFileName(path));
    Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
    Console.WriteLine("GetExtension: " + Path.GetExtension(path));
    Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
    Console.WriteLine("PathSeparator: " + Path.PathSeparator);
    Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
    Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
    Console.WriteLine("GetTempPath: " + Path.GetTempPath);
}
