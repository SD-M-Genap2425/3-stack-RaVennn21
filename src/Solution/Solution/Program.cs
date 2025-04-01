using Solution.BracketValidation;
using Solution.BrowserHistory;
using Solution.Palindrome;

namespace Solution;

internal class Program
{
    static void Main(string[] args)
    {
        // Browser history
        HistoryManager historyManager = new HistoryManager();

        historyManager.KunjungiHalaman("google.com");
        historyManager.KunjungiHalaman("example.com");

        Console.WriteLine($"Halaman saat ini: {historyManager.LihatHalamanSaatIni()}");
        Console.WriteLine($"Kembali ke halaman sebelumnya: {historyManager.Kembali()}");
        Console.WriteLine($"Halaman saat ini: {historyManager.LihatHalamanSaatIni()}");
        Console.WriteLine($"Tampilkan history:");


        // Bracket validator
        BracketValidator bracketValidator = new BracketValidator();

        string ekspresiValid = "[{}](){}";
        string ekspresiInvalid = "(]";

        Console.WriteLine($"Ekspresi '{ekspresiValid}' valid? {bracketValidator.ValidasiEkspresi(ekspresiValid)}");
        Console.WriteLine($"Ekspresi '{ekspresiInvalid}' valid? {bracketValidator.ValidasiEkspresi(ekspresiInvalid)}");



        //Palindrome Checker
        string inputPalindrome = "Kasur ini rusak";
        string inputNonPalindrome = "Hello World";

        Console.WriteLine($"Kalimat '{inputPalindrome}' palindrome? {PalindromeChecker.CekPalindrom(inputPalindrome)}");
        Console.WriteLine($"Kalimat '{inputNonPalindrome}' palindrome? {PalindromeChecker.CekPalindrom(inputNonPalindrome)}");






    }
}
