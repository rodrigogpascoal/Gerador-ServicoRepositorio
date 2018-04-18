using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Templates;

namespace WindowsFormsApp1
{
    public static class AppCoreCreator
    {
        public const string path = @"C:\Workspaces\Portal Gestao Obras\04. Sprints\Sprint.03\04. Codigo Fonte\PortalGestaoObras\src\WebArchitecture.ApplicationCore";
        public const string csprojFilePath = @"\WebArchitecture.ApplicationCore\WebArchitecture.ApplicationCore.csproj";
        public static FileInfo fi = new FileInfo(@".\a\bb\file.txt");

    
        public static void Create(string pathName, string entityName, string folderName, bool addFolder)
        {
            var pathIRepository = pathName + @"\WebArchitecture.ApplicationCore\Interfaces\Repositories";
            var di = new DirectoryInfo(@pathIRepository + "\\" + folderName);
            if (addFolder)
            {
                var filename = pathIRepository + "\\" + folderName + "\\I" + entityName + "Repository.cs";
                CreateFolderAndFileIRepository(di, filename, folderName, "."+folderName, entityName);
            }
            else
            {
                var filename = pathIRepository + "\\I" + entityName + "Repository.cs";
                CreateFolderAndFileIRepository(di, filename, folderName, "", entityName);
            }
            ///IService
            var pathIServices = pathName + @"\WebArchitecture.ApplicationCore\Interfaces\Services";
            di = new DirectoryInfo(pathIServices + "\\" + folderName);
            if (addFolder)
            {
                var filename = pathIServices + "\\" + folderName + "\\I" + entityName + "Service.cs";
                CreateFolderAndFileIService(di, filename, folderName, "." + folderName, entityName);
            }
            else
            {
                var filename = pathIServices + "\\I" + entityName + "Service.cs";
                CreateFolderAndFileIService(di, filename, folderName, "", entityName);
            }
            ///Service
            var pathServices = pathName + @"\WebArchitecture.ApplicationCore\Services";
            di = new DirectoryInfo(pathServices + "\\" + folderName);
            if (addFolder)
            {
                var filename = pathServices + "\\" + folderName + "\\" + entityName + "Service.cs";
                CreateFolderAndFileService(di, filename, folderName, "." + folderName, entityName);
            }
            else
            {
                var filename = pathServices + "\\" + entityName + "Service.cs";
                CreateFolderAndFileService(di, filename, folderName, "", entityName);
            }

            UpdateCsproj(pathName, folderName, entityName, addFolder);
        }

        private static void UpdateCsproj(string pathName, string folderName, string entityName, bool addFolder)
        {
            var baseText = "<Compile Include=\"Properties\\AssemblyInfo.cs\" />";

            var iRepositoryText = "<Compile Include=\"Interfaces\\Repositories{0}\\I{1}Repository.cs\" />\r\n";
            var serviceText = "<Compile Include=\"Services{0}\\{1}Service.cs\" />\r\n";
            var iServiceText = "<Compile Include=\"Interfaces\\Services{0}\\I{1}Service.cs\" />\r\n";

            if (addFolder)
            {
                iRepositoryText = String.Format(iRepositoryText, "\\"+folderName, entityName);
                serviceText = String.Format(serviceText, "\\" + folderName, entityName);
                iServiceText = String.Format(iServiceText, "\\" + folderName, entityName);
            }
            else {
                iRepositoryText = String.Format(iRepositoryText, "", entityName);
                serviceText = String.Format(serviceText, "", entityName);
                iServiceText = String.Format(iServiceText, "", entityName);
            }
            string text = File.ReadAllText(pathName+csprojFilePath);
            text = text.Replace(baseText, iRepositoryText + serviceText + iServiceText + baseText);
            File.WriteAllText(pathName + csprojFilePath, text);
        }

        private static void CreateFolderAndFileIRepository(DirectoryInfo di, string filename, string folderName, string folder, string entity)
        {
            if (!di.Exists)
            {
                di.Create();
            }
            fi = new FileInfo(filename);
            using (StreamWriter sw = fi.AppendText())
            {
                var classTemplate = String.Format(AppCoreTemplates.iRepositoryTemplate, folderName, folder, entity, entity);
                sw.Write(classTemplate);
            }           
            if (!fi.Exists)
            {
                fi.Create().Dispose();
            }
        }

        private static void CreateFolderAndFileIService(DirectoryInfo di, string filename, string folderName, string folder, string entity)
        {            
            if (!di.Exists)
            {
                di.Create();
            }
            fi = new FileInfo(filename);
            using (StreamWriter sw = fi.AppendText())
            {
                var classTemplate = String.Format(AppCoreTemplates.iServiceTemplate, folderName, folder, entity, entity);
                sw.Write(classTemplate);
            }
            if (!fi.Exists)
            {
                fi.Create().Dispose();
            }
        }

        private static void CreateFolderAndFileService(DirectoryInfo di, string filename, string folderName, string folder, string entity)
        {
            if (!di.Exists)
            {
                di.Create();
            }
            fi = new FileInfo(filename);
            using (StreamWriter sw = fi.AppendText())
            {
                string serviceTemplate = AppCoreTemplates.serviceTemplate.Replace("ReplaceIt", entity);
                var classTemplate = String.Format(serviceTemplate, folderName, folder, entity, entity);                
                sw.Write(classTemplate);
            }            
            if (!fi.Exists)
            {
                fi.Create().Dispose();
            }
        }
    }
}
