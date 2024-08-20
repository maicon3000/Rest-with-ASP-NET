using Microsoft.AspNetCore.Http;
using RestWithASPNET5.Data.VO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNET5.Controllers.Business.Implementations
{
    public class FileBussiness : IFileBussiness
    {
        private readonly string _basePath;
        private readonly IHttpContextAccessor _context;

        public FileBussiness(IHttpContextAccessor context )
        {
            _context = context;
            _basePath = Directory.GetCurrentDirectory() + "\\UploadDir\\";
        }

        public byte[] GetFile(string filename)
        {
            throw new NotImplementedException();
        }

        public Task<List<FileDetailVO>> SaveFilesToDisk(List<IFormFile> file)
        {
            throw new NotImplementedException();
        }

        public Task<FileDetailVO> SaveFileToDisk(IFormFile file)
        {
            throw new NotImplementedException();
        }
    }
}
