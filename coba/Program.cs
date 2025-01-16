// See https://aka.ms/new-Console-template for more information

// Console.WriteLine("Hello, World!");


// int a = 2;
// int b = 3;

// Console.WriteLine(a+b);

// Console.WriteLine("Siapa namamu?");
// var nama = Console.ReadLine();
// var currentDate = DateTime.Now;
// Console.WriteLine($"{Environment.NewLine}Hi, {nama}, on {currentDate}");
// Console.Write($"{Environment.NewLine}Klik untuk keluar...");
// Console.Read();

// Console.WriteLine("NISN :");
// var nisn = Console.ReadLine();
// Console.WriteLine("Nama Siswa :");
// var nama_siswa = Console.ReadLine();
// Console.WriteLine($"{Environment.NewLine} NISN : {nisn}");
// Console.WriteLine($"{Environment.NewLine} Nama Siswa : {nama_siswa}");

Console.WriteLine("Masukkan 5 angka: ");
Console.WriteLine("Masukkan angka pertama: ");
var a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Masukkan angka kedua: ");
var b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Masukkan angka ketiga: ");
var c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Masukkan angka keempat: ");
var d = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Masukkan angka kelima: ");
var e = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"{Environment.NewLine} Angkanya adalah : {a} {b} {c} {d} {e}");
Console.WriteLine($"{Environment.NewLine} Jumlahnya adalah : {(a+b+c+d+e)}");
Console.WriteLine($"{Environment.NewLine} Rata-ratanya adalah : {(a+b+c+d+e)/5}");

