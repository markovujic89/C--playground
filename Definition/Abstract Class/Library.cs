namespace Definition.Abstract_Class
{
    public abstract class Library
    {
        private int _maxStorageSize;

        private string _name;

        public Library(int maxStorageSize, string name) 
        {
            _name = name;
            _maxStorageSize = maxStorageSize;
        }

        public abstract int MaxStorageSize { get; }

        public abstract string Name { get; }

        public abstract void PrintTitle(string name);

        public int GetMinStorageSize(int maxStorageSize) 
        {
            return _maxStorageSize/10;
        }
    }
}
