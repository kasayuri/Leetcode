public static W SlidingWindowFlexibleShortest(List<T> input) {
    initialize window, ans
    int left = 0;
    for (int right = 0; right < input.Count; ++right) {
        append input[right] to window
        while (valid(window)) {
            ans = Math.Min(ans, window);   // window is guaranteed to be valid here
            remove input[left] from window
            ++left;
        }
    }
    return ans;
}
