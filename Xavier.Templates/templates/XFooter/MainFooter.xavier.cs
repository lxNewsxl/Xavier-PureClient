using Xavier;
using Microsoft.Build.Logging;
using System.Security.Cryptography.X509Certificates;

namespace Xavier.PureClient
{
    public partial class MainFooter : Xavier.XavierNode
    {
        public string Title { get; set; } = "Xavier | A new frame";
        new public string Route {get;set;} = "''";
        public string Description { get; set; } = "How will we know when we've reached the stars?";
        new public bool ShouldRender { get; set; } = true;
        public XConfiguration Config { get; set; }
        public string item { get; set; } = "This is the item";

        public MainFooter(XavierNode xavierNode):base(xavierNode) {
            Config = new XConfiguration();
        }
        public MainFooter() { }
        public class XConfiguration
        {
            public string Id { get; set; }
            public string RestURI { get; set; }
            public string Name { get; set; }
            public string Request { get; set; }
            public string? Response { get; set; }
            
            public XConfiguration()
            {
                Id = Guid.NewGuid().ToString();
                Name = "Config";
                RestURI = "window.location + 'api/'";
                Request = "{'id': '556647'," +
                    "'dir':'dir'}";
                Response = null;


            }
        }
    }
}