using Model;

namespace Fabrics
{
    public interface IFileRenderFabric
    {
        IWriter GetWriter();

        IReader GetReader();
    }
}
