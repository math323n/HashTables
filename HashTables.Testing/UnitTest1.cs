using HashTables.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace HashTables.Testing
{
    [TestClass]
    public class HashTableTests
    {

        [TestMethod]
        public void TestCreation()
        {
            HashTable<int, string> hashTable = new(100);
        }

        [TestMethod]
        public void TestAddition()
        {
            HashTable<int, string> hashTable = new(100);
            hashTable.Add(10, "ds4");
        }
        

        [TestMethod]
        public void TestAdditionOnMaxLoad()
        {
            HashTable<string, int> hashTable = new(10);
            hashTable.Add("a", 1);
            hashTable.Add("ab", 2);
            hashTable.Add("abc", 3);
            hashTable.Add("abcd", 4);
            hashTable.Add("abhfge", 5);
            hashTable.Add("abcdef", 6);
            hashTable.Add("abcdefg", 7);
            hashTable.Add("abcghfggh", 8);
            hashTable.Add("abcdefghi", 9);
            hashTable.Add("abcdeffdsij", 10);
        }

        
    }
}