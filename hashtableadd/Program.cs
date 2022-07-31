Console.WriteLine("Hash table demo"); //() []
MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
hash.Add("0", "To");
hash.Add("1", "be");
hash.Add("2", "or");
hash.Add("3", "not");
hash.Add("4", "to");
hash.Add("5", "be");


string hash1 = hash.Get("1");
string hash2 = hash.Get("2");
string hash3 = hash.Get("3");
string hash4 = hash.Get("4");
string hash5 = hash.Get("5");
Console.WriteLine("1st index value: " + hash1);
Console.WriteLine("2nd index value: " + hash2);
Console.WriteLine("3rd index value: " + hash3);
Console.WriteLine("4th index value: " + hash4);
Console.WriteLine("5th index value: " + hash5);
