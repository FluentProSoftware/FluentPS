namespace FluentPro.FluentPS.Psi.Model.Messages
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadPublishedNoteForTaskResponse", WrapperNamespace="http://schemas.microsoft.com/office/project/server/webservices/Statusing/", IsWrapped=true)]
    public partial class ReadPublishedNoteForTaskResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/Statusing/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] ReadPublishedNoteForTaskResult;
        
        public ReadPublishedNoteForTaskResponse()
        {
        }
        
        public ReadPublishedNoteForTaskResponse(byte[] ReadPublishedNoteForTaskResult)
        {
            this.ReadPublishedNoteForTaskResult = ReadPublishedNoteForTaskResult;
        }
    }
}