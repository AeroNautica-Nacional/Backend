using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroMexic.Application.BaseResponse
{
    public partial class Result<T>
    {
        public T Data { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; } = string.Empty; 
        public List<string> Errors { get; set; } = new List<string>();

        public Result<T> Success(T data) => new() { Data = data, IsSuccess = true };
        public Result<T> Failure(List<string> errors) => new() { Errors = errors, IsSuccess = false };
    }
}
