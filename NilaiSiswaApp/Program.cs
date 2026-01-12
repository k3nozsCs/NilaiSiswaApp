int nilai;
string nama;

Console.WriteLine("Aplikasi Nilai Siswa");

Console.Write("Inout Nama Siswa : ");
nama = Console.ReadLine();

Console.Write("Input Nilai Siswa : ");
nilai = int.Parse(Console.ReadLine());

if (nilai >= 75)
    Console.WriteLine("Selamat Anda Lulus!");
else 
    Console.WriteLine("Maaf Anda Tidak Lulus!");
