using Solnet.Rpc.Models;

namespace Solnet.Programs.Model
{
    public interface IDecodedAccount<out T>
    {
        public AccountInfo Info { get; }
        public T Value { get; }
    }

    public class DecodedAccount<T> : IDecodedAccount<T>
    {
        public AccountInfo Info { get; init; }
        public T Value { get; init; }

        public DecodedAccount(AccountInfo info, T value)
        {
            Info = info;
            Value = value;
        }
    }
}