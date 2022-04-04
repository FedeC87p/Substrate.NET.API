//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.AjunaWorker;
using Ajuna.NetApi.Model.Meta;
using Ajuna.NetApi.Model.PalletConnectfour;
using Ajuna.NetApi.Model.PrimitiveTypes;
using Ajuna.NetApi.Model.SpCore;
using Ajuna.NetApi.Model.SpRuntime;
using Ajuna.NetApi.Model.Types;
using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Primitive;
using Newtonsoft.Json;
using Org.BouncyCastle.Security;
using SimpleBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ajuna.NetApi
{


    public sealed class SubstrateClientExt : Ajuna.NetApi.SubstrateClient
    {

        /// <summary>
        /// StorageKeyDict for key definition informations.
        /// </summary>
        public System.Collections.Generic.Dictionary<System.Tuple<string, string>, System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>> StorageKeyDict;

        /// <summary>
        /// SystemStorage storage calls.
        /// </summary>
        public Ajuna.NetApi.Model.FrameSystem.SystemStorage SystemStorage;

        /// <summary>
        /// RandomnessCollectiveFlipStorage storage calls.
        /// </summary>
        public Ajuna.NetApi.Model.PalletRandomnessCollectiveFlip.RandomnessCollectiveFlipStorage RandomnessCollectiveFlipStorage;

        /// <summary>
        /// TimestampStorage storage calls.
        /// </summary>
        public Ajuna.NetApi.Model.PalletTimestamp.TimestampStorage TimestampStorage;

        /// <summary>
        /// AuraStorage storage calls.
        /// </summary>
        public Ajuna.NetApi.Model.PalletAura.AuraStorage AuraStorage;

        /// <summary>
        /// GrandpaStorage storage calls.
        /// </summary>
        public Ajuna.NetApi.Model.PalletGrandpa.GrandpaStorage GrandpaStorage;

        /// <summary>
        /// BalancesStorage storage calls.
        /// </summary>
        public Ajuna.NetApi.Model.PalletBalances.BalancesStorage BalancesStorage;

        /// <summary>
        /// TransactionPaymentStorage storage calls.
        /// </summary>
        public Ajuna.NetApi.Model.PalletTransactionPayment.TransactionPaymentStorage TransactionPaymentStorage;

        /// <summary>
        /// AssetsStorage storage calls.
        /// </summary>
        public Ajuna.NetApi.Model.PalletAssets.AssetsStorage AssetsStorage;

        /// <summary>
        /// SudoStorage storage calls.
        /// </summary>
        public Ajuna.NetApi.Model.PalletSudo.SudoStorage SudoStorage;

        /// <summary>
        /// TeerexStorage storage calls.
        /// </summary>
        public Ajuna.NetApi.Model.PalletTeerex.TeerexStorage TeerexStorage;

        /// <summary>
        /// ConnectFourStorage storage calls.
        /// </summary>
        public Ajuna.NetApi.Model.PalletConnectFour.ConnectFourStorage ConnectFourStorage;

        /// <summary>
        /// SchedulerStorage storage calls.
        /// </summary>
        public Ajuna.NetApi.Model.PalletScheduler.SchedulerStorage SchedulerStorage;

        /// <summary>
        /// MatchmakerStorage storage calls.
        /// </summary>
        public Ajuna.NetApi.Model.PalletMatchmaker.MatchmakerStorage MatchmakerStorage;

        /// <summary>
        /// GameRegistryStorage storage calls.
        /// </summary>
        public Ajuna.NetApi.Model.PalletGameRegistry.GameRegistryStorage GameRegistryStorage;

        /// <summary>
        /// ObserversStorage storage calls.
        /// </summary>
        public Ajuna.NetApi.Model.PalletObservers.ObserversStorage ObserversStorage;

        public SubstrateClientExt(System.Uri uri) :
                base(uri)
        {
            StorageKeyDict = new System.Collections.Generic.Dictionary<System.Tuple<string, string>, System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>>();
            this.SystemStorage = new Ajuna.NetApi.Model.FrameSystem.SystemStorage(this);
            this.RandomnessCollectiveFlipStorage = new Ajuna.NetApi.Model.PalletRandomnessCollectiveFlip.RandomnessCollectiveFlipStorage(this);
            this.TimestampStorage = new Ajuna.NetApi.Model.PalletTimestamp.TimestampStorage(this);
            this.AuraStorage = new Ajuna.NetApi.Model.PalletAura.AuraStorage(this);
            this.GrandpaStorage = new Ajuna.NetApi.Model.PalletGrandpa.GrandpaStorage(this);
            this.BalancesStorage = new Ajuna.NetApi.Model.PalletBalances.BalancesStorage(this);
            this.TransactionPaymentStorage = new Ajuna.NetApi.Model.PalletTransactionPayment.TransactionPaymentStorage(this);
            this.AssetsStorage = new Ajuna.NetApi.Model.PalletAssets.AssetsStorage(this);
            this.SudoStorage = new Ajuna.NetApi.Model.PalletSudo.SudoStorage(this);
            this.TeerexStorage = new Ajuna.NetApi.Model.PalletTeerex.TeerexStorage(this);
            this.ConnectFourStorage = new Ajuna.NetApi.Model.PalletConnectFour.ConnectFourStorage(this);
            this.SchedulerStorage = new Ajuna.NetApi.Model.PalletScheduler.SchedulerStorage(this);
            this.MatchmakerStorage = new Ajuna.NetApi.Model.PalletMatchmaker.MatchmakerStorage(this);
            this.GameRegistryStorage = new Ajuna.NetApi.Model.PalletGameRegistry.GameRegistryStorage(this);
            this.ObserversStorage = new Ajuna.NetApi.Model.PalletObservers.ObserversStorage(this);
        }

        public enum Wrapped
        {
            Nonce,
            Balance,
            Board,
            Hash
        }

        public bool Unwrap<T>(Wrapped wrapped, RpcReturnValue returnValue, out T result) where T : IType, new()
        {
            result = new T();

            switch (returnValue.DirectRequestStatus.Value)
            {
                case DirectRequestStatus.Ok:
                    break;

                case DirectRequestStatus.TrustedOperationStatus:

                    var valueBytes = returnValue.Value.Value.Select(p => p.Value).ToArray();

                    switch (wrapped)
                    {
                        case Wrapped.Nonce:
                            var nonceWrapped = new BaseOpt<BaseVec<U8>>();
                            nonceWrapped.Create(valueBytes);
                            if (nonceWrapped.OptionFlag)
                            {
                                var bytes = nonceWrapped.Value.Value.Select(p => p.Value).ToArray();
                                result.Create(bytes);
                                return true;
                            }
                            break;

                        case Wrapped.Balance:
                            var balanceWrapped = new BaseOpt<BaseVec<U8>>();
                            balanceWrapped.Create(valueBytes);
                            if (balanceWrapped.OptionFlag)
                            {
                                var bytes = balanceWrapped.Value.Value.Select(p => p.Value).ToArray();
                                result.Create(bytes);
                                return true;
                            }
                            break;

                        case Wrapped.Hash:
                            result.Create(valueBytes);
                            return true;

                        case Wrapped.Board:
                            var boardWrapped = new BaseOpt<BaseVec<U8>>();
                            boardWrapped.Create(valueBytes);
                            if (boardWrapped.OptionFlag)
                            {
                                var bytes = boardWrapped.Value.Value.Select(p => p.Value).ToArray();
                                result.Create(bytes);
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                    }


                    break;

                case DirectRequestStatus.Error:
                    var byteArray = returnValue.Value.Bytes;
                    PrintBytes(UnwrapBytes(byteArray));
                    break;
            }

            return false;
        }

        public async Task BalanceTransferAsync(Account fromAccount, Account toAccount, uint amount, RSAParameters shieldingKey, string shardHex, string mrenclaveHex)
        {
            EnumTrustedOperation tOpNonce = CreateGetter(fromAccount, TrustedGetter.Nonce);
            var nonceValue = await ExecuteTrustedOperationAsync(tOpNonce, shieldingKey, shardHex);
            if (Unwrap(Wrapped.Nonce, nonceValue, out U32 nonce))
            {
                Console.WriteLine($"Account[{fromAccount.Value}]({nonce.Value}) transfers {amount} to Account[{toAccount.Value}]");
                EnumTrustedOperation tOpTransfer = CreateCallBalanceTransfer(fromAccount, toAccount, amount, nonce.Value, mrenclaveHex, shardHex);
                var returnValue = await ExecuteTrustedOperationAsync(tOpTransfer, shieldingKey, shardHex);
                if (Unwrap(Wrapped.Hash, returnValue, out H256 value))
                {
                    Console.WriteLine($"Hash is {Utils.Bytes2HexString(value.Value.Bytes)}");
                }
            }
        }

        public async Task PlayTurnAsync(Account account, byte column, RSAParameters shieldingKey, string shardHex, string mrenclaveHex)
        {
            EnumTrustedOperation tOpNonce = CreateGetter(account, TrustedGetter.Nonce);
            var nonceValue = await ExecuteTrustedOperationAsync(tOpNonce, shieldingKey, shardHex);
            if (Unwrap(Wrapped.Nonce, nonceValue, out U32 nonce))
            {
                Console.WriteLine($"Account[{account.Value}]({nonce.Value}) play {column}");
                EnumTrustedOperation tOpPlayTurn = CreateCallPlayTurn(account, column, nonce.Value, mrenclaveHex, shardHex);
                var returnValue = await ExecuteTrustedOperationAsync(tOpPlayTurn, shieldingKey, shardHex);
                if (Unwrap(Wrapped.Hash, returnValue, out H256 value))
                {
                    Console.WriteLine($"Hash is {Utils.Bytes2HexString(value.Value.Bytes)}");
                }
            }
        }

        public async Task<BoardStruct> GetBoardStructAsync(Account account, RSAParameters shieldingKey, string shardHex)
        {
            EnumTrustedOperation tOpBoard = CreateGetter(account, TrustedGetter.Board);
            var boardValue = await ExecuteTrustedOperationAsync(tOpBoard, shieldingKey, shardHex);
            if (Unwrap(Wrapped.Board, boardValue, out BoardStruct boardStruct))
            {
                return boardStruct;
            }

            return null;
        }

        public async Task<Balance> GetFreeBalanceAsync(Account account, RSAParameters shieldingKey, string shardHex)
        {
            EnumTrustedOperation tOpPreBalance = CreateGetter(account, TrustedGetter.FreeBalance);
            var balanceValuePre = await ExecuteTrustedOperationAsync(tOpPreBalance, shieldingKey, shardHex);
            if (Unwrap(Wrapped.Balance, balanceValuePre, out Balance balance))
            {
                return balance;
            }
            return null;
        }

        public async Task<RpcReturnValue> ExecuteTrustedOperationAsync(EnumTrustedOperation trustedOperation, RSAParameters shieldingKey, string shardHex)
        {
            var cypherText = SignTrustedOperation(shieldingKey, trustedOperation);

            // - ShardIdentifier
            var shardId = new H256();
            shardId.Create(Base58.Bitcoin.Decode(shardHex).ToArray());

            Request request = new Request
            {
                Shard = shardId,
                CypherText = VecU8FromBytes(cypherText)
            };

            // open connection
            await ConnectAsync(false, false, false, CancellationToken.None);

            var parameters = request.Encode().Cast<object>().ToArray();

            var result = await InvokeAsync<byte[]>("author_submitAndWatchExtrinsic", parameters, CancellationToken.None);

            var returnValue = new RpcReturnValue();
            returnValue.Create(result);

            await CloseAsync();

            return returnValue;

        }

        public EnumTrustedOperation CreateGetter(Account accountName, TrustedGetter trustedGetter)
        {
            var account = new AccountId32();
            account.Create(accountName.Bytes);

            var enumTrustedGetter = new EnumTrustedGetter();
            enumTrustedGetter.Create(trustedGetter, account);

            return GetEnumTrustedOperation(accountName, enumTrustedGetter);
        }

        public EnumTrustedOperation CreateCallPlayTurn(Account account, byte move, uint nonce, string mrenclaveHex, string shardHex)
        {
            var accountId32 = new AccountId32();
            accountId32.Create(account.Bytes);

            var column = new U8();
            column.Create(move);

            var playTurnTuple = new BaseTuple<AccountId32, U8>();
            playTurnTuple.Create(accountId32, column);

            var trustedCall = new EnumTrustedCall();
            trustedCall.Create(TrustedCall.ConnectfourPlayTurn, playTurnTuple);

            var index = new Ajuna.NetApi.Model.AjunaWorker.Index();
            index.Create(nonce);

            var mrenclave = new H256();
            mrenclave.Create(Base58.Bitcoin.Decode(mrenclaveHex).ToArray());

            var shard = new ShardIdentifier();
            shard.Create(Base58.Bitcoin.Decode(shardHex).ToArray());

            var trustedCallPayload = new TrustedCallPayload
            {
                Call = trustedCall,
                Nonce = index,
                Mrenclave = mrenclave,
                Shard = shard
            };

            return GetEnumTrustedOperation(account, trustedCallPayload);
        }

        public EnumTrustedOperation CreateCallBalanceTransfer(Account fromAccount, Account toAccount, uint amount, uint nonce, string mrenclaveHex, string shardHex)
        {
            var aliceAccount = new AccountId32();
            aliceAccount.Create(fromAccount.Bytes);

            var bobAccount = new AccountId32();
            bobAccount.Create(toAccount.Bytes);

            var balance = new Balance();
            balance.Create(new BigInteger(amount));

            var balanceTransferTuple = new BaseTuple<AccountId32, AccountId32, Balance>();
            balanceTransferTuple.Create(aliceAccount, bobAccount, balance);

            var trustedCall = new EnumTrustedCall();
            trustedCall.Create(TrustedCall.BalanceTransfer, balanceTransferTuple);

            var index = new Ajuna.NetApi.Model.AjunaWorker.Index();
            index.Create(nonce);

            var mrenclave = new H256();
            mrenclave.Create(Base58.Bitcoin.Decode(mrenclaveHex).ToArray());

            var shard = new ShardIdentifier();
            shard.Create(Base58.Bitcoin.Decode(shardHex).ToArray());

            var trustedCallPayload = new TrustedCallPayload
            {
                Call = trustedCall,
                Nonce = index,
                Mrenclave = mrenclave,
                Shard = shard
            };

            return GetEnumTrustedOperation(fromAccount, trustedCallPayload);
        }

        public byte[] SignTrustedOperation(RSAParameters shieldingKey, EnumTrustedOperation trustedOperation)
        {
            // - Encrypt Encoded TrustedOperation with RSAPubKey
            var keyPair = DotNetUtilities.GetRsaPublicKey(shieldingKey);
            return Utils.RSAEncryptBouncy(trustedOperation.Encode(), keyPair);
        }

        public byte[] UnwrapBytes(byte[] byteArray)
        {
            var baseVec1 = new BaseVec<U8>();
            baseVec1.Create(byteArray);

            var bytes1 = new List<byte>();
            foreach (var by in baseVec1.Value)
            {
                bytes1.Add(by.Value);
            }
            var baseVec2 = new BaseVec<U8>();
            baseVec2.Create(bytes1.ToArray());

            var bytes2 = new List<byte>();
            foreach (var by in baseVec2.Value)
            {
                bytes2.Add(by.Value);
            }
            return bytes2.ToArray();
        }

        public void PrintBytes(byte[] bytes)
        {
            var converter = new UTF8Encoding();
            var str = converter.GetString(bytes);
            Console.WriteLine(str);
        }

        public BaseVec<U8> VecU8FromBytes(byte[] vs)
        {
            var u8list = new List<U8>();
            for (int i = 0; i < vs.Length; i++)
            {
                var u8 = new U8();
                u8.Create(vs[i]);
                u8list.Add(u8);
            }
            var u8Array = u8list.ToArray();

            var result = new BaseVec<U8>();
            result.Create(u8Array);

            return result;
        }

        public EnumTrustedOperation GetEnumTrustedOperation(Account account, EnumTrustedGetter trustedGetter)
        {
            var signature = new Signature64();
            var signatureArray = Schnorrkel.Sr25519v091.SignSimple(Utils.GetPublicKeyFrom(account.Value), account.PrivateKey, trustedGetter.Encode());
            signature.Create(signatureArray);

            var enumMultiSignature = new EnumMultiSignature();
            enumMultiSignature.Create(MultiSignature.Sr25519, signature);

            var trustedGetterSigned = new TrustedGetterSigned();
            trustedGetterSigned.Getter = trustedGetter;
            trustedGetterSigned.Signature = enumMultiSignature;

            var getter = new EnumGetter();
            getter.Create(Getter.Trusted, trustedGetterSigned);

            var trustedOperation = new EnumTrustedOperation();
            trustedOperation.Create(TrustedOperation.Get, getter);

            return trustedOperation;
        }

        public EnumTrustedOperation GetEnumTrustedOperation(Account account, TrustedCallPayload trustedCallPayload)
        {
            var signature = new Signature64();
            var signatureArray = Schnorrkel.Sr25519v091.SignSimple(Utils.GetPublicKeyFrom(account.Value), account.PrivateKey, trustedCallPayload.Encode());
            signature.Create(signatureArray);

            var enumMultiSignature = new EnumMultiSignature();
            enumMultiSignature.Create(MultiSignature.Sr25519, signature);

            var trustedCallSigned = new TrustedCallSigned();
            trustedCallSigned.Call = trustedCallPayload.Call;
            trustedCallSigned.Nonce = trustedCallPayload.Nonce;
            trustedCallSigned.Signature = enumMultiSignature;

            var trustedOperation = new EnumTrustedOperation();
            trustedOperation.Create(TrustedOperation.DirectCall, trustedCallSigned);

            return trustedOperation;
        }

        public async Task<RSAParameters> ShieldingKeyAsync()
        {
            //using var client = new SubstrateClient(new Uri(Websocketurl));

            //var rpcMethods = await client.InvokeAsync<string>("rpc_methods", null, CancellationToken.None);
            //Console.WriteLine($"-----------> {rpcMethods}");

            //rpc_methods
            //author_getMuRaUrl
            //author_getShieldingKey byte[]
            //author_getUntrustedUrl
            //author_pendingExtrinsics
            //author_submitAndWatchExtrinsic
            //author_submitExtrinsic
            //chain_subscribeAllHeads
            //state_get
            //state_getMetadata
            //state_getRuntimeVersion
            //system_health
            //system_name
            //system_version

            await ConnectAsync(false, false, false, CancellationToken.None);

            var method = "author_getShieldingKey";
            var result = await InvokeAsync<byte[]>(method, null, CancellationToken.None);

            var rpcReturnValue = new RpcReturnValue();
            rpcReturnValue.Create(result);

            await CloseAsync();

            // - Create RSAPubKey from ShieldingKey

            var rsaParameters = new RSAParameters();

            if (rpcReturnValue.DirectRequestStatus.Value == DirectRequestStatus.Ok)
            {
                var rsaPubKeyStr = new UTF8Encoding().GetString(UnwrapBytes(rpcReturnValue.Value.Bytes));
                RSAPubKey rsaPubKey = JsonConvert.DeserializeObject<RSAPubKey>(rsaPubKeyStr);

                rsaParameters.Modulus = rsaPubKey.N.ToArray();
                rsaParameters.Exponent = rsaPubKey.E.ToArray();
                Array.Reverse(rsaParameters.Modulus, 0, rsaParameters.Modulus.Length);
                Array.Reverse(rsaParameters.Exponent, 0, rsaParameters.Exponent.Length);
                return rsaParameters;
            }

            return rsaParameters;
        }
    }
}