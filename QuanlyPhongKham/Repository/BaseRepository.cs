using Microsoft.Data.Sqlite;
using System.Configuration;
using System.Threading.Tasks;
using System;

public class BaseRepository : IDisposable
{
    public readonly string connection;
    private bool disposed;

    public BaseRepository(string connectionString = null)
    {
        this.connection = connectionString
            ?? ConfigurationManager.ConnectionStrings["DefaultConnection"]?.ConnectionString
            ?? throw new InvalidOperationException("Chuỗi kết nối 'DefaultConnection' chưa được cấu hình.");

        if (string.IsNullOrWhiteSpace(this.connection))
        {
            throw new InvalidOperationException("Chuỗi kết nối rỗng hoặc không hợp lệ.");
        }
    }

    protected async Task<SqliteConnection> GetConnectionAsync()
    {
        var connection = new SqliteConnection(this.connection);
        await connection.OpenAsync();
        return connection;
    }

    public void Dispose()
    {
        if (disposed) return;
        disposed = true;
    }
}