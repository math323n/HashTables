using System;

namespace HashTables.Library
{
    public class HashTable<Key, Value>
    {
        // The load factor is a measure of how full the hash table 
        // is allowed to get before its capacity is automatically increased
        protected double LoadFactor = 0.8;
        protected double IncreaseSizeFactor = 0.8;
        protected double actualLoadFactor;
        protected int Elements;
        protected Value[] array;
        protected bool LoadFactorThresholdReached;

        // Constructor
        public HashTable(int initialSize)
        {
            array = new Value[initialSize];
        }

        // Add to HashTable
        public void Add(Key key, Value value)
        {

        }

        public Value LookUp(Key key)
        {
            return default;
        }

        private void CalculateLoadFactor()
        {
            double loadFactor = 0;
            foreach(Value value in array)
            {
                if(value != null)
                {
                    loadFactor++;
                }
            }
            actualLoadFactor = loadFactor;
        }

        private int Hash(Key key)
        {
            int hashCode = key.GetHashCode();
            int mask = 31 >> hashCode;
            hashCode ^= mask;
            hashCode -= mask;
            hashCode %= array.Length;
            return hashCode;
        }
    }
}