using System.IO;
using System.Threading.Tasks;

namespace RECSClimate
{
    public interface IPhotoPickerService
    {
        Task<Stream> GetImageStreamAsync();
    }
}
