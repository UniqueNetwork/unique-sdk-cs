using Network.Unique.API.Model;

namespace Network.Unique.SDK.Service;

public interface IIPFSService
{

    IpfsUploadResponse UploadFile(Stream file);

    IpfsUploadResponse UploadFiles(List<Stream> files);

    IpfsUploadResponse AddFiles(List<Stream> files, string cid);

}