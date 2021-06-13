using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.Types;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Common.Services;

namespace WolvenKit.RED4.CR2W.Types
{

    [Editor(typeof(IBoolEditor), typeof(IPropertyEditorBase))]
    public class CBool : CVariable, IREDBool
    {
        public CBool()
        {

        }
        public CBool(CR2WFile cr2w, CVariable parent, string name)
            : base(cr2w, parent, name)
        {
        }

        private byte _backingField;

        public bool Value
        {
            get => _backingField != 0;
            set => _backingField = value ? (byte)1 : (byte)0;
        }

        public override void Read(BinaryReader file, uint size) => _backingField = file.ReadByte();

        public override void Write(BinaryWriter file) => file.Write(_backingField);

        //file.Write(val ? (byte) 1 : (byte) 0);
        public override CVariable SetValue(object val)
        {
            this.Value = val switch
            {
                bool b => b,
                string s => bool.Parse(s),
                CBool v => v.Value,
                _ => this.Value
            };

            return this;
        }

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CBool)base.Copy(context);
            var._backingField = _backingField;
            return var;
        }

        public override string ToString() => Value ? "True" : "False";
    }
}
