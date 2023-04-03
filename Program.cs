using System;
using System.Linq;

public class Program {
    static void Main(string[] args) {

        // Data Login
        string[] usernames = {"walas","Andi","Fina","Budi"};
        string[] passwords = {"12345","andi12345","fina12345","budi12345"};

        //Data Nilai Siswa
        string[,] andiData = new string[,] {
            {"Matematika", "75"},
            {"Fisika", "83"},
            {"Bahasa Ind", "80"},
            {"English", "92"},
            {"OOP", "82"}
        };
        string[,] finaData = new string[,] {
            {"Matematika", "77"},
            {"Fisika", "82"},
            {"Bahasa Ind", "91"},
            {"English", "95"},
            {"OOP", "88"}
        };
        string[,] budiData = new string[,] {
            {"Matematika", "89"},
            {"Fisika", "73"},
            {"Bahasa Ind", "90"},
            {"English", "79"},
            {"OOP", "78"}
        };

        // Inputan Username dan Password
        Console.WriteLine("----------Login----------");
        Console.WriteLine("Username: ");
        string usernameInput = Console.ReadLine();
        Console.WriteLine("Password: ");
        string passwordInput = Console.ReadLine();

        //Cek Password dan Username
        bool isValid = false;
        for (int i = 0; i < usernames.Length; i++)
        {
            if (usernameInput == usernames[i] && passwordInput == passwords[i])
            {
                isValid = true;
                break;
            }
        }

        //Menampilkan Hasil Validasi Data
        if(isValid) {
            Console.WriteLine("Selamat Anda Berhasil Login");
            Console.WriteLine();
            if (usernameInput == "walas") {
                Console.WriteLine("Selamat Datang Walas\n");
                Console.WriteLine("Berikut data nilai siswa anda\n");
                Console.WriteLine("Berikut data nilai siswa bernama Andi :");
                for (int i = 0; i < andiData.GetLength(0); i++)
                {
                    for (int j = 0; j < andiData.GetLength(1); j++)
                        {
                        Console.Write(andiData[i, j] + " ");
                        }
                        Console.WriteLine(); 
                }
                rata2(andiData, "Andi");

                Console.WriteLine();

                Console.WriteLine("Berikut data nilai siswa bernama Fina");
                for (int i = 0; i < finaData.GetLength(0); i++)
                {
                    for (int j = 0; j < finaData.GetLength(1); j++)
                        {
                        Console.Write(finaData[i, j] + " ");
                        }
                        Console.WriteLine(); 
                }
                rata2(finaData, "Fina");

                Console.WriteLine();

                Console.WriteLine("Berikut data nilai siswa bernama Budi");
                for (int i = 0; i < budiData.GetLength(0); i++)
                {
                    for (int j = 0; j < budiData.GetLength(1); j++)
                        {
                        Console.Write(budiData[i, j] + " ");
                        }
                        Console.WriteLine(); 
                }
                rata2(budiData, "Budi");

                bool ulang = true;

                while(ulang) {
                Console.WriteLine("---Sorting nilai murid berdasarkan rata rata---");
                Console.WriteLine("1.Ascending");
                Console.WriteLine("2.Descending");
                Console.WriteLine("3.Logout");
                Console.WriteLine("Silahkan masukan pilihan anda");
                Console.WriteLine();
                string input = Console.ReadLine();
                
                switch(input)
                {
                    case "1":
                        // Code for sorting in ascending order
                        var students = new[] { ("Andi", andiData), ("Fina", finaData), ("Budi", budiData) };
                        var averages = students.Select(s => (name: s.Item1, average: GetAverage(s.Item2))).ToList();
                        var sortedAverages = averages.OrderBy(a => a.average).ToList();

                        Console.WriteLine("Berikut Data Rata Rata Siswa Dari Terkecil:");
                        foreach (var average in sortedAverages)
                        {
                            Console.WriteLine($"{average.name} ({average.average})");
                        }
                        Console.WriteLine();

                        break;
                    case "2":
                        // Code for sorting in descending order
                        var students2 = new[] { ("Andi", andiData), ("Fina", finaData), ("Budi", budiData) };
                        var averages2 = students2.Select(s => (name: s.Item1, average: GetAverage(s.Item2))).ToList();
                        var sortedAverages2 = averages2.OrderByDescending(a => a.average).ToList();

                        Console.WriteLine("Berikut Data Rata Rata Siswa Dari Terbesar:");
                        foreach (var average in sortedAverages2)
                        {
                            Console.WriteLine($"{average.name} ({average.average})");
                        }
                        Console.WriteLine();

                        break;
                    case "3":
                        // Code for logout
                        Console.WriteLine("Logging out...(Harap Tekan Enter)");
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid");
                        break;
                }
                if (ulang) {
                    Console.WriteLine("Apakah Ingin Mengulang ?(y/t)");
                    string ulangInput = Console.ReadLine().ToLower();
                    if (ulangInput != "y") {
                        ulang = false;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Harap Tekan Enter");
                

            } else if (usernameInput == "Andi") {
                Console.WriteLine("Selamat Datang Andi\n");
                for (int i = 0; i < andiData.GetLength(0); i++)
                {
                    for (int j = 0; j < andiData.GetLength(1); j++)
                        {
                        Console.Write(andiData[i, j] + " ");
                        }
                        Console.WriteLine(); 
                }
                rata2(andiData, "Andi");
                (int andiMin, int andiMax) = GetMinMaxValues(andiData);
                Console.WriteLine("Nilai Andi: Minimal = {0},\nMaximal = {1}", andiMin, andiMax);
                Console.WriteLine("\nTekan Enter Untuk keluar ");

            } else if (usernameInput == "Fina") {
                Console.WriteLine("Selamat Datang Fina\n");
                for (int i = 0; i < finaData.GetLength(0); i++)
                {
                    for (int j = 0; j < finaData.GetLength(1); j++)
                        {
                        Console.Write(finaData[i, j] + " ");
                        }
                        Console.WriteLine(); 
                }
                rata2(finaData, "Fina");
                (int finaMin, int finaMax) = GetMinMaxValues(finaData);
                Console.WriteLine("Nilai Fina : Minimal = {0},\nMaximal = {1}", finaMin, finaMax);
                Console.WriteLine("\nTekan Enter Untuk keluar ");

            } else if (usernameInput == "Budi") {
                Console.WriteLine("Selamat Datang Budi\n");
                for (int i = 0; i < budiData.GetLength(0); i++)
                {
                    for (int j = 0; j < budiData.GetLength(1); j++)
                        {
                        Console.Write(budiData[i, j] + " ");
                        }
                        Console.WriteLine(); 
                }
                rata2(budiData, "Budi");
                (int budiMin, int budiMax) = GetMinMaxValues(budiData);
                Console.WriteLine("Nilai Budi: Minimal = {0},\nMaximal = {1}", budiMin, budiMax);
                Console.WriteLine("\nTekan Enter Untuk keluar ");
            }
        } else {
            Console.WriteLine("Password atau Username Tidak Valid");
        }
        
        Console.ReadKey();

    }

    static void rata2(string[,] data, string name) {
    double sum = 0;
    double rata = 0;
    for (int i = 0; i < data.GetLength(0); i++)
    {
        sum += double.Parse(data[i, 1]);
    }
    rata = sum / data.GetLength(0);

    Console.WriteLine($"Rata-rata nilai {name} adalah {rata}");
    }

    static (int, int) GetMinMaxValues(string[,] data) {
    int min = int.MaxValue;
    int max = int.MinValue;

    for (int i = 0; i < data.GetLength(0); i++) {
        int nilai = int.Parse(data[i, 1]);
        if (nilai < min) {
            min = nilai;
        }
        if (nilai > max) {
            max = nilai;
        }
    }

    return (min, max);
}

    static void Data(string[,] arr) {
        string[,] andiData = new string[,] {
            {"Matematika", "75"},
            {"Fisika", "83"},
            {"Bahasa Ind", "80"},
            {"English", "92"},
            {"OOP", "82"}
        };
        string[,] finaData = new string[,] {
            {"Matematika", "77"},
            {"Fisika", "82"},
            {"Bahasa Ind", "91"},
            {"English", "95"},
            {"OOP", "88"}
        };
        string[,] budiData = new string[,] {
            {"Matematika", "89"},
            {"Fisika", "73"},
            {"Bahasa Ind", "90"},
            {"English", "79"},
            {"OOP", "78"}
        };
    }
    static double GetAverage(string[,] data)
{
    var totalScore = 0.0;
    for (var i = 0; i < data.GetLength(0); i++)
    {
        var score = double.Parse(data[i, 1]);
        totalScore += score;
    }

    return totalScore / data.GetLength(0);
}

}

