namespace SketchToCodeService.Models
{
    public class ApiController
    {
        public string ProjectName { get; set; }
        public string ControllerName { get; set; }
    }

    public class ApiModelClass
    {
        public string ProjectName { get; set; }
        public string ClassName { get; set; }
        public IDictionary<string, string> ClassProperty { get; set; }
    }
}
