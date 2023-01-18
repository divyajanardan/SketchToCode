using SketchToCodeService.Helper;

namespace SketchToCodeService.Models
{
    public class ProjectDetails
    {
        public string ProjectName { get; set; }
        public string ProjectType { get; set; }
        public ApiProject ApiProject { get; set; }

    }
}
