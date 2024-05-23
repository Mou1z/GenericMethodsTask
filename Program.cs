namespace GenericMethodsTask
{
    internal class Program
    {
        public static int[] ReverseArray(int[] array)
        {
            int[] reversedArray = new int[array.Length];
            int lastIndex = array.Length - 1;
            for (int i = 0; i < array.Length; i++)
                reversedArray[i] = array[lastIndex - i];
            return reversedArray;
        }

        static void Main(string[] args)
        {
            int[] example = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Original Array:");
            foreach (var i in example)
                Console.Write(i + " ");

            Console.WriteLine("");

            example = ReverseArray(example);
            Console.WriteLine("Reversed Array:");
            foreach (var i in example)
                Console.Write(i + " ");

            Console.WriteLine("");

            string[] strExample = new string[] { "a", "b", "c", "d", "e" };
            Console.WriteLine("Original Array:");
            foreach (var i in strExample)
                Console.Write(i + " ");

            Console.WriteLine("");

            strExample = ReverseArray(strExample);
            Console.WriteLine("Reversed Array:");
            foreach (var i in strExample)
                Console.Write(i + " ");
        }
    }
}