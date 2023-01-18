namespace SketchToCodeService.Models
{
    public class ApiProject
    {
        public List<Controllers> Controllers { get; set; }
        //public List<ModelClass> ClassProperties { get; set; }
    }

    public class ModelClass
    {
        public IDictionary<object, object> MyProperty { get; set; }
    }

    public class Controllers
    {
        public string ControllerName { get; set; }
    }
}
