using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Templates
{
    public static class AppCoreTemplates
    {
      public static string iRepositoryTemplate =
            " //////{0};\r\n" +
            "namespace WebArchitecture.ApplicationCore.Interfaces.Repositories{1}\r\n" +
            "{{\r\n" +
            "    public interface I{2}Repository : IRepository<{3}>\r\n" +
            "    {{\r\n" +
            "    }}\r\n" +
            "}}\r\n";

        public static string iServiceTemplate = " //////{0};\r\n" +
            "namespace WebArchitecture.ApplicationCore.Interfaces.Services{1}\r\n" +
            "{{\r\n" +
            "    public interface I{2}Service : IService<{3}>\r\n" +
            "    {{\r\n" +
            "        void Update(ReplaceIt entity);\r\n" +
            "    }}\r\n" +
            "}}\r\n";

        public static string serviceTemplate = " //////{0};\r\n" +
            "namespace WebArchitecture.ApplicationCore.Services{1}\r\n" +
	        "{{\r\n" +
	        "    public class {2}Service : I{3}Service\r\n" +
	        "    {{\r\n" +
            "        private readonly IReplaceItRepository _repository;\r\n" +
            "        public ReplaceItService(IReplaceItRepository repository)\r\n" +
            "        {{\r\n" +
            "            _repository = repository;\r\n" +
            "        }}\r\n" +
            "        public void Add(ReplaceIt entity)\r\n" +
            "        {{\r\n" +
            "            _repository.Add(entity);\r\n" +
            "        }}\r\n" +
            "        public void AddRange(IEnumerable<ReplaceIt> entities)\r\n" +
            "        {{\r\n" +
            "            _repository.AddRange(entities);\r\n" +
            "        }}\r\n" +
	        "        public void DeleteById(object id)\r\n" +
            "        {{\r\n" +
            "            _repository.DeleteById(id);\r\n" +
            "        }}\r\n" +
            "        public IEnumerable<ReplaceIt> Find(Expression<Func<ReplaceIt, bool>> predicate)\r\n" +
            "        {{\r\n" +
            "            return _repository.Find(predicate);\r\n" +
            "        }}\r\n" +
            "        public ReplaceIt Get(string id)\r\n" +
            "        {{\r\n" +
            "            return _repository.Get(id);\r\n" +
            "        }}\r\n" +
            "        public ReplaceIt Get(int id)\r\n" +
            "        {{\r\n" +
            "            return _repository.Get(id);\r\n" +
            "        }}\r\n" +
            "        public IEnumerable<ReplaceIt> GetAll()\r\n" +
            "        {{\r\n" +
            "            return _repository.GetAll();\r\n" +
            "        }}\r\n" +
            "        public void Remove(ReplaceIt entity)\r\n" +
            "        {{\r\n" +
            "            _repository.Remove(entity);\r\n" +
            "        }}\r\n" +
            "        public void RemoveRange(IEnumerable<ReplaceIt> entities)\r\n" +
            "        {{\r\n" +
            "            _repository.RemoveRange(entities);\r\n" +
            "        }}\r\n" +
            "        public ReplaceIt SingleOrDefault(Expression<Func<ReplaceIt, bool>> predicate)\r\n" +
            "        {{\r\n" +
            "            return _repository.SingleOrDefault(predicate);\r\n" +
            "        }}\r\n" +
            "        public void Update(ReplaceIt entity)\r\n" +
            "        {{\r\n" +
            "            _repository.Update(entity);\r\n" +
	        "        }}\r\n" +
            "    }}\r\n" +
            "}}\r\n";

    }
}
