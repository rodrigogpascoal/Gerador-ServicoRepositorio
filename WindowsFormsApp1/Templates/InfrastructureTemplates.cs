using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Templates
{
    public static class InfrastructureTemplates
    {
        public static string repositoryTemplate = " //////{0};\r\n" +
        "namespace WebArchitecture.Infrastructure.Data.Repositories.{1}\r\n" +
        "{{\r\n" +
        "    public class {2}Repository : Repository<{3}>, I{4}Repository\r\n" +
        "    {{\r\n" +
        "        public ReplaceItRepository(DbContext context) : base(context)\r\n" +
        "        {{\r\n" +
        "        }}\r\n" +
        "        public void Update(ReplaceIt entity)\r\n" +
        "        {{\r\n" +
        "            if (entity.Id != 0)\r\n" +
        "            {{\r\n" +
        "                ReplaceIt updatedEntity = Context.Set<ReplaceIt>().Where(p => p.Id == entity.Id).FirstOrDefault();\r\n" +
        "                if (updatedEntity != null)\r\n" +
        "                {{\r\n" +
        "                    Context.Entry(updatedEntity).CurrentValues.SetValues(entity);\r\n" +
        "                }}\r\n" +
        "            }}\r\n" +
        "            Context.SaveChanges();\r\n" +
        "        }}\r\n" +
        "    }}\r\n" +
        "}}\r\n";
    }
}

