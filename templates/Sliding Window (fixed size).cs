public static W SlidingWindowFixed(List<T> input, int windowSize) {
    W window = ans = input[0..windowSize];
    for (int right = windowSize; right < input.Count; ++right) {
        int left = right - windowSize;
        remove input[left] from window
        append input[right] to window
        ans = optimal(ans, window);
    }
    return ans;
}
