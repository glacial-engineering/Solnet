using Solnet.Programs.Model;
using Solnet.Rpc.Models;
using System;

namespace Solnet.Programs
{
    public abstract class ProgramAccountDecoder
    {
        public virtual IDecodedAccount<object> DecodeAccount(AccountInfo accountInfo)
        {
            var bytes = Convert.FromBase64String(accountInfo.Data[0]);
            var value = Decode(bytes);
            var daType = typeof(DecodedAccount<>).MakeGenericType(value.GetType());
            var t = Activator.CreateInstance(daType, accountInfo, value);
            return t as IDecodedAccount<object>;
        }

        public abstract object Decode(byte[] data);
    }
}