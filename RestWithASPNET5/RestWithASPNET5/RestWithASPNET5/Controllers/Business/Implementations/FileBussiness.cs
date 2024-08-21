using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestWithASPNET5.Data.VO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNET5.Controllers.Business.Implementations
{
    public class FileBusiness : IFileBusiness
    {
        private readonly string _basePath;
        private readonly IHttpContextAccessor _context;
        private readonly string[] _allowedExtensions = { ".pdf", ".jpg", ".png", ".jpeg" };
        private readonly string _uploadDir = "\\UploadDir\\";
        private readonly string _apiUrlTemplate = "/api/file/v{0}/";

        public FileBusiness(IHttpContextAccessor context)
        {
            _context = context;
            _basePath = Directory.GetCurrentDirectory() + _uploadDir;
        }

        public byte[] GetFile(string filename)
        {
            throw new NotImplementedException();
        }

        public async Task<FileDetailVO> SaveFileToDisk(IFormFile file)
        {
            FileDetailVO fileDetail = new FileDetailVO();

            var fileType = Path.GetExtension(file.FileName);
            var baseUrl = _context.HttpContext.Request.Host;

            var apiVersion = _context.HttpContext.GetRequestedApiVersion()?.ToString() ?? "1";

            if (_allowedExtensions.Contains(fileType.ToLower()))
            {
                var docName = Path.GetFileName(file.FileName);
                if (file != null && file.Length > 0)
                {
                    var destination = Path.Combine(_basePath, "", docName);
                    fileDetail.DocumentName = docName;
                    fileDetail.DocType = fileType;
                    fileDetail.DocUrl = Path.Combine(baseUrl + string.Format(_apiUrlTemplate, apiVersion) + fileDetail.DocumentName);

                    using var stream = new FileStream(destination, FileMode.Create);
                    await file.CopyToAsync(stream);
                }
            }

            return fileDetail;
        }

        public Task<List<FileDetailVO>> SaveFilesToDisk(List<IFormFile> file)
        {
            throw new NotImplementedException();
        }

    }
}
