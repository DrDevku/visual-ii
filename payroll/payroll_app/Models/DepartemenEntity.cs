using System.ComponentModel.DataAnnotations;
namespace payroll_app.Models;

public class DepartemenEntity() {
    // connect to database
    public int id{get; set;}
    public required string name{get; set;} //ada required krn di tabel tidak boleh kosong
    public required string address{get; set;}
}