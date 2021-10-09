﻿using System;
using System.Numerics;

namespace Ajuna.NetApi.Model.Types.Primitive
{
    public class I128 : BasePrim<BigInteger>
    {
        public override string TypeName() => "i128";

        public override int TypeSize => 16;

        public override byte[] Encode()
        {
            var reversed = Bytes;
            Array.Reverse(reversed);
            return reversed;
        }

        public override void CreateFromJson(string str)
        {
            var bytes = Utils.HexToByteArray(str, true);
            Array.Reverse(bytes);
            var result = new byte[TypeSize];
            bytes.CopyTo(result, 0);
            Create(result);
        }

        public override void Create(byte[] byteArray)
        {
            if (byteArray.Length < TypeSize)
            {
                var newByteArray = new byte[TypeSize];
                byteArray.CopyTo(newByteArray, 0);
                byteArray = newByteArray;
            }

            Bytes = byteArray;
            Value = new BigInteger(byteArray);
        }

        public void Create(short value)
        {
            Bytes = BitConverter.GetBytes(value);
            Value = value;
        }
    }
}