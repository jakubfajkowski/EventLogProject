public class BoxItem<T> {
    public string text { get; set; }
    public T value { get; set; }

    public override string ToString() {
        return text;
    }
}