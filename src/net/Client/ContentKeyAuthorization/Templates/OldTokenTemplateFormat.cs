﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.17929.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
internal partial class TokenRestriction {
    
    private TokenRestrictionVerificationKey[] verificationKeysField;
    
    private TokenRestrictionClaim[] requiredClaimsField;
    
    private string issuerField;
    
    private string audienceField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("VerificationKey", IsNullable=false)]
    public TokenRestrictionVerificationKey[] VerificationKeys {
        get {
            return this.verificationKeysField;
        }
        set {
            this.verificationKeysField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Claim", IsNullable=false)]
    public TokenRestrictionClaim[] RequiredClaims {
        get {
            return this.requiredClaimsField;
        }
        set {
            this.requiredClaimsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public string issuer {
        get {
            return this.issuerField;
        }
        set {
            this.issuerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public string audience {
        get {
            return this.audienceField;
        }
        set {
            this.audienceField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
internal partial class TokenRestrictionVerificationKey {
    
    private VerificationKeyType typeField;
    
    private byte[] valueField;
    
    private bool isPrimaryField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public VerificationKeyType type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="base64Binary")]
    public byte[] value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool IsPrimary {
        get {
            return this.isPrimaryField;
        }
        set {
            this.isPrimaryField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
internal enum VerificationKeyType {
    
    /// <remarks/>
    Symmetric,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
internal partial class TokenRestrictionClaim {
    
    private string typeField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public string type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}
