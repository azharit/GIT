namespace BizTalk_Server_Project2 {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BizTalk_Server_Project2.Schema111",@"Root")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Root"})]
    public sealed class Schema111 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BizTalk_Server_Project2.Schema111"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://BizTalk_Server_Project2.Schema111"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Root"">
    <xs:complexType />
  </xs:element>
</xs:schema>";
        
        public Schema111() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Root";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
