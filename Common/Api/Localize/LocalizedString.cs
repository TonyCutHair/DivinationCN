using Dalamud.Divination.Common.Api.Dalamud;
using Dalamud.Game;
using Dalamud.Game.Text.SeStringHandling;
using Dalamud.Game.Text.SeStringHandling.Payloads;

namespace Dalamud.Divination.Common.Api.Localize;

public sealed class LocalizedString
{
    public string En { get; init; } = string.Empty;
    public string? Ja { get; init; }
    public string? Ge { get; init; }
    public string? Fr { get; init; }
    public string? Zh { get; init; }
    public string? Ko { get; init; }

    public static implicit operator string(LocalizedString localizedString)
    {
        return localizedString.ToString();
    }

    public static implicit operator SeString(LocalizedString localizedString)
    {
        return localizedString.ToString();
    }

    public static implicit operator TextPayload(LocalizedString localizedString)
    {
        return new TextPayload(localizedString);
    }

    public override string ToString()
    {
        var api = ServiceContainer.Get<IDalamudApi>();
        var language = api?.ClientState.ClientLanguage;
        var languageName = language?.ToString();

        if (languageName is "ChineseSimplified" or "ChineseTraditional" or "Chinese" or "Chinese (Simplified)" or "Chinese (Traditional)" or "zh" or "zh-CN" or "zh-TW")
        {
            if (!string.IsNullOrWhiteSpace(Zh))
            {
                return Zh;
            }
        }

        if (languageName is "Korean" or "ko" or "ko-KR")
        {
            if (!string.IsNullOrWhiteSpace(Ko))
            {
                return Ko;
            }
        }

        switch (language)
        {
            case ClientLanguage.Japanese when !string.IsNullOrWhiteSpace(Ja):
                return Ja;
            case ClientLanguage.German when !string.IsNullOrWhiteSpace(Ge):
                return Ge;
            case ClientLanguage.French when !string.IsNullOrWhiteSpace(Fr):
                return Fr;
            default:
                return En;
        }
    }

    public string Format(object? arg0)
    {
        return string.Format(ToString(), arg0);
    }

    public string Format(object? arg0, object? arg1)
    {
        return string.Format(ToString(), arg0, arg1);
    }

    public string Format(object? arg0, object? arg1, object? arg2)
    {
        return string.Format(ToString(), arg0, arg1, arg2);
    }

    public string Format(params object?[] args)
    {
        return string.Format(ToString(), args);
    }
}
