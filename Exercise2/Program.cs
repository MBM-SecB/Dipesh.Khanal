using System.IO;

    class CreateDirectory
    {
        static void Main()
        {
            CreateDirectory folder = new CreateDirectory();
            folder.CreateDirectories();
        }

        public void CreateDirectories()
        {
            
        string rootFolderPath = "Nepal";
        Directory.CreateDirectory(rootFolderPath);
        string[] subfolders = {"Dotnet","Compiler","Construction","software","Engineering","ecommerce","egovernance","technical","writing","reading"};
        foreach(string sub in subfolders)
        {
            string subfolderPath = rootFolderPath + "/" + sub;
            Directory.CreateDirectory(subfolderPath);
            string filePath = subfolderPath + "/" + "test.txt";
            File.WriteAllText(filePath,sub);
        }
        }
    }