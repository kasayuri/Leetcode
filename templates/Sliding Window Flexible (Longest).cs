public static W SlidingWindowFlexibleLongest(List<T> input) {
    initialize window, ans
    int left = 0;
    for (int right = 0; right < input.Count; ++right) {
        append input[right] to window
        while (invalid(window)) {
            remove input[left] from window
            ++left;
        }
        ans = Math.Max(ans, window);       // window is guaranteed to be valid here
    }
    return ans;
}
