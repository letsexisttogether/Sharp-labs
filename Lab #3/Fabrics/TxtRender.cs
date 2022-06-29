using Model;

namespace Fabrics
{
    public class TxtRender : IFileRenderFabric
    {
        public IWriter GetWriter()
        {
            return new TxtWriter();
        }
        public IReader GetReader()
        {
            return new TxtReader();
        }
    }
}
