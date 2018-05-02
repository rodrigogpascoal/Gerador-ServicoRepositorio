using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Templates;

namespace WindowsFormsApp1
{
    class InfrastructureeCreator
    {
        public const string path = @"C:\Workspaces\Portal Gestao Obras\04. Sprints\Sprint.03\04. Codigo Fonte\PortalGestaoObras\src\WebArchitecture.Infrastructure";
        public const string csprojFilePath = @"\WebArchitecture.Infrastructure\WebArchitecture.Infrastructure.csproj";
        public static FileInfo fi = new FileInfo(@".\a\bb\file.txt");

        public static void Create(string pathName, string entityName, string folderName, bool addFolder)
        {
            var pathIRepository = pathName + @"\WebArchitecture.Infrastructure\Data\Repositories";
            var di = new DirectoryInfo(@pathIRepository + "\\" + folderName);
            if (addFolder)
            {
                var filename = pathIRepository + "\\" + folderName + "\\" + entityName + "Repository.cs";
                CreateFolderAndFileRepository(di, filename, folderName, "." + folderName, entityName);
            }
            else
            {
                var filename = pathIRepository + "\\" + entityName + "Repository.cs";
                CreateFolderAndFileRepository(di, filename, folderName, "", entityName);
            }
            

            UpdateCsproj(pathName, folderName, entityName, addFolder);
        }

        private static void UpdateCsproj(string pathName, string folderName, string entityName, bool addFolder)
        {
            var baseText = "<Compile Include=\"Identity\\AppRoleManager.cs\" />";          
            var repositoryText = " <Compile Include=\"Data\\Repositories{0}\\{1}Repository.cs\" />";

            if (addFolder)
            {
                repositoryText = String.Format(repositoryText, "\\"+folderName, entityName);
            }
            else
            {
                repositoryText = String.Format(repositoryText, "", entityName);
            }
            string text = File.ReadAllText(pathName + csprojFilePath);
            if (!text.Contains(repositoryText))
            {
                text = text.Replace(baseText, repositoryText + baseText);
                File.WriteAllText(pathName + csprojFilePath, text);
            }
        }

        private static void CreateFolderAndFileRepository(DirectoryInfo di, string filename, string folderName, string folder, string entity)
        {
            if (!di.Exists)
            {
                di.Create();
            }
            fi = new FileInfo(filename);
            using (StreamWriter sw = fi.AppendText())
            {
                string serviceTemplate = AppCoreTemplates.serviceTemplate.Replace("ReplaceIt", entity);
                var classTemplate = String.Format(InfrastructureTemplates.repositoryTemplate, folderName, folder, entity, entity, entity);
                sw.Write(classTemplate);
            }
            if (!fi.Exists)
            {
                fi.Create().Dispose();
            }
        }
    }
}
