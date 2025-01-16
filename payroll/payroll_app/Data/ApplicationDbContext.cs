using Microsoft.EntityFrameworkCore;
using payroll_app.Models;
namespace payroll_app.Data;

using Microsoft.EntityFrameworkCore;
using payroll_app.Models;
// using Microsoft.AspNetCore.SignalR;

public class ApplicationDBContext:DbContext{
    public ApplicationDBContext (DbContextOptions<ApplicationDBContext> options) : base(options){

    }
    public DbSet<payroll_app.Models.DepartemenEntity> departemen{get; set;} = default!;
    public DbSet<payroll_app.Models.EmployeeEntity> employee{get; set;} = default!;
    // nama employee dipakai di controller
}