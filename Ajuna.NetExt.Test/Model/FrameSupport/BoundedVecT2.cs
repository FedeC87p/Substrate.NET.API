//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;


namespace Ajuna.NetApi.Model.FrameSupport
{
    
    
    /// <summary>
    /// >> 135 - Composite[frame_support.storage.bounded_vec.BoundedVecT2]
    /// </summary>
    public sealed class BoundedVecT2 : BaseType
    {
        
        /// <summary>
        /// >> value
        /// </summary>
        private BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> _value;
        
        public BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
        
        public override string TypeName()
        {
            return "BoundedVecT2";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Value.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Value = new BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>();
            Value.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
