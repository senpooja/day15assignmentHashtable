Console.WriteLine("\\nHello World!"); //[3,7,9,11,55,67]
BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
binarySearch.Insert(30);
binarySearch.Insert(70);


binarySearch.Display();
binarySearch.GetSize();

Console.ReadKey();