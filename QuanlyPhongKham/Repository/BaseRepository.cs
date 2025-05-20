using System.Configuration;
using System.Threading.Tasks;
using System;
using System.Data.SQLite;


public class BaseRepository : IDisposable
{
    public readonly string connection;
    private bool disposed;

    public BaseRepository(string connectionString = null) // nếu không có chuỗi kết nối thì lấy từ cấu hình
    {
        this.connection = connectionString
            ?? ConfigurationManager.ConnectionStrings["DefaultConnection"]?.ConnectionString
            ?? throw new InvalidOperationException("Chuỗi kết nối 'DefaultConnection' chưa được cấu hình.");

        if (string.IsNullOrWhiteSpace(this.connection))
        {
            throw new InvalidOperationException("Chuỗi kết nối rỗng hoặc không hợp lệ.");
        }
    }
    protected SQLiteConnection GetConnection()
    {
        var conn = new SQLiteConnection(this.connection);
        conn.Open();
        return conn;
    }
    protected async Task<SQLiteConnection> GetConnectionAsync()
    {
        var connection = new SQLiteConnection(this.connection);
        await connection.OpenAsync();
        return connection;
    }

    public void Dispose()
    {
        if (disposed) return;
        disposed = true;
    }
}