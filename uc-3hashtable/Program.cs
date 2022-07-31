// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Hash table demo"); //() []
MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
hash.Add("0", "Paranoid");
hash.Add("1", "are");
hash.Add("2", "not");
hash.Add("3", "paranoid");
hash.Add("4", "becouse");
hash.Add("5", "they");
hash.Add("6", "are");
hash.Add("7", "putting");
hash.Add("8", "themselves");
hash.Add("9", "deliberately");
hash.Add("10", "into");
hash.Add("11", "pranoid");
hash.Add("12", "avoidable");
hash.Add("13", "situations");


hash.Remove("12", "avoidable");
//hash.Remove("12");


string hash0 = hash.Get("0");
string hash1 = hash.Get("1");
string hash12 = hash.Get("12");
//string hash2 = hash.Get("2");
//string hash3 = hash.Get("3");
//string hash4 = hash.Get("4");
//string hash5 = hash.Get("5");
