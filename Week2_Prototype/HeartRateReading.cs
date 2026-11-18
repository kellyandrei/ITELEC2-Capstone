class HeartRateReading
{
    private const int MinBpm = 30;
    private const int MaxBpm = 220;

    public string UserName { get; }
    public int BeatsPerMinute { get; private set; }
    public DateTime RecordedAt { get; }

    public HeartRateReading(string userName, int beatsPerMinute, DateTime recordedAt)
    {
        if (!IsInRange(beatsPerMinute))
            throw new ArgumentOutOfRangeException(nameof(beatsPerMinute),
                "Heart rate must be between 30 and 220 bpm.");

        UserName = userName;
        BeatsPerMinute = beatsPerMinute;
        RecordedAt = recordedAt;
    }

    // Returns false (and keeps the old value) if the new reading is out of range.
    public bool UpdateReading(int newBpm)
    {
        if (!IsInRange(newBpm)) return false;
        BeatsPerMinute = newBpm;
        return true;
    }

    public string GetZone()
    {
        if (BeatsPerMinute < 60) return "Low";
        if (BeatsPerMinute <= 100) return "Normal";
        return "High";
    }

    private static bool IsInRange(int bpm) => bpm >= MinBpm && bpm <= MaxBpm;
}
