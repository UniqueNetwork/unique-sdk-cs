using Network.Unique.API.Api;
using Network.Unique.API.Model;

namespace Network.Unique.SDK.Service.Impl;

public class IPFSServiceImpl : IIPFSService
{
    
    private IpfsApi _api;

    public IPFSServiceImpl(String basePath)
    {
        this._api = new IpfsApi(basePath);
    }
    
    public IpfsUploadResponse UploadFile(Stream file)
    {
        return _api.IpfsControllerUploadFile(file);
    }

    public IpfsUploadResponse UploadFiles(List<Stream> files)
    {
        return _api.IpfsControllerUploadFiles(files);
    }

    public IpfsUploadResponse AddFiles(List<Stream> files, string cid)
    {
        return _api.IpfsControllerAddFiles(files, cid);
    }
}