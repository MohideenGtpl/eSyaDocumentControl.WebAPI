using HCP.DocumentControl.DL.Repository;
using HCP.DocumentControl.DO;
using HCP.DocumentControl.IF;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HCP.DocumentControl.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DocumentControlController : ControllerBase
    {
        private readonly IDocumentControlRepository _DocumentControlRepository;

        public DocumentControlController(IDocumentControlRepository DocumentControlRepository)
        {
            _DocumentControlRepository = DocumentControlRepository;
        }

        #region Document Related Methods
        
        /// <summary>
        /// Getting Active Documents for drop down.
        /// UI Reffered - Document Link 
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetActiveDocuments()
        {
            var docs = await _DocumentControlRepository.GetActiveDocuments();
            return Ok(docs);
        }

        #region Document Control Normal Mode 
        /// <summary>
        /// Getting Document Control Normal Mode  List.
        /// UI Reffered - Document Control Normal Mode  Grid
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetDocumentControlNormalModebyBusinessKey(int businesskey)
        {
            var n_modes = await _DocumentControlRepository.GetDocumentControlNormalModebyBusinessKey(businesskey);
            return Ok(n_modes);
        }
        /// <summary>
        /// Insert Document Control Normal Mode.
        /// UI Reffered -Document Control Normal Mode
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> InsertDocumentControlNormalMode(DO_DocumentControlNormalMode obj)
        {
            var msg = await _DocumentControlRepository.InsertDocumentControlNormalMode(obj);
            return Ok(msg);

        }
        /// <summary>
        /// Update  Document Control Normal Mode
        /// UI Reffered - Document Control Normal Mode
        [HttpPost]
        public async Task<IActionResult> UpdateDocumentControlNormalMode(DO_DocumentControlNormalMode obj)
        {
            var msg = await _DocumentControlRepository.UpdateDocumentControlNormalMode(obj);
            return Ok(msg);

        }

        /// <summary>
        /// Active Or De Active Document Control Normal Mode
        /// UI Reffered - Document Control Normal Mode
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> ActiveOrDeActiveDocumentControlNormalMode(DO_DocumentControlNormalMode obj)
        {
            var msg = await _DocumentControlRepository.ActiveOrDeActiveDocumentControlNormalMode(obj);
            return Ok(msg);
        }
        #endregion Document Control Normal Mode 

        #region Document Control Transaction Mode
        /// <summary>
        /// Getting Document Control Transaction Mode List.
        /// UI Reffered - Document Control Transaction Mode Grid
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetDocumentControlTransactionModebyBusinessKey(int businesskey)
        {
            var _tmodes = await _DocumentControlRepository.GetDocumentControlTransactionModebyBusinessKey(businesskey);
            return Ok(_tmodes);
        }
        /// <summary>
        /// Insert Document Control Transaction Mode
        /// UI Reffered -Document Control Transaction Mode
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> InsertDocumentControlTransactionMode(DO_DocumentControlTransaction obj)
        {
            var msg = await _DocumentControlRepository.InsertDocumentControlTransactionMode(obj);
            return Ok(msg);

        }
        /// <summary>
        /// Update Document Control Transaction Mode
        /// UI Reffered -Document Control Transaction Mode
        [HttpPost]
        public async Task<IActionResult> UpdateDocumentControlTransactionMode(DO_DocumentControlTransaction obj)
        {
            var msg = await _DocumentControlRepository.UpdateDocumentControlTransactionMode(obj);
            return Ok(msg);

        }

        /// <summary>
        /// Active Or De Active Document Control Transaction Mode
        /// UI Reffered - Document Control Transaction Mode
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> ActiveOrDeActiveDocumentControlTransactionMode(DO_DocumentControlTransaction obj)
        {
            var msg = await _DocumentControlRepository.ActiveOrDeActiveDocumentControlTransactionMode(obj);
            return Ok(msg);
        }
        #endregion Document Control Transaction Mode

        #endregion

        #region Voucher Related Methods
       
        /// <summary>
        /// Getting Active Payments for drop down.
        /// UI Reffered - Voucher Link 
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetActivePaymentModes()
        {
            var _methods = await _DocumentControlRepository.GetActivePaymentModes();
            return Ok(_methods);
        }

        /// <summary>
        /// Getting Active Vouchers for drop down.
        /// UI Reffered - Voucher Link 
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetActiveVouchers()
        {
            var _vouchers = await _DocumentControlRepository.GetActiveVouchers();
            return Ok(_vouchers);
        }

       
        #region Voucher Generation
        /// <summary>
        /// Getting Voucher Generation List.
        /// UI Reffered - Voucher Generation Grid
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetVoucherGenerationsbyBusinesskey(int businesskey)
        {
            var _vgen = await _DocumentControlRepository.GetVoucherGenerationsbyBusinesskey(businesskey);
            return Ok(_vgen);
        }
        /// <summary>
        /// Insert Voucher Generation.
        /// UI Reffered -Voucher Generation
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> InsertIntoVoucherGeneration(DO_VoucherGeneration obj)
        {
            var msg = await _DocumentControlRepository.InsertIntoVoucherGeneration(obj);
            return Ok(msg);

        }
        /// <summary>
        /// Update Voucher Generation.
        /// UI Reffered -Voucher Generation
        [HttpPost]
        public async Task<IActionResult> UpdateVoucherGeneration(DO_VoucherGeneration obj)
        {
            var msg = await _DocumentControlRepository.UpdateVoucherGeneration(obj);
            return Ok(msg);

        }

        /// <summary>
        /// Active Or De Active Voucher Generation
        /// UI Reffered - Voucher Generation
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> ActiveOrDeActiveVoucherGeneration(DO_VoucherGeneration obj)
        {
            var msg = await _DocumentControlRepository.ActiveOrDeActiveVoucherGeneration(obj);
            return Ok(msg);
        }
        #endregion Voucher Generation


        #endregion

    }
}