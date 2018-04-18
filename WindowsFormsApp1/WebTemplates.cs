using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class WebTemplates
    {
        public static string serviceTemplate =
            "container.Register<I{0}Service, {1}Service>(Lifestyle.Transient);";
        public static string repositoryTemplate =
            " container.RegisterSingleton<I{0}Repository>(new {1}Repository(new DatabaseContext()));";
    }
}
