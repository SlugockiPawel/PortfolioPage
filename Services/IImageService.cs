namespace Portfolio.Services;

public interface IImageService
{
    Task<byte[]> ConvertToByteArrayAsync(IFormFile file);
    string ConvertToFile(byte[] fileData, string extension);
}