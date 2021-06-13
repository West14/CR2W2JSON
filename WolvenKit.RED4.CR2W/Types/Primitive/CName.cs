using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Linq;
using WolvenKit.RED4.CR2W.Reflection;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Common.Services;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta()]
    [Editor(typeof(INameEditor), typeof(IPropertyEditorBase))]
    public class CName : CVariable, IREDString
    {
        public CName(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            Value = "";
        }

        #region Properties
        public string Value { get; set; }
        #endregion


        #region Methods
        public override void Read(BinaryReader file, uint size)
        {
            var idx = file.ReadUInt16();
            Value = cr2w.Names[idx].Str;
        }

        /// <summary>
        /// Call after the stringtable was generated!
        /// </summary>
        /// <param name="file"></param>
        public override void Write(BinaryWriter file)
        {
            ushort val = 0;

            var nw = cr2w.Names.First(_ => _.Str == Value);
            val = (ushort)cr2w.Names.IndexOf(nw);

            file.Write(val);
        }

        public override CVariable SetValue(object val)
        {
            Value = val switch
            {
                string s => s,
                CName cval => cval.Value,
                _ => Value
            };

            return this;
        }

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CName)base.Copy(context);
            var.Value = Value;
            return var;
        }

        public override string ToString() => Value;

        #endregion

    }
}
