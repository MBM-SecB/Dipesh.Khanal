
using System;
using System.IO;

    public class FileIO
{
    public void LearnFileHandling()
    {
        // string filepath= @"F:\MBM class\Net centric and computing\dotnet\Dipesh.Khanal\README.md";
        String fileWithInProject = "Generics.cs";
        bool isFileThere = File.Exists(fileWithInProject);

        if(isFileThere)
        {
            var fileContent = File.ReadAllText(fileWithInProject);
            Console.WriteLine(fileContent);
        }

    }

public void LearnFileWriting()
{
 string filepath ="Abc.txt";
 File.WriteAllText(filepath,"I want to write here using other class");
}

public void LearnFileInfo(){
 string filepath ="Abc.txt";
 FileInfo fileInfo = new FileInfo(filepath);
 var size = fileInfo.Length;
 var createDate = fileInfo.CreationTime;
 Console.WriteLine(filepath);
 Console.WriteLine($"Size: {size}");
 Console.WriteLine($"created: {createDate}");

}
public void LearnDirectory()
{   
    String folderPath = "MBM";
    // Directory.CreateDirectory(folderPath);
    Console.WriteLine($"Do you want to Delete {folderPath} folder ");
    String Confirm = Console.ReadLine();
    if(Confirm == "y"){
    Directory.Delete(folderPath);
    }

}


}

