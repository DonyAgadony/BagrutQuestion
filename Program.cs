
class TwoStacks(Stack<int> sums, Stack<int> numbers)
{
    public Stack<int> sums = sums;
    public Stack<int> numbers = numbers;

    public Stack<int> GetNums(int x)
    {
        Stack<int> rtn = new();
        int num = 0;
        do
        {
            num = sums.Pop();
        } while (x != num);
        int sumR = 0;
        Stack<int> ReversedNums = new(numbers);
        while (sumR != x)
        {
            sumR += ReversedNums.Pop();
        }
        return rtn;
    }

    public void CalculateSums()
    {
        Stack<int> reversedNums = new(numbers);
        int num = numbers.Pop();
        sums.Push(num);

    }
}
class Program
{
    public static void Main()
    {

    }
}