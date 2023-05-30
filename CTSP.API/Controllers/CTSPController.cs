using CTSP.API.Data;
using CTSP.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Reflection.Emit;

namespace CTSP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CTSPController : ControllerBase
    {
        private readonly CTSPRecruiterContext _context;

        public CTSPController(CTSPRecruiterContext context)
        {
            _context = context;
        }

        [HttpGet("Country")]
        public async Task<IActionResult> SPR_CountryAsync(byte? opcode, short? CountryID, string? Country)
        {
            try
            {
                var result = await _context.GetProcedures().SPR_CountryAsync(opcode, CountryID, Country);
                return Ok(result);
            }
            catch (SqlException ex) when (ex.Message.Contains("Error:"))
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        [HttpGet("Province")]
        public async Task<IActionResult> SPR_ProvinceAsync(byte? opcode, short? ProvinceID, string? Province, short? CountryID, short? Search_CID)
        {
            try
            {
                var result = await _context.GetProcedures().SPR_ProvinceAsync(opcode, ProvinceID, Province, CountryID,Search_CID);
                return Ok(result);
            }
            catch (SqlException ex) when (ex.Message.Contains("Error:"))
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("GetProvince")]
        public async Task<IActionResult> SPR_DropDownsAsync(byte? opcode, long? UserID, string WhereID, long? PostsID)
        {
            try
            {
                var result = await _context.GetProcedures().SPR_DropDownsAsync(opcode, UserID,WhereID,PostsID);
                return Ok(result);
            }
            catch (SqlException ex) when (ex.Message.Contains("Error:"))
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        } 
        
        [HttpGet("GetDivision")]
        public async Task<IActionResult> SPR_DivisionAsync(byte? opcode, short? DivisionID, string? Division, short? ProvinceID, short? Search_ProvinceID)
        {
            try
            {
                var result = await _context.GetProcedures().SPR_DivisionAsync(opcode,DivisionID,Division,ProvinceID,Search_ProvinceID);
                return Ok(result);
            }
            catch (SqlException ex) when (ex.Message.Contains("Error:"))
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("GetDistrict")]
        public async Task<IActionResult> SPR_DistrictAsync(byte? Opcode, short? DistrictID, string? District, short? DivisionID, short? Search_DivID)
        {
            try
            {
                var result = await _context.GetProcedures().SPR_DistrictAsync(Opcode,DistrictID,District,DivisionID,Search_DivID);
                return Ok(result);
            }
            catch (SqlException ex) when (ex.Message.Contains("Error:"))
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        
        [HttpGet("GetTehsil")]
        public async Task<IActionResult> SPR_TehsilAsync(byte? opcode, short? TehsilID, string? Tehsil, short? DistrictID, short? Search_DistID)
        {
            try
            {
                var result = await _context.GetProcedures().SPR_TehsilAsync(opcode,TehsilID,Tehsil,DistrictID, Search_DistID);
                return Ok(result);
            }
            catch (SqlException ex) when (ex.Message.Contains("Error:"))
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        } 
        [HttpGet("GetUC")]
        public async Task<IActionResult> SPR_UCAsync(byte? opcode, short? UCID, string? UCName, short? TehsilID, short? Search_TehsilID)
        {
            try
            {
                //GetProcedure
                //test
                var result = await _context.GetProcedures().SPR_UCAsync(opcode,UCID,UCName,TehsilID,Search_TehsilID);
                return Ok(result);
            }
            catch (SqlException ex) when (ex.Message.Contains("Error:"))
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}
