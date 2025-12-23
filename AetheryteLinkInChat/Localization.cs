using Dalamud.Divination.Common.Api.Localize;

namespace Divination.AetheryteLinkInChat;

public static class Localization
{
    public static readonly LocalizedString TeleportingMessage = new()
    {
        En = "Teleporting to \"{0}\"...",
        Ja = "「{0}」にテレポしています...",
        Zh = "正在传送到“{0}”...",
    };

    public static readonly LocalizedString TeleportingQuestMessage = new()
    {
        En = "Teleport to \"{0}\"",
        Ja = "「{0}」にテレポ",
        Zh = "传送到“{0}”",
    };

    public static readonly LocalizedString QueueTeleportMessage = new()
    {
        En = "Currently unable to execute teleport. Teleport to \"{0}\" has been added to the queue.",
        Ja = "現在テレポを実行できません。「{0}」へのテレポをキューに追加しました。",
        Zh = "当前无法执行传送。已将前往“{0}”的传送加入队列。",
    };

    public static readonly LocalizedString QueuedTeleportingMessage = new()
    {
        En = "Teleporting to \"{0}\" (queued) ...",
        Ja = "キューに追加された「{0}」にテレポしています...",
        Zh = "正在传送到“{0}”（排队）...",
    };

    public static readonly LocalizedString QueuedTeleportingQuestMessage = new()
    {
        En = "Teleport to \"{0}\" (queued)",
        Ja = "キューに追加された「{0}」にテレポ",
        Zh = "传送到“{0}”（排队）",
    };

    public static readonly LocalizedString ConfigWindowTitle = new()
    {
        En = "{0} Config",
        Ja = "{0} 設定",
        Zh = "{0} 配置",
    };

    public static readonly LocalizedString AllowTeleportQueueing = new()
    {
        En = "Allow Teleport Queueing",
        Ja = "テレポを予約可能にする",
        Zh = "允许排队传送",
    };

    public static readonly LocalizedString QueueTeleportDelay = new()
    {
        En = "Queued Teleport Delay (ms)",
        Ja = "予約したテレポを実行するまでの遅延 (ms)",
        Zh = "排队传送延迟（毫秒）",
    };

    public static readonly LocalizedString QueuedTeleportDescription = new()
    {
        En =
            "It can queue a teleportation when it is not possible to execute a teleportation, e.g. you are in combat.\nAfter teleporting becomes possible, the teleportation is executed after the delay set here.\nThis is necessary to prove that you are not cheating!",
        Ja = "戦闘中などでテレポが実行できないときはテレポをキューに追加します。\nテレポが可能になったあと、ここで設定された遅延を挟んでからテレポを実行します。\nこれはあなたが不正行為を行っていないと証明するために必要です！",
        Zh = "无法立即传送时（如战斗中）会先加入队列。\n传送可行后，会在此处设定的延迟后执行。\n这有助于证明你没有作弊！",
    };

    public static readonly LocalizedString ConsiderTeleportsToOtherWorlds = new()
    {
        En = "Consider Teleportation to Other Worlds in Route Calculation",
        Ja = "他ワールドへのテレポを経路計算に考慮する",
        Zh = "在路径计算中考虑跨世界传送",
    };

    public static readonly LocalizedString ConsiderTeleportsToOtherWorldsDescription = new()
    {
        En =
            "When enabled, the Grand Company Aetheryte will be prepended to the best path\nif a destination world is different from the player's current world.",
        Ja = "有効にすると、目的地のワールドがプレイヤーの現在のワールドと異なる場合に、\n三国エーテライトを最短経路の先頭に付加します。",
        Zh = "启用后，当目的地与当前世界不同，会在最佳路径前加入主城以太之光。",
    };

    public static readonly LocalizedString ConsiderTeleportsToOtherWorldsDisclaimer = new()
    {
        En = "This function simply detects the world name from the chat message.\nAs such, it may cause malfunctions.",
        Ja = "この機能は、単にワールド名をチャットメッセージから検出しているだけです。\nそのため、誤作動を起こす場合もあります。",
        Zh = "此功能仅从聊天消息中读取世界名，可能会有误判。",
    };

    public static readonly LocalizedString PreferredGrandCompanyAetheryte = new()
    {
        En = "Preferred Grand Company Aetheryte",
        Ja = "優先する三国エーテライト",
        Zh = "首选主城以太之光",
    };

    public static readonly LocalizedString PreferredGrandCompanyAetheryteDescription = new()
    {
        En = "You can select the preferred Grand Company Aetheryte\nto use for teleporting to other worlds, for example.",
        Ja = "別ワールドにテレポするときなどに使用する、\n優先する三国エーテライトを選択できます。",
        Zh = "可以选择跨世界传送时优先使用的主城以太之光。",
    };

    public static readonly LocalizedString SaveConfigButton = new()
    {
        En = "Save & Close",
        Ja = "保存して閉じる",
        Zh = "保存并关闭",
    };

    public static readonly LocalizedString TeleportGcHelpMessage = new()
    {
        En = "Teleports you to Grand Company Aetheryte. Useful for teleporting to other worlds. The aetheryte can be changed from plugin config.",
        Ja = "三国のエーテライトにテレポします。ワールド間テレポに便利です。優先する三国エーテライトは設定から変更できます。",
        Zh = "传送到主城以太之光，方便跨世界传送。可在插件设置中更换优先的以太之光。",
    };

    public static readonly LocalizedString EnableLifestreamIntegration = new()
    {
        En = "Enable Lifestream Integration",
        Ja = "Lifestream との連携機能を有効にする",
        Zh = "启用 Lifestream 联动",
    };

    public static readonly LocalizedString EnableLifestreamIntegrationDescription = new()
    {
        En = "If enabled, teleporting to destinations will be automated, including world traveling and aethernet transfers.\nLifestream plugin required!",
        Ja = "有効にすると、ワールド間テレポや都市内エーテライトの移動を含め、目的地へのテレポが自動化されます。\nこの機能を使用するには、Lifestream プラグインが必要です！",
        Zh = "启用后，将自动完成前往目的地的传送，包括跨世界与都市内以太之光移动。\n需要安装 Lifestream 插件！",
    };

    public static readonly LocalizedString LifestreamUnavailable = new()
    {
        En = "Lifestream plugin is not available. Please install it.",
        Ja = "Lifestream がインストールされていません。",
        Zh = "未找到 Lifestream 插件，请先安装。",
    };

    public static readonly LocalizedString DisplayLineBreak = new()
    {
        En = "Line break before teleport links",
        Ja = "テレポリンクの前に改行を入れる",
        Zh = "在传送链接前换行",
    };

    public static readonly LocalizedString DisplayLinkAtEnd = new()
    {
        En = "Display teleport link at the end of the message",
        Ja = "メッセージの最後にテレポート リンクを表示する",
        Zh = "在消息末尾显示传送链接",
    };

    public static readonly LocalizedString EnableChatNotificationOnTeleport = new()
    {
        En = "Enable Chat Notification on Teleport",
        Ja = "テレポ実行時にチャット通知を有効にする",
        Zh = "传送时启用聊天通知",
    };

    public static readonly LocalizedString EnableQuestNotificationOnTeleport = new()
    {
        En = "Enable Toast Notification on Teleport",
        Ja = "テレポ実行時にトースト通知を有効にする",
        Zh = "传送时启用弹窗通知",
    };

    public static readonly LocalizedString IgnoredAetherytes = new()
    {
        En = "You can set a specific aetherite not to be used in route calculations.",
        Ja = "特定のエーテライトを経路計算で使用しないように設定できます。",
        Zh = "可以将特定以太之光排除在路径计算之外。",
    };

    public static readonly LocalizedString GeneralTab = new()
    {
        En = "General",
        Ja = "全般",
        Zh = "常规",
    };

    public static readonly LocalizedString AetheryteListTab = new()
    {
        En = "Aetheryte List",
        Ja = "エーテライト一覧",
        Zh = "以太之光列表",
    };

    public static readonly LocalizedString TableColumnId = new()
    {
        En = "ID",
        Ja = "ID",
        Zh = "ID",
    };

    public static readonly LocalizedString TableColumnName = new()
    {
        En = "Name",
        Ja = "名前",
        Zh = "名称",
    };

    public static readonly LocalizedString IgnoreButton = new()
    {
        En = "Ignore",
        Ja = "無視",
        Zh = "忽略",
    };

    public static readonly LocalizedString UnignoreButton = new()
    {
        En = "Unignore",
        Ja = "無視解除",
        Zh = "取消忽略",
    };
}
