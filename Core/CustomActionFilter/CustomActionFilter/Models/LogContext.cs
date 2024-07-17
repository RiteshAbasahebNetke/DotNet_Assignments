using Microsoft.EntityFrameworkCore;

namespace CustomActionFilter.Models
{
    public class LogContext:DbContext
    {
        public LogContext(DbContextOptions<LogContext> opt) : base(opt) { }
        public DbSet<ActionLog> ActionLogs { get; set; }
    }
}
