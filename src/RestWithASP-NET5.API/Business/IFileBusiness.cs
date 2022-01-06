﻿using Microsoft.AspNetCore.Http;
using RestWithASP_NET5.API.Data.VO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestWithASP_NET5.API.Business
{
    public interface IFileBusiness
    {
        public byte[] GetFile(string filename);
        public Task<FileDetailVO> SaveFileToDisk(IFormFile file);
        public Task<List<FileDetailVO>> SaveFilesToDisk(IList<IFormFile> file);
    }
}
