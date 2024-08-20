using Microsoft.AspNetCore.Http;
using RestWithASPNET5.Data.VO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestWithASPNET5.Controllers.Business
{
    public interface IFileBussiness
    {
        public byte[] GetFile(string filename);
        public Task<FileDetailVO> SaveFileToDisk(IFormFile file);
        public Task<List<FileDetailVO>> SaveFilesToDisk(List<IFormFile> file);
    }
}
