using Microsoft.AspNetCore.Http;
using RestWithASP_NET5.API.Data.VO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestWithASP_NET5.API.Business.Implementations
{
    public class FileBusinessImplementation : IFileBusiness
    {
        public byte[] GetFile(string filename)
        {
            throw new NotImplementedException();
        }

        public Task<List<FileDetailVO>> SaveFilesToDisk(IList<IFormFile> file)
        {
            throw new NotImplementedException();
        }

        public Task<FileDetailVO> SaveFileToDisk(IFormFile file)
        {
            throw new NotImplementedException();
        }
    }
}
