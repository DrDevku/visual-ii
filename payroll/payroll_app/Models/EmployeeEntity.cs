using System.ComponentModel.DataAnnotations;
using System.Configuration;
namespace payroll_app.Models;

public class EmployeeEntity() {
    // connect to database
    [Key]
    public required int id{get; set;}
    public required string name{get; set;}
    public required string address{get; set;}
    public required DateOnly dateofhire{get; set;}
    public int department{get; set;}
    public int jobtitle{get; set;}
    public required string contactinfo{get; set;}

}