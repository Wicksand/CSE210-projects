class LectureEvent : Event
{
    private string speaker_;
    private int capacity_;

    public LectureEvent() {}

    public LectureEvent(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address, "Lecture")
    {
        speaker_ = speaker;
        capacity_ = capacity;
    }
    public string fullOutdoor() {
        return Full($"   Speaker: {speaker_}\n   Capacity:{capacity_} attendees");
    }
}