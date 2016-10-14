using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELFOR_Parser
{
    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.intentia.com/Schemas/mec", IsNullable = false)]
    public partial class Envelope
    {

        private EnvelopeHeader headerField;

        private EnvelopeBody bodyField;

        /// <remarks/>
        public EnvelopeHeader Header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }

        /// <remarks/>
        public EnvelopeBody Body
        {
            get
            {
                return this.bodyField;
            }
            set
            {
                this.bodyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeHeader
    {

        private delivery deliveryField;

        private properties propertiesField;

        private manifest manifestField;

        private process processField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.intentia.com/MBM_Envelope_1")]
        public delivery delivery
        {
            get
            {
                return this.deliveryField;
            }
            set
            {
                this.deliveryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.intentia.com/MBM_Envelope_1")]
        public properties properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.intentia.com/MBM_Envelope_1")]
        public manifest manifest
        {
            get
            {
                return this.manifestField;
            }
            set
            {
                this.manifestField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.intentia.com/MBM_Envelope_1")]
        public process process
        {
            get
            {
                return this.processField;
            }
            set
            {
                this.processField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/MBM_Envelope_1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.intentia.com/MBM_Envelope_1", IsNullable = false)]
    public partial class delivery
    {

        private deliveryTO toField;

        private deliveryFrom fromField;

        /// <remarks/>
        public deliveryTO to
        {
            get
            {
                return this.toField;
            }
            set
            {
                this.toField = value;
            }
        }

        /// <remarks/>
        public deliveryFrom from
        {
            get
            {
                return this.fromField;
            }
            set
            {
                this.fromField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/MBM_Envelope_1")]
    public partial class deliveryTO
    {

        private string addressField;

        /// <remarks/>
        public string address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/MBM_Envelope_1")]
    public partial class deliveryFrom
    {

        private string addressField;

        /// <remarks/>
        public string address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/MBM_Envelope_1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.intentia.com/MBM_Envelope_1", IsNullable = false)]
    public partial class properties
    {

        private object identityField;

        private System.DateTime sentAtField;

        private object expiresAtField;

        private object topicField;

        /// <remarks/>
        public object identity
        {
            get
            {
                return this.identityField;
            }
            set
            {
                this.identityField = value;
            }
        }

        /// <remarks/>
        public System.DateTime sentAt
        {
            get
            {
                return this.sentAtField;
            }
            set
            {
                this.sentAtField = value;
            }
        }

        /// <remarks/>
        public object expiresAt
        {
            get
            {
                return this.expiresAtField;
            }
            set
            {
                this.expiresAtField = value;
            }
        }

        /// <remarks/>
        public object topic
        {
            get
            {
                return this.topicField;
            }
            set
            {
                this.topicField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/MBM_Envelope_1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.intentia.com/MBM_Envelope_1", IsNullable = false)]
    public partial class manifest
    {

        private manifestReference referenceField;

        /// <remarks/>
        public manifestReference reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/MBM_Envelope_1")]
    public partial class manifestReference
    {

        private string uriField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string uri
        {
            get
            {
                return this.uriField;
            }
            set
            {
                this.uriField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/MBM_Envelope_1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.intentia.com/MBM_Envelope_1", IsNullable = false)]
    public partial class process
    {

        private object typeField;

        private object instanceField;

        /// <remarks/>
        public object type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public object instance
        {
            get
            {
                return this.instanceField;
            }
            set
            {
                this.instanceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBody
    {

        private EnvelopeBodyDELFOR dELFORField;

        /// <remarks/>
        public EnvelopeBodyDELFOR DELFOR
        {
            get
            {
                return this.dELFORField;
            }
            set
            {
                this.dELFORField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFOR
    {

        private EnvelopeBodyDELFORUNB uNBField;

        private EnvelopeBodyDELFORUNH uNHField;

        private EnvelopeBodyDELFORBGM bGMField;

        private EnvelopeBodyDELFORDTM[] dTMField;

        private EnvelopeBodyDELFORG001 g001Field;

        private EnvelopeBodyDELFORG002[] g002Field;

        private EnvelopeBodyDELFORUNS uNSField;

        private EnvelopeBodyDELFORG004 g004Field;

        private EnvelopeBodyDELFORUNS_2 uNS_2Field;

        private EnvelopeBodyDELFORUNT uNTField;

        private EnvelopeBodyDELFORUNZ uNZField;

        /// <remarks/>
        public EnvelopeBodyDELFORUNB UNB
        {
            get
            {
                return this.uNBField;
            }
            set
            {
                this.uNBField = value;
            }
        }

        /// <remarks/>
        public EnvelopeBodyDELFORUNH UNH
        {
            get
            {
                return this.uNHField;
            }
            set
            {
                this.uNHField = value;
            }
        }

        /// <remarks/>
        public EnvelopeBodyDELFORBGM BGM
        {
            get
            {
                return this.bGMField;
            }
            set
            {
                this.bGMField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DTM")]
        public EnvelopeBodyDELFORDTM[] DTM
        {
            get
            {
                return this.dTMField;
            }
            set
            {
                this.dTMField = value;
            }
        }

        /// <remarks/>
        public EnvelopeBodyDELFORG001 g001
        {
            get
            {
                return this.g001Field;
            }
            set
            {
                this.g001Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("g002")]
        public EnvelopeBodyDELFORG002[] g002
        {
            get
            {
                return this.g002Field;
            }
            set
            {
                this.g002Field = value;
            }
        }

        /// <remarks/>
        public EnvelopeBodyDELFORUNS UNS
        {
            get
            {
                return this.uNSField;
            }
            set
            {
                this.uNSField = value;
            }
        }

        /// <remarks/>
        public EnvelopeBodyDELFORG004 g004
        {
            get
            {
                return this.g004Field;
            }
            set
            {
                this.g004Field = value;
            }
        }

        /// <remarks/>
        public EnvelopeBodyDELFORUNS_2 UNS_2
        {
            get
            {
                return this.uNS_2Field;
            }
            set
            {
                this.uNS_2Field = value;
            }
        }

        /// <remarks/>
        public EnvelopeBodyDELFORUNT UNT
        {
            get
            {
                return this.uNTField;
            }
            set
            {
                this.uNTField = value;
            }
        }

        /// <remarks/>
        public EnvelopeBodyDELFORUNZ UNZ
        {
            get
            {
                return this.uNZField;
            }
            set
            {
                this.uNZField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORUNB
    {

        private EnvelopeBodyDELFORUNBCmp01 cmp01Field;

        private EnvelopeBodyDELFORUNBCmp02 cmp02Field;

        private EnvelopeBodyDELFORUNBCmp03 cmp03Field;

        private EnvelopeBodyDELFORUNBCmp04 cmp04Field;

        private ushort e01_0020Field;

        /// <remarks/>
        public EnvelopeBodyDELFORUNBCmp01 cmp01
        {
            get
            {
                return this.cmp01Field;
            }
            set
            {
                this.cmp01Field = value;
            }
        }

        /// <remarks/>
        public EnvelopeBodyDELFORUNBCmp02 cmp02
        {
            get
            {
                return this.cmp02Field;
            }
            set
            {
                this.cmp02Field = value;
            }
        }

        /// <remarks/>
        public EnvelopeBodyDELFORUNBCmp03 cmp03
        {
            get
            {
                return this.cmp03Field;
            }
            set
            {
                this.cmp03Field = value;
            }
        }

        /// <remarks/>
        public EnvelopeBodyDELFORUNBCmp04 cmp04
        {
            get
            {
                return this.cmp04Field;
            }
            set
            {
                this.cmp04Field = value;
            }
        }

        /// <remarks/>
        public ushort e01_0020
        {
            get
            {
                return this.e01_0020Field;
            }
            set
            {
                this.e01_0020Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORUNBCmp01
    {

        private string e01_0001Field;

        private byte e02_0002Field;

        /// <remarks/>
        public string e01_0001
        {
            get
            {
                return this.e01_0001Field;
            }
            set
            {
                this.e01_0001Field = value;
            }
        }

        /// <remarks/>
        public byte e02_0002
        {
            get
            {
                return this.e02_0002Field;
            }
            set
            {
                this.e02_0002Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORUNBCmp02
    {

        private string e01_0004Field;

        /// <remarks/>
        public string e01_0004
        {
            get
            {
                return this.e01_0004Field;
            }
            set
            {
                this.e01_0004Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORUNBCmp03
    {

        private string e01_0010Field;

        /// <remarks/>
        public string e01_0010
        {
            get
            {
                return this.e01_0010Field;
            }
            set
            {
                this.e01_0010Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORUNBCmp04
    {

        private uint e01_0017Field;

        private ushort e02_0019Field;

        /// <remarks/>
        public uint e01_0017
        {
            get
            {
                return this.e01_0017Field;
            }
            set
            {
                this.e01_0017Field = value;
            }
        }

        /// <remarks/>
        public ushort e02_0019
        {
            get
            {
                return this.e02_0019Field;
            }
            set
            {
                this.e02_0019Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORUNH
    {

        private byte e01_0062Field;

        private EnvelopeBodyDELFORUNHCmp01 cmp01Field;

        /// <remarks/>
        public byte e01_0062
        {
            get
            {
                return this.e01_0062Field;
            }
            set
            {
                this.e01_0062Field = value;
            }
        }

        /// <remarks/>
        public EnvelopeBodyDELFORUNHCmp01 cmp01
        {
            get
            {
                return this.cmp01Field;
            }
            set
            {
                this.cmp01Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORUNHCmp01
    {

        private string e01_0065Field;

        private string e02_0052Field;

        private string e03_0054Field;

        private string e04_0051Field;

        private string e05_0057Field;

        /// <remarks/>
        public string e01_0065
        {
            get
            {
                return this.e01_0065Field;
            }
            set
            {
                this.e01_0065Field = value;
            }
        }

        /// <remarks/>
        public string e02_0052
        {
            get
            {
                return this.e02_0052Field;
            }
            set
            {
                this.e02_0052Field = value;
            }
        }

        /// <remarks/>
        public string e03_0054
        {
            get
            {
                return this.e03_0054Field;
            }
            set
            {
                this.e03_0054Field = value;
            }
        }

        /// <remarks/>
        public string e04_0051
        {
            get
            {
                return this.e04_0051Field;
            }
            set
            {
                this.e04_0051Field = value;
            }
        }

        /// <remarks/>
        public string e05_0057
        {
            get
            {
                return this.e05_0057Field;
            }
            set
            {
                this.e05_0057Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORBGM
    {

        private EnvelopeBodyDELFORBGMCmp01 cmp01Field;

        private ulong e01_1004Field;

        /// <remarks/>
        public EnvelopeBodyDELFORBGMCmp01 cmp01
        {
            get
            {
                return this.cmp01Field;
            }
            set
            {
                this.cmp01Field = value;
            }
        }

        /// <remarks/>
        public ulong e01_1004
        {
            get
            {
                return this.e01_1004Field;
            }
            set
            {
                this.e01_1004Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORBGMCmp01
    {

        private byte e01_1001Field;

        /// <remarks/>
        public byte e01_1001
        {
            get
            {
                return this.e01_1001Field;
            }
            set
            {
                this.e01_1001Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORDTM
    {

        private EnvelopeBodyDELFORDTMCmp01 cmp01Field;

        /// <remarks/>
        public EnvelopeBodyDELFORDTMCmp01 cmp01
        {
            get
            {
                return this.cmp01Field;
            }
            set
            {
                this.cmp01Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORDTMCmp01
    {

        private byte e01_2005Field;

        private ulong e02_2380Field;

        private byte e03_2379Field;

        /// <remarks/>
        public byte e01_2005
        {
            get
            {
                return this.e01_2005Field;
            }
            set
            {
                this.e01_2005Field = value;
            }
        }

        /// <remarks/>
        public ulong e02_2380
        {
            get
            {
                return this.e02_2380Field;
            }
            set
            {
                this.e02_2380Field = value;
            }
        }

        /// <remarks/>
        public byte e03_2379
        {
            get
            {
                return this.e03_2379Field;
            }
            set
            {
                this.e03_2379Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG001
    {

        private EnvelopeBodyDELFORG001RFF rFFField;

        /// <remarks/>
        public EnvelopeBodyDELFORG001RFF RFF
        {
            get
            {
                return this.rFFField;
            }
            set
            {
                this.rFFField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG001RFF
    {

        private EnvelopeBodyDELFORG001RFFCmp01 cmp01Field;

        /// <remarks/>
        public EnvelopeBodyDELFORG001RFFCmp01 cmp01
        {
            get
            {
                return this.cmp01Field;
            }
            set
            {
                this.cmp01Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG001RFFCmp01
    {

        private string e01_1153Field;

        private ushort e02_1154Field;

        /// <remarks/>
        public string e01_1153
        {
            get
            {
                return this.e01_1153Field;
            }
            set
            {
                this.e01_1153Field = value;
            }
        }

        /// <remarks/>
        public ushort e02_1154
        {
            get
            {
                return this.e02_1154Field;
            }
            set
            {
                this.e02_1154Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG002
    {

        private EnvelopeBodyDELFORG002NAD nADField;

        /// <remarks/>
        public EnvelopeBodyDELFORG002NAD NAD
        {
            get
            {
                return this.nADField;
            }
            set
            {
                this.nADField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG002NAD
    {

        private string e01_3035Field;

        private EnvelopeBodyDELFORG002NADCmp01 cmp01Field;

        private EnvelopeBodyDELFORG002NADCmp03 cmp03Field;

        private EnvelopeBodyDELFORG002NADCmp04 cmp04Field;

        private string e02_3164Field;

        private ushort e04_3251Field;

        private string e05_3207Field;

        /// <remarks/>
        public string e01_3035
        {
            get
            {
                return this.e01_3035Field;
            }
            set
            {
                this.e01_3035Field = value;
            }
        }

        /// <remarks/>
        public EnvelopeBodyDELFORG002NADCmp01 cmp01
        {
            get
            {
                return this.cmp01Field;
            }
            set
            {
                this.cmp01Field = value;
            }
        }

        /// <remarks/>
        public EnvelopeBodyDELFORG002NADCmp03 cmp03
        {
            get
            {
                return this.cmp03Field;
            }
            set
            {
                this.cmp03Field = value;
            }
        }

        /// <remarks/>
        public EnvelopeBodyDELFORG002NADCmp04 cmp04
        {
            get
            {
                return this.cmp04Field;
            }
            set
            {
                this.cmp04Field = value;
            }
        }

        /// <remarks/>
        public string e02_3164
        {
            get
            {
                return this.e02_3164Field;
            }
            set
            {
                this.e02_3164Field = value;
            }
        }

        /// <remarks/>
        public ushort e04_3251
        {
            get
            {
                return this.e04_3251Field;
            }
            set
            {
                this.e04_3251Field = value;
            }
        }

        /// <remarks/>
        public string e05_3207
        {
            get
            {
                return this.e05_3207Field;
            }
            set
            {
                this.e05_3207Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG002NADCmp01
    {

        private string e01_3039Field;

        private byte e03_3055Field;

        /// <remarks/>
        public string e01_3039
        {
            get
            {
                return this.e01_3039Field;
            }
            set
            {
                this.e01_3039Field = value;
            }
        }

        /// <remarks/>
        public byte e03_3055
        {
            get
            {
                return this.e03_3055Field;
            }
            set
            {
                this.e03_3055Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG002NADCmp03
    {

        private string e01_3036Field;

        /// <remarks/>
        public string e01_3036
        {
            get
            {
                return this.e01_3036Field;
            }
            set
            {
                this.e01_3036Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG002NADCmp04
    {

        private string e01_3042Field;

        private string e02_3042Field;

        /// <remarks/>
        public string e01_3042
        {
            get
            {
                return this.e01_3042Field;
            }
            set
            {
                this.e01_3042Field = value;
            }
        }

        /// <remarks/>
        public string e02_3042
        {
            get
            {
                return this.e02_3042Field;
            }
            set
            {
                this.e02_3042Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORUNS
    {

        private string e01_0081Field;

        /// <remarks/>
        public string e01_0081
        {
            get
            {
                return this.e01_0081Field;
            }
            set
            {
                this.e01_0081Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG004
    {

        private EnvelopeBodyDELFORG004NAD nADField;

        private EnvelopeBodyDELFORG004G008 g008Field;

        /// <remarks/>
        public EnvelopeBodyDELFORG004NAD NAD
        {
            get
            {
                return this.nADField;
            }
            set
            {
                this.nADField = value;
            }
        }

        /// <remarks/>
        public EnvelopeBodyDELFORG004G008 g008
        {
            get
            {
                return this.g008Field;
            }
            set
            {
                this.g008Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG004NAD
    {

        private string e01_3035Field;

        private EnvelopeBodyDELFORG004NADCmp01 cmp01Field;

        private EnvelopeBodyDELFORG004NADCmp02 cmp02Field;

        private EnvelopeBodyDELFORG004NADCmp03 cmp03Field;

        private EnvelopeBodyDELFORG004NADCmp04 cmp04Field;

        private ushort e04_3251Field;

        private string e05_3207Field;

        /// <remarks/>
        public string e01_3035
        {
            get
            {
                return this.e01_3035Field;
            }
            set
            {
                this.e01_3035Field = value;
            }
        }

        /// <remarks/>
        public EnvelopeBodyDELFORG004NADCmp01 cmp01
        {
            get
            {
                return this.cmp01Field;
            }
            set
            {
                this.cmp01Field = value;
            }
        }

        /// <remarks/>
        public EnvelopeBodyDELFORG004NADCmp02 cmp02
        {
            get
            {
                return this.cmp02Field;
            }
            set
            {
                this.cmp02Field = value;
            }
        }

        /// <remarks/>
        public EnvelopeBodyDELFORG004NADCmp03 cmp03
        {
            get
            {
                return this.cmp03Field;
            }
            set
            {
                this.cmp03Field = value;
            }
        }

        /// <remarks/>
        public EnvelopeBodyDELFORG004NADCmp04 cmp04
        {
            get
            {
                return this.cmp04Field;
            }
            set
            {
                this.cmp04Field = value;
            }
        }

        /// <remarks/>
        public ushort e04_3251
        {
            get
            {
                return this.e04_3251Field;
            }
            set
            {
                this.e04_3251Field = value;
            }
        }

        /// <remarks/>
        public string e05_3207
        {
            get
            {
                return this.e05_3207Field;
            }
            set
            {
                this.e05_3207Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG004NADCmp01
    {

        private ulong e01_3039Field;

        private byte e03_3055Field;

        /// <remarks/>
        public ulong e01_3039
        {
            get
            {
                return this.e01_3039Field;
            }
            set
            {
                this.e01_3039Field = value;
            }
        }

        /// <remarks/>
        public byte e03_3055
        {
            get
            {
                return this.e03_3055Field;
            }
            set
            {
                this.e03_3055Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG004NADCmp02
    {

        private string e01_3124Field;

        /// <remarks/>
        public string e01_3124
        {
            get
            {
                return this.e01_3124Field;
            }
            set
            {
                this.e01_3124Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG004NADCmp03
    {

        private string e01_3036Field;

        /// <remarks/>
        public string e01_3036
        {
            get
            {
                return this.e01_3036Field;
            }
            set
            {
                this.e01_3036Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG004NADCmp04
    {

        private string e01_3042Field;

        private string e02_3042Field;

        /// <remarks/>
        public string e01_3042
        {
            get
            {
                return this.e01_3042Field;
            }
            set
            {
                this.e01_3042Field = value;
            }
        }

        /// <remarks/>
        public string e02_3042
        {
            get
            {
                return this.e02_3042Field;
            }
            set
            {
                this.e02_3042Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG004G008
    {

        private EnvelopeBodyDELFORG004G008LIN lINField;

        private EnvelopeBodyDELFORG004G008IMD iMDField;

        private EnvelopeBodyDELFORG004G008LOC lOCField;

        private EnvelopeBodyDELFORG004G008G010 g010Field;

        private EnvelopeBodyDELFORG004G008G012[] g012Field;

        private EnvelopeBodyDELFORG004G008G014 g014Field;

        /// <remarks/>
        public EnvelopeBodyDELFORG004G008LIN LIN
        {
            get
            {
                return this.lINField;
            }
            set
            {
                this.lINField = value;
            }
        }

        /// <remarks/>
        public EnvelopeBodyDELFORG004G008IMD IMD
        {
            get
            {
                return this.iMDField;
            }
            set
            {
                this.iMDField = value;
            }
        }

        /// <remarks/>
        public EnvelopeBodyDELFORG004G008LOC LOC
        {
            get
            {
                return this.lOCField;
            }
            set
            {
                this.lOCField = value;
            }
        }

        /// <remarks/>
        public EnvelopeBodyDELFORG004G008G010 g010
        {
            get
            {
                return this.g010Field;
            }
            set
            {
                this.g010Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("g012")]
        public EnvelopeBodyDELFORG004G008G012[] g012
        {
            get
            {
                return this.g012Field;
            }
            set
            {
                this.g012Field = value;
            }
        }

        /// <remarks/>
        public EnvelopeBodyDELFORG004G008G014 g014
        {
            get
            {
                return this.g014Field;
            }
            set
            {
                this.g014Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG004G008LIN
    {

        private byte e01_1082Field;

        private byte e02_1229Field;

        private EnvelopeBodyDELFORG004G008LINCmp01 cmp01Field;

        /// <remarks/>
        public byte e01_1082
        {
            get
            {
                return this.e01_1082Field;
            }
            set
            {
                this.e01_1082Field = value;
            }
        }

        /// <remarks/>
        public byte e02_1229
        {
            get
            {
                return this.e02_1229Field;
            }
            set
            {
                this.e02_1229Field = value;
            }
        }

        /// <remarks/>
        public EnvelopeBodyDELFORG004G008LINCmp01 cmp01
        {
            get
            {
                return this.cmp01Field;
            }
            set
            {
                this.cmp01Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG004G008LINCmp01
    {

        private uint e01_7140Field;

        private string e02_7143Field;

        /// <remarks/>
        public uint e01_7140
        {
            get
            {
                return this.e01_7140Field;
            }
            set
            {
                this.e01_7140Field = value;
            }
        }

        /// <remarks/>
        public string e02_7143
        {
            get
            {
                return this.e02_7143Field;
            }
            set
            {
                this.e02_7143Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG004G008IMD
    {

        private EnvelopeBodyDELFORG004G008IMDCmp01 cmp01Field;

        /// <remarks/>
        public EnvelopeBodyDELFORG004G008IMDCmp01 cmp01
        {
            get
            {
                return this.cmp01Field;
            }
            set
            {
                this.cmp01Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG004G008IMDCmp01
    {

        private string e04_7008Field;

        /// <remarks/>
        public string e04_7008
        {
            get
            {
                return this.e04_7008Field;
            }
            set
            {
                this.e04_7008Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG004G008LOC
    {

        private byte e01_3227Field;

        private EnvelopeBodyDELFORG004G008LOCCmp01 cmp01Field;

        /// <remarks/>
        public byte e01_3227
        {
            get
            {
                return this.e01_3227Field;
            }
            set
            {
                this.e01_3227Field = value;
            }
        }

        /// <remarks/>
        public EnvelopeBodyDELFORG004G008LOCCmp01 cmp01
        {
            get
            {
                return this.cmp01Field;
            }
            set
            {
                this.cmp01Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG004G008LOCCmp01
    {

        private string e01_3225Field;

        /// <remarks/>
        public string e01_3225
        {
            get
            {
                return this.e01_3225Field;
            }
            set
            {
                this.e01_3225Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG004G008G010
    {

        private EnvelopeBodyDELFORG004G008G010RFF rFFField;

        /// <remarks/>
        public EnvelopeBodyDELFORG004G008G010RFF RFF
        {
            get
            {
                return this.rFFField;
            }
            set
            {
                this.rFFField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG004G008G010RFF
    {

        private EnvelopeBodyDELFORG004G008G010RFFCmp01 cmp01Field;

        /// <remarks/>
        public EnvelopeBodyDELFORG004G008G010RFFCmp01 cmp01
        {
            get
            {
                return this.cmp01Field;
            }
            set
            {
                this.cmp01Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG004G008G010RFFCmp01
    {

        private string e01_1153Field;

        private uint e02_1154Field;

        /// <remarks/>
        public string e01_1153
        {
            get
            {
                return this.e01_1153Field;
            }
            set
            {
                this.e01_1153Field = value;
            }
        }

        /// <remarks/>
        public uint e02_1154
        {
            get
            {
                return this.e02_1154Field;
            }
            set
            {
                this.e02_1154Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG004G008G012
    {

        private EnvelopeBodyDELFORG004G008G012QTY qTYField;

        private EnvelopeBodyDELFORG004G008G012G013 g013Field;

        private EnvelopeBodyDELFORG004G008G012SCC sCCField;

        private EnvelopeBodyDELFORG004G008G012DTM[] dTMField;

        /// <remarks/>
        public EnvelopeBodyDELFORG004G008G012QTY QTY
        {
            get
            {
                return this.qTYField;
            }
            set
            {
                this.qTYField = value;
            }
        }

        /// <remarks/>
        public EnvelopeBodyDELFORG004G008G012G013 g013
        {
            get
            {
                return this.g013Field;
            }
            set
            {
                this.g013Field = value;
            }
        }

        /// <remarks/>
        public EnvelopeBodyDELFORG004G008G012SCC SCC
        {
            get
            {
                return this.sCCField;
            }
            set
            {
                this.sCCField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DTM")]
        public EnvelopeBodyDELFORG004G008G012DTM[] DTM
        {
            get
            {
                return this.dTMField;
            }
            set
            {
                this.dTMField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG004G008G012QTY
    {

        private EnvelopeBodyDELFORG004G008G012QTYCmp01 cmp01Field;

        /// <remarks/>
        public EnvelopeBodyDELFORG004G008G012QTYCmp01 cmp01
        {
            get
            {
                return this.cmp01Field;
            }
            set
            {
                this.cmp01Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG004G008G012QTYCmp01
    {

        private byte e01_6063Field;

        private ushort e02_6060Field;

        private string e03_6411Field;

        /// <remarks/>
        public byte e01_6063
        {
            get
            {
                return this.e01_6063Field;
            }
            set
            {
                this.e01_6063Field = value;
            }
        }

        /// <remarks/>
        public ushort e02_6060
        {
            get
            {
                return this.e02_6060Field;
            }
            set
            {
                this.e02_6060Field = value;
            }
        }

        /// <remarks/>
        public string e03_6411
        {
            get
            {
                return this.e03_6411Field;
            }
            set
            {
                this.e03_6411Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG004G008G012G013
    {

        private EnvelopeBodyDELFORG004G008G012G013RFF rFFField;

        private EnvelopeBodyDELFORG004G008G012G013DTM dTMField;

        /// <remarks/>
        public EnvelopeBodyDELFORG004G008G012G013RFF RFF
        {
            get
            {
                return this.rFFField;
            }
            set
            {
                this.rFFField = value;
            }
        }

        /// <remarks/>
        public EnvelopeBodyDELFORG004G008G012G013DTM DTM
        {
            get
            {
                return this.dTMField;
            }
            set
            {
                this.dTMField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG004G008G012G013RFF
    {

        private EnvelopeBodyDELFORG004G008G012G013RFFCmp01 cmp01Field;

        /// <remarks/>
        public EnvelopeBodyDELFORG004G008G012G013RFFCmp01 cmp01
        {
            get
            {
                return this.cmp01Field;
            }
            set
            {
                this.cmp01Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG004G008G012G013RFFCmp01
    {

        private string e01_1153Field;

        private uint e02_1154Field;

        /// <remarks/>
        public string e01_1153
        {
            get
            {
                return this.e01_1153Field;
            }
            set
            {
                this.e01_1153Field = value;
            }
        }

        /// <remarks/>
        public uint e02_1154
        {
            get
            {
                return this.e02_1154Field;
            }
            set
            {
                this.e02_1154Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG004G008G012G013DTM
    {

        private EnvelopeBodyDELFORG004G008G012G013DTMCmp01 cmp01Field;

        /// <remarks/>
        public EnvelopeBodyDELFORG004G008G012G013DTMCmp01 cmp01
        {
            get
            {
                return this.cmp01Field;
            }
            set
            {
                this.cmp01Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG004G008G012G013DTMCmp01
    {

        private byte e01_2005Field;

        private uint e02_2380Field;

        private byte e03_2379Field;

        /// <remarks/>
        public byte e01_2005
        {
            get
            {
                return this.e01_2005Field;
            }
            set
            {
                this.e01_2005Field = value;
            }
        }

        /// <remarks/>
        public uint e02_2380
        {
            get
            {
                return this.e02_2380Field;
            }
            set
            {
                this.e02_2380Field = value;
            }
        }

        /// <remarks/>
        public byte e03_2379
        {
            get
            {
                return this.e03_2379Field;
            }
            set
            {
                this.e03_2379Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG004G008G012SCC
    {

        private byte e01_4017Field;

        /// <remarks/>
        public byte e01_4017
        {
            get
            {
                return this.e01_4017Field;
            }
            set
            {
                this.e01_4017Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG004G008G012DTM
    {

        private EnvelopeBodyDELFORG004G008G012DTMCmp01 cmp01Field;

        /// <remarks/>
        public EnvelopeBodyDELFORG004G008G012DTMCmp01 cmp01
        {
            get
            {
                return this.cmp01Field;
            }
            set
            {
                this.cmp01Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG004G008G012DTMCmp01
    {

        private byte e01_2005Field;

        private ulong e02_2380Field;

        private byte e03_2379Field;

        /// <remarks/>
        public byte e01_2005
        {
            get
            {
                return this.e01_2005Field;
            }
            set
            {
                this.e01_2005Field = value;
            }
        }

        /// <remarks/>
        public ulong e02_2380
        {
            get
            {
                return this.e02_2380Field;
            }
            set
            {
                this.e02_2380Field = value;
            }
        }

        /// <remarks/>
        public byte e03_2379
        {
            get
            {
                return this.e03_2379Field;
            }
            set
            {
                this.e03_2379Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG004G008G014
    {

        private EnvelopeBodyDELFORG004G008G014PAC pACField;

        private EnvelopeBodyDELFORG004G008G014QTY qTYField;

        /// <remarks/>
        public EnvelopeBodyDELFORG004G008G014PAC PAC
        {
            get
            {
                return this.pACField;
            }
            set
            {
                this.pACField = value;
            }
        }

        /// <remarks/>
        public EnvelopeBodyDELFORG004G008G014QTY QTY
        {
            get
            {
                return this.qTYField;
            }
            set
            {
                this.qTYField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG004G008G014PAC
    {

        private EnvelopeBodyDELFORG004G008G014PACCmp02 cmp02Field;

        /// <remarks/>
        public EnvelopeBodyDELFORG004G008G014PACCmp02 cmp02
        {
            get
            {
                return this.cmp02Field;
            }
            set
            {
                this.cmp02Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG004G008G014PACCmp02
    {

        private string e01_7065Field;

        private byte e03_3055Field;

        private string e04_7064Field;

        /// <remarks/>
        public string e01_7065
        {
            get
            {
                return this.e01_7065Field;
            }
            set
            {
                this.e01_7065Field = value;
            }
        }

        /// <remarks/>
        public byte e03_3055
        {
            get
            {
                return this.e03_3055Field;
            }
            set
            {
                this.e03_3055Field = value;
            }
        }

        /// <remarks/>
        public string e04_7064
        {
            get
            {
                return this.e04_7064Field;
            }
            set
            {
                this.e04_7064Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG004G008G014QTY
    {

        private EnvelopeBodyDELFORG004G008G014QTYCmp01 cmp01Field;

        /// <remarks/>
        public EnvelopeBodyDELFORG004G008G014QTYCmp01 cmp01
        {
            get
            {
                return this.cmp01Field;
            }
            set
            {
                this.cmp01Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORG004G008G014QTYCmp01
    {

        private byte e01_6063Field;

        private ushort e02_6060Field;

        private string e03_6411Field;

        /// <remarks/>
        public byte e01_6063
        {
            get
            {
                return this.e01_6063Field;
            }
            set
            {
                this.e01_6063Field = value;
            }
        }

        /// <remarks/>
        public ushort e02_6060
        {
            get
            {
                return this.e02_6060Field;
            }
            set
            {
                this.e02_6060Field = value;
            }
        }

        /// <remarks/>
        public string e03_6411
        {
            get
            {
                return this.e03_6411Field;
            }
            set
            {
                this.e03_6411Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORUNS_2
    {

        private object e01_0081Field;

        /// <remarks/>
        public object e01_0081
        {
            get
            {
                return this.e01_0081Field;
            }
            set
            {
                this.e01_0081Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORUNT
    {

        private byte e01_0074Field;

        private byte e02_0062Field;

        /// <remarks/>
        public byte e01_0074
        {
            get
            {
                return this.e01_0074Field;
            }
            set
            {
                this.e01_0074Field = value;
            }
        }

        /// <remarks/>
        public byte e02_0062
        {
            get
            {
                return this.e02_0062Field;
            }
            set
            {
                this.e02_0062Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.intentia.com/Schemas/mec")]
    public partial class EnvelopeBodyDELFORUNZ
    {

        private byte e01_0036Field;

        private ushort e02_0020Field;

        /// <remarks/>
        public byte e01_0036
        {
            get
            {
                return this.e01_0036Field;
            }
            set
            {
                this.e01_0036Field = value;
            }
        }

        /// <remarks/>
        public ushort e02_0020
        {
            get
            {
                return this.e02_0020Field;
            }
            set
            {
                this.e02_0020Field = value;
            }
        }
    }


}
