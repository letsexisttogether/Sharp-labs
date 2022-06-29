using Model;

namespace Fabrics
{
    public class XmlRender : IFileRenderFabric
    {
        public IWriter GetWriter()
        {
            return new XMLWriter();
        }
        public IReader GetReader()
        {
            return new XmlReader();
        }
    }
}
