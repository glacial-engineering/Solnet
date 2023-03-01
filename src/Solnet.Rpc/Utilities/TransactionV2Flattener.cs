using Solnet.Rpc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solnet.Rpc.Utilities
{
    public static class TransactionV2Flattener
    {
        public static void Flatten(TransactionMetaSlotInfo tx)
        {
            if (tx.Meta?.LoadedAddresses?.Writable?.Length > 0 ||
                tx.Meta?.LoadedAddresses?.Readonly?.Length > 0)
            {
                IEnumerable<string> txs = tx.Transaction.Message.AccountKeys;

                if (tx.Meta?.LoadedAddresses?.Writable?.Length > 0)
                    txs = txs.Concat(tx.Meta.LoadedAddresses.Writable);
                if (tx.Meta?.LoadedAddresses?.Readonly?.Length > 0)
                    txs = txs.Concat(tx.Meta.LoadedAddresses.Readonly);

                tx.Transaction.Message.AccountKeys = txs.ToArray();
            }
        }
    }
}
