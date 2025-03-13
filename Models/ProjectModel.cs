using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Models
{
    public class ProjectModel
    {
        public int Id { get; set; }
        public string ProjectName { get; set; } = string.Empty;
        public string PageName { get; set; } = string.Empty;
        public string Breakdown { get; set; } = string.Empty;
        public string Testname { get; set; } = string.Empty;
        public string AttributeEvaluateAggregrate { get; set; } = string.Empty;
    }
}
