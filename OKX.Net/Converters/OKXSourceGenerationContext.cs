
using OKX.Net.Clients.UnifiedApi;
using OKX.Net.Objects.Account;
using OKX.Net.Objects.Affiliate;
using OKX.Net.Objects.Core;
using OKX.Net.Objects.Funding;
using OKX.Net.Objects.Market;
using OKX.Net.Objects.Public;
using OKX.Net.Objects.Sockets.Models;
using OKX.Net.Objects.SubAccount;
using OKX.Net.Objects.System;
using OKX.Net.Objects.Trade;
using OKX.Net.Objects.Trading;

namespace OKX.Net.Converters
{
    [JsonSerializable(typeof(OKXSocketResponse<OKXOrderPlaceResponse>))]
    [JsonSerializable(typeof(OKXSocketResponse<OKXOrderCancelResponse>))]
    [JsonSerializable(typeof(OKXSocketResponse<OKXOrderAmendResponse>))]

    [JsonSerializable(typeof(OKXSocketUpdate<OKXPositionAndBalanceUpdate[]>))]
    [JsonSerializable(typeof(OKXSocketUpdate<OKXAccountBalance[]>))]
    [JsonSerializable(typeof(OKXSocketUpdate<OKXDepositUpdate[]>))]
    [JsonSerializable(typeof(OKXSocketUpdate<OKXWithdrawalUpdate[]>))]
    [JsonSerializable(typeof(OKXSocketUpdate<OKXTicker[]>))]
    [JsonSerializable(typeof(OKXSocketUpdate<OKXInstrument[]>))]
    [JsonSerializable(typeof(OKXSocketUpdate<OKXOpenInterest[]>))]
    [JsonSerializable(typeof(OKXSocketUpdate<OKXKline[]>))]
    [JsonSerializable(typeof(OKXSocketUpdate<OKXTrade[]>))]
    [JsonSerializable(typeof(OKXSocketUpdate<OKXEstimatedPrice[]>))]
    [JsonSerializable(typeof(OKXSocketUpdate<OKXMarkPrice[]>))]
    [JsonSerializable(typeof(OKXSocketUpdate<OKXMiniKline[]>))]
    [JsonSerializable(typeof(OKXSocketUpdate<OKXLimitPrice[]>))]
    [JsonSerializable(typeof(OKXSocketUpdate<OKXOptionSummary[]>))]
    [JsonSerializable(typeof(OKXSocketUpdate<OKXFundingRate[]>))]
    [JsonSerializable(typeof(OKXSocketUpdate<OKXIndexTicker[]>))]
    [JsonSerializable(typeof(OKXSocketUpdate<OKXStatus[]>))]
    [JsonSerializable(typeof(OKXSocketUpdate<OKXPosition[]>))]
    [JsonSerializable(typeof(OKXSocketUpdate<OKXOrderUpdate[]>))]
    [JsonSerializable(typeof(OKXSocketUpdate<OKXUserTradeUpdate[]>))]
    [JsonSerializable(typeof(OKXSocketUpdate<OKXAlgoOrderUpdate[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXSettlementPrice[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXSettlementInfo[]>))]

    // End manual defined attributes

    [JsonSerializable(typeof(OKXSocketResponse<OKXOrderPlaceResponse[]>))]
    [JsonSerializable(typeof(OKXSocketResponse<OKXOrderCancelResponse[]>))]
    [JsonSerializable(typeof(OKXSocketResponse<OKXOrderAmendResponse[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<string[][]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXPosition[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXClosingPosition[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXPositionRisk[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXAccountBill[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXLeverage[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXMaximumAmount[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXMaximumAvailableAmount[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXMarginAmount[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXMaximumLoanAmount[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXInterestAccrued[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXInterestRate[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXAccountInterestRate[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXWithdrawalAmount[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXAsset[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXFundingBalance[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXFundingBill[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXLightningDeposit[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXDepositAddress[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXDepositHistory[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXWithdrawalHistory[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXSavingBalance[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXDustConvertEntry[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXBorrowRepayEntry[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXInstrument[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXTicker[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXIndexTicker[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXOrderBook[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXKline[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXTrade[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXBlockTicker[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXBlockTrade[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXInstrument[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXDeliveryExerciseHistory[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXOpenInterest[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXFundingRate[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXFundingRateHistory[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXOptionSummary[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXDiscountInfo[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXMarkPrice[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXPositionTier[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXVipInterestRate[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXTakerVolume[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXRatio[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXInterestVolume[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXPutCallRatio[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXInterestVolumeExpiry[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXInterestVolumeStrike[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXAnnouncementType[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXSubAccount[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXSubAccountFundingBalance[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXSubAccountBill[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXOrderAmendResponse[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXOrder[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXTransaction[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXAlgoOrder[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXAccountBalance[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXAccountConfiguration[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXAccountPositionMode[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXFeeRate[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXAccountGreeksType[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXTransferResponse[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXWithdrawalResponse[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXLightningWithdrawal[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXWithdrawalId[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXSavingActionResponse[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXDustAssets[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXAccountIsolatedMarginMode[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXTransferInfo[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXPresetAccountMode[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXAccountSwitchCheckResult[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXAccountMode[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXInviteeDetails[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXAssetValuation[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXBorrowRepayResult[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXAutoRepayStatus[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKX24HourVolume[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXLimitPrice[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXEstimatedPrice[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXTime[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXInsuranceFund[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXUnitConvert[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXAnnouncementsPage[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXSubAccountApiKey[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXSubAccountTransfer[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXOrderCancelResponse[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXCancelAllAfterResponse[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXClosePositionResponse[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXAlgoOrderResponse[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXAlgoOrderAmendResponse[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXOrderPlaceResponse[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXCheckOrderResponse[]>))]
    [JsonSerializable(typeof(OKXSocketUpdate<OKXOrderBook[]>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXIndexComponents>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXSupportCoins>))]
    [JsonSerializable(typeof(OKXRestApiResponse<OKXTakerFlow>))]
    [JsonSerializable(typeof(IDictionary<string, object>))]
    [JsonSerializable(typeof(OKXMiniKline[]))]
    [JsonSerializable(typeof(OKXAccountBalanceDetail[]))]
    [JsonSerializable(typeof(OKXAccountSwitchUnmatched[]))]
    [JsonSerializable(typeof(OKXAccountSwitchPosTier[]))]
    [JsonSerializable(typeof(OKXAccountSwitchMargin[]))]
    [JsonSerializable(typeof(OKXAccountSwitchPosition[]))]
    [JsonSerializable(typeof(OKXAssetValuationDetails[]))]
    [JsonSerializable(typeof(OKXDustAsset[]))]
    [JsonSerializable(typeof(OKXFiatFee[]))]
    [JsonSerializable(typeof(OKXPositionCloseOrder[]))]
    [JsonSerializable(typeof(OKXPositionAndBalanceUpdate[]))]
    [JsonSerializable(typeof(OKXBalanceUpdate[]))]
    [JsonSerializable(typeof(OKXAccountPositionUpdate[]))]
    [JsonSerializable(typeof(OKXTradeReference[]))]
    [JsonSerializable(typeof(OKXAccountPositionRiskBalanceData[]))]
    [JsonSerializable(typeof(OKXAccountPositionRiskPositionData[]))]
    [JsonSerializable(typeof(OKXRestApiResponse[]))]
    [JsonSerializable(typeof(OKXDepositUpdate[]))]
    [JsonSerializable(typeof(OKXWithdrawalUpdate[]))]
    [JsonSerializable(typeof(OKXIndexComponents[]))]
    [JsonSerializable(typeof(OKXIndexComponent[]))]
    [JsonSerializable(typeof(OKXOrderBookRow[]))]
    [JsonSerializable(typeof(OKXAnnouncement[]))]
    [JsonSerializable(typeof(OKXPublicDeliveryExerciseHistoryDetail[]))]
    [JsonSerializable(typeof(OKXPublicDiscountInfoDetail[]))]
    [JsonSerializable(typeof(OKXPublicDiscountDetails[]))]
    [JsonSerializable(typeof(OKXInsuranceFundDetail[]))]
    [JsonSerializable(typeof(OKXPublicInterestRateBasic[]))]
    [JsonSerializable(typeof(OKXPublicInterestRateVip[]))]
    [JsonSerializable(typeof(OKXPublicInterestRateRegular[]))]
    [JsonSerializable(typeof(OKXLiquidationInfo[]))]
    [JsonSerializable(typeof(OKXPublicLiquidationInfoDetail[]))]
    [JsonSerializable(typeof(OKXVipInterestRateLevel[]))]
    [JsonSerializable(typeof(OKXSubAccountName[]))]
    [JsonSerializable(typeof(OKXStatus[]))]
    [JsonSerializable(typeof(OKXAlgoOrderRequest[]))]
    [JsonSerializable(typeof(OKXAlgoOrderUpdate[]))]
    [JsonSerializable(typeof(OKXAttachedAlgoOrder[]))]
    [JsonSerializable(typeof(OKXOrderAmendRequest[]))]
    [JsonSerializable(typeof(OKXOrderCancelRequest[]))]
    [JsonSerializable(typeof(OKXOrderPlaceRequest[]))]
    [JsonSerializable(typeof(OKXOrderUpdate[]))]
    [JsonSerializable(typeof(OKXUserTradeUpdate[]))]
    [JsonSerializable(typeof(OKXSupportCoins[]))]
    [JsonSerializable(typeof(OKXTakerFlow[]))]
    [JsonSerializable(typeof(OKXSocketIdRequest))]
    [JsonSerializable(typeof(OKXSocketClientUnifiedApiTrading))]
    [JsonSerializable(typeof(OKXSocketResponse))]
    [JsonSerializable(typeof(OKXSocketRequest))]
    [JsonSerializable(typeof(OKXSocketAuthRequest))]
    [JsonSerializable(typeof(int?))]
    [JsonSerializable(typeof(int))]
    [JsonSerializable(typeof(long?))]
    [JsonSerializable(typeof(long))]
    [JsonSerializable(typeof(decimal?))]
    [JsonSerializable(typeof(decimal))]
    [JsonSerializable(typeof(DateTime))]
    [JsonSerializable(typeof(DateTime?))]
    internal partial class OKXSourceGenerationContext : JsonSerializerContext
    {
    }
}
