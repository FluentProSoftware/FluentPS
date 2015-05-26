﻿namespace FluentPro.FluentPS.Model
{
    public enum PsConversionType
    {
        Invalid = 0,
        Uid = 1,
        Priority = 2,
        ConstraintType = 3,
        Date = 4, // Used in custom fields struct
        Percent = 5,
        Duration = 6, // Used in custom fields struct
        DurationOffset = 7,
        Work = 8,
        Cost = 9, // Used in custom fields struct
        WorkRate = 10,
        CostRate = 11,
        Units = 12,
        Accrual = 13,
        ContourType = 14,
        Number = 15, // Used in custom fields struct
        Bool = 16,
        YesNo = 17, // Used in custom fields struct
        Double = 18,
        Word = 20,
        String = 21, // Used in custom fields struct
        TimeLabel = 22,
        Time = 23,
        Long = 24,
        Link = 25,
        Rtf = 26,
        FinishDate = 27, // Used in custom fields struct
        ElapsedDuration = 28,
        TaskType = 29,
        HyperlinkFriendlyName = 30,
        HyperlinkTarget = 31,
        HyperlinkLocation = 32,
        HyperlinkHRef = 33,
        Gpi = 34,
        Moniker = 35,
        Indicator = 36,
        ExternalId = 37,
        BlankExternalId = 38,
        WorkgroupUser = 39,
        RateTable = 40,
        R8Pct = 41,
        Guid = 42,
        ResourceType = 43,
        SimpleRate = 44,
        MaterialWork = 45,
        TsMaterialWork = 45,
        HyperlinkScreenTip = 46,
        ProjectType = 47,
        StatusUpdateType = 48,
        Enum3 = 49,
        PsStrings = 50,
        TaskStatus = 51,
        Demreq = 52,
        Evmeth = 53,
        BookingType = 54,
        Multicurrency = 55,
        StartDate = 57,
        TaskMode = 58,
        WorflowStageStatus = 59,
        CommittedDecisionResult = 60,
        CostRateTable = 61,
        PercentWithDecimals = 62,
        CoreResourceType = 63,
    }
}
