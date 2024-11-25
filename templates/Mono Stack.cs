public static void MonoStack(List<int> insertEntries)
{
    Stack<int> stack;
    foreach (int entry in insertEntries)
    {
        while (stack.Count > 0 && stack.Peek() <= entry)
        {
            stack.Pop();
            // Do something with the popped item here
        }
        stack.Push(entry);
    }
}
