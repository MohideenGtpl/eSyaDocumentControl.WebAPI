using HCP.DocumentControl.DO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HCP.DocumentControl.IF
{
   public interface IDocumentControlRepository
    {
        #region Document Control Normal Mode 

        Task<List<DO_DocumentControlMaster>> GetActiveDocuments();

        Task<List<DO_DocumentControlNormalMode>> GetDocumentControlNormalModebyBusinessKey(int businesskey);

        Task<DO_ReturnParameter> InsertDocumentControlNormalMode(DO_DocumentControlNormalMode obj);

        Task<DO_ReturnParameter> UpdateDocumentControlNormalMode(DO_DocumentControlNormalMode obj);

        Task<DO_ReturnParameter> ActiveOrDeActiveDocumentControlNormalMode(DO_DocumentControlNormalMode obj);

        #endregion Document Control Normal Mode 

        #region Document Control Transaction Mode  

        Task<DO_ReturnParameter> InsertDocumentControlTransactionMode(DO_DocumentControlTransaction obj);

        Task<DO_ReturnParameter> UpdateDocumentControlTransactionMode(DO_DocumentControlTransaction obj);

        Task<List<DO_DocumentGeneration>> GetDocumentControlTransactionModebyBusinessKey(int businesskey);

        Task<DO_ReturnParameter> ActiveOrDeActiveDocumentControlTransactionMode(DO_DocumentControlTransaction obj);

        #endregion Document Control Transaction Mode

        #region Voucher Generation
        Task<List<DO_PaymentMode>> GetActivePaymentModes();

        Task<List<DO_PaymentVoucher>> GetActiveVouchers();

        Task<List<DO_VoucherGeneration>> GetVoucherGenerationsbyBusinesskey(int businesskey);

        Task<DO_ReturnParameter> InsertIntoVoucherGeneration(DO_VoucherGeneration obj);

        Task<DO_ReturnParameter> UpdateVoucherGeneration(DO_VoucherGeneration obj);

        Task<DO_ReturnParameter> ActiveOrDeActiveVoucherGeneration(DO_VoucherGeneration obj);
        #endregion Voucher Generation
    }
}
