public class Node {
    char value;
    Dictionary<char, Node> children = new Dictionary<char, Node>();

    public Node(char value) {
        this.value = value;
    }

    public void insert(string s, int idx) {   
        if (idx == s.Length) return;
        else if (children.ContainsKey(s[idx]))
        {
            children[s[idx]].insert(s, idx + 1);
        }
        else
        {
            children[s[idx]] = new Node(s[idx]);
            children[s[idx]].insert(s, idx + 1);
        }
    }
}
