using N_m3u8DL_RE.Enum;

namespace N_m3u8DL_RE.Entity;

internal class LivePipeMuxOption
{
    public bool Enabled { get; set; }
    public string? Extension { get; set; }

    public LivePipeMuxOption(bool enabled, string? extension = null)
    {
        Enabled = enabled;
        Extension = extension;
    }
}
