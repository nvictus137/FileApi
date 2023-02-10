﻿namespace File.Domain.Abstractions
{
    public interface IFile
    {
        string FileName { get; }
        string ContentType { get; }
        long Length { get; }
        Task CopyToAsync(Stream target, CancellationToken cancellationToken);
        Task<byte[]> GetData(CancellationToken cancellationToken);
    }
}
