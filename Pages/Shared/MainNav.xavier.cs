using Xavier;
using System.Text.Json;

namespace Xavier.PureClient
{
    public partial class MainNav : Xavier.XavierNode
    {

        public string? Title { get; set; } = "This is the title";
        new public bool ShouldRender { get; set; } = true;
        new public string? Route { get; set; } = null;
        public string? JSON { get; set; } = "This is a description";

        public List<Product> Products { get; set;} = new List<Product>();

        public class Product
        {
            public string Id{get;set;} = "";
            public string Name{get;set;}= "";
            public string Cost{get;set;} = "$50";

            public Product(string id, string name, string cost){
                Id = id;
                Name = name;
                Cost = cost;
            }
        }

        public MainNav(XavierNode xavierNode):base(xavierNode) {
             Task.WaitAll(Task.Run(()=>AddProducts())
           );
        
        }
        public MainNav() { }

        void AddProducts(){
            string[] names = new[]{"Apple","Orange","Banana","Strawberry"};
            foreach(var s in names){
                var guid = Guid.NewGuid().ToString();
                Product p = new Product(guid,s,"0.55");
                Products.Add(p);
            }
        }
    }
}