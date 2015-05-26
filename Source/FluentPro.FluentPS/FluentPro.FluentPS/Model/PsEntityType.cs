using FluentPro.FluentPS.Attributes;

namespace FluentPro.FluentPS.Model
{
    public enum PsEntityType
    {
        [Name("Project")]
        [PrimaryColumn("ProjectUID")]
        [Guid("CECFE271-6660-4ABE-97ED-208D3C71FC18")]
        Project,

        [Name("Resource")]
        [PrimaryColumn("ResourceUID")]
        [Guid("C8C72436-F730-4443-B82B-52341ABFF84C")]
        Resource,

        [Name("Task")]
        [PrimaryColumn("TaskUID")]
        [Guid("EBAD93E7-2149-410D-9A39-A8680738329D")]
        Task,

        [Name("Assignment")]
        [PrimaryColumn("AssignmentUID")]
        [Guid("BED1FDB9-6D08-4197-8BC2-9B6D6AA1D1CA")]
        Assignment,

        [Name("Timesheet")]
        [PrimaryColumn("")]
        [Guid("BCC4636C-A59F-42C5-9DA0-BF081B7CC2DC")]
        Timesheet,

        [Name("WssIssue")]
        [PrimaryColumn("IssueUniqueID")]
        [Guid("0A8CFF42-1150-40A5-8E7D-87B5FCCCFFDC")]
        WssIssue,

        [Name("WssDocument")]
        [PrimaryColumn("DocumentUniqueID")]
        [Guid("F6E689E1-D947-4B22-A173-9B2497F98D21")]
        WssDocument,

        [Name("WssDeliverable")]
        [PrimaryColumn("DeliverableUniqueID")]
        [Guid("928ED378-E15E-46B4-B40D-A857186F1A64")]
        WssDeliverable,

        [Name("WssRisk")]
        [PrimaryColumn("RiskUniqueID")]
        [Guid("2FFF147E-6AB2-4DA1-A1CB-CDB764020682")]
        WssRisk
    }
}
