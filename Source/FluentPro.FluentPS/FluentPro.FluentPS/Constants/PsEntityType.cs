using FluentPro.FluentPS.Attributes;

namespace FluentPro.FluentPS.Constants
{
    public enum PsEntityType
    {
        [Name("Project")]
        [Guid("CECFE271-6660-4ABE-97ED-208D3C71FC18")]
        Project,


        [Name("Task")]
        [Guid("EBAD93E7-2149-410D-9A39-A8680738329D")]
        Task,

        [Name("Resource")]
        [Guid("C8C72436-F730-4443-B82B-52341ABFF84C")]
        Resource
    }
}
