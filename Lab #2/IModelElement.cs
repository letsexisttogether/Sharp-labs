using System.Collections.Generic;

namespace MainModel
{
    public interface IModelElement
    {
        Dictionary<string, string> GetProperties();
    }
}
