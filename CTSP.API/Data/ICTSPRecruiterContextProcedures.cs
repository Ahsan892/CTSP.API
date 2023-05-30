﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using CTSP.API.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Emit;
using System.Threading;
using System.Threading.Tasks;

namespace CTSP.API.Data
{
    public partial interface ICTSPRecruiterContextProcedures
    {
        Task<List<Spr_AcademicResult>> Spr_AcademicAsync(byte? opcode, byte? isRedirect, short? TypeID, long? UserAID, long? UserID, string IQuery, string DQuery, string UQuery, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SPR_AcceptedRejectedListResult>> SPR_AcceptedRejectedListAsync(string WhereID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SPR_AreaResult>> SPR_AreaAsync(byte? opcode, int? WhereID, int? WhereID2, int? SelValID, string UCCode, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<Spr_CertificateResult>> Spr_CertificateAsync(byte? opcode, short? CertificateID, string Certificate, bool? TypeID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SPR_CityResult>> SPR_CityAsync(byte? opcode, short? CityID, string City, short? UCID, short? Search_UCID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SPR_CountryResult>> SPR_CountryAsync(byte? opcode, short? CountryID, string Country, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SPR_DashBoardResult>> SPR_DashBoardAsync(int? OpCode, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SPR_DistrictResult>> SPR_DistrictAsync(byte? opcode, short? DistrictID, string District, short? DivisionID, short? Search_DivID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SPR_DivisionResult>> SPR_DivisionAsync(byte? opcode, short? DivisionID, string Division, short? ProvinceID, short? Search_ProvinceID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SPR_DropDownsResult>> SPR_DropDownsAsync(byte? opcode, long? UserID, string WhereID, long? PostsID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<Spr_ExperienceResult>> Spr_ExperienceAsync(byte? opcode, long? ExpID, long? UserID, byte? OrgTYPEID, byte? Search_OrgTypeID, string Company, string Designation, DateTime? StartDate, DateTime? EndDate, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SPR_GetUsersinfoResult>> SPR_GetUsersinfoAsync(string CNIC, string CellNo, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SPR_JobTermsVerifyAsync(long? UserJID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SPR_LoginIssueResult>> SPR_LoginIssueAsync(long? OpCode, string CNIC, string Password, string CellNo, long? UserID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SPR_PostApplyResult>> SPR_PostApplyAsync(byte? opcode, int? WhereID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SPR_PostApply_backupResult>> SPR_PostApply_backupAsync(byte? opcode, int? WhereID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SPR_PrintDataResult>> SPR_PrintDataAsync(byte? opcode, int? UserJID, int? UserID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SPR_PrintRollnoSlipResult>> SPR_PrintRollnoSlipAsync(long? UserJID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SPR_ProvinceResult>> SPR_ProvinceAsync(byte? opcode, short? ProvinceID, string Province, short? CountryID, short? Search_CID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<Spr_QCAcademicResult>> Spr_QCAcademicAsync(short? TypeID, long? UserID, string IQuery, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SPR_QCAddQueryResult>> SPR_QCAddQueryAsync(long? UserJID, long? QUserJID, string IQuery, string Query, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SPR_QCBatchResult>> SPR_QCBatchAsync(byte? opcode, short? QBID, string Title, long? StartRange, long? endRange, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SPR_QCJobStatuUserResult>> SPR_QCJobStatuUserAsync(long? UserJID, long? VerifiedBy, string TrackingNo, string TracingNo, byte? PayMethodID, bool? JobStatusid, string Remarks, string IQuery, double? ProfMarks, double? AcadMarks, short? District, short? UCName, short? TehsilName, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SPR_QCJobStatuUser_05_04_2023Result>> SPR_QCJobStatuUser_05_04_2023Async(long? UserJID, long? VerifiedBy, string TrackingNo, string TracingNo, byte? PayMethodID, bool? JobStatusid, string Remarks, string IQuery, double? ProfMarks, double? AcadMarks, short? District, short? UCName, short? TehsilName, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SPR_QCJobStatuUser_bkResult>> SPR_QCJobStatuUser_bkAsync(long? UserJID, long? VerifiedBy, string TrackingNo, string TracingNo, byte? PayMethodID, bool? JobStatusid, string Remarks, string IQuery, double? ProfMarks, double? AcadMarks, short? District, short? UCName, short? TehsilName, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SPR_QCResultsResult>> SPR_QCResultsAsync(long? UserID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SPR_QCReviewResult>> SPR_QCReviewAsync(int? PostsID, short? Statusid, DateTime? FromDate, DateTime? ToDate, string Search, string SearchWhere, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SPR_QCReviewJobStatuUserResult>> SPR_QCReviewJobStatuUserAsync(long? UserJID, long? VerifiedBy, string TrackingNo, string TracingNo, byte? PayMethodID, bool? JobStatusid, string Remarks, string IQuery, double? ProfMarks, double? AcadMarks, short? District, short? UCName, short? TehsilName, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SPR_QcReviewStatusAsync(long? UserJID, string ReplyQuery, short? Statusid, long? Modifiedby, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SPR_QCTracingTransferAsync(byte? opcode, long? UserJID, string TracingNo, string FromTracingNo, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SPR_QCUserAsync(byte? OpCode, long? UserPID, long? UserID, byte? RelationShipID, string FHName, string FcellNo, string CNIC, string Pic, DateTime? DOB, byte? GENDerid, bool? MaritalStatus, short? CityID, short? DistrictID, short? TehsilID, bool? Religion, string OtherReligion, bool? isHafizQuran, bool? isDisable, bool? isCAgeRelax, bool? isLocked, string UserName, string UserPassword, string FullName, string CellNo, string Address, string Email, bool? StatusID, byte? RoleID, string PostalAddress, bool? isGovtEmp, DateTime? GovtDofJoin, bool? isEduDept, DateTime? EduDofJoin, string CityName, string UCName, string TehsilName, string District, string DisablitySource, bool? isRedirect, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SPR_QCUsersResult>> SPR_QCUsersAsync(byte? opcode, long? UserID, string UserName, string Password, string FullName, string CellNo, bool? StatusID, byte? ShiftID, short? QBID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SPR_QCViewSubmitResultsResult>> SPR_QCViewSubmitResultsAsync(long? UserJID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SPR_QCViewSubmitResults_backupResult>> SPR_QCViewSubmitResults_backupAsync(long? UserJID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SPR_QCViewSubmitResults_lastbackupResult>> SPR_QCViewSubmitResults_lastbackupAsync(long? UserJID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SPR_RollSlipResult>> SPR_RollSlipAsync(string WhereID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SPR_SingleLoopupAsync(byte? opcode, long? PrimaryIDVal, string PrimaryNameVal, string PrimaryID, string Field, string TableName, string SecTableName, int? IsExists, string SQL, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SPR_TbUsersProfileResult>> SPR_TbUsersProfileAsync(byte? opcode, long? UserPID, long? UserID, long? Search_UserID, byte? RelationShipID, byte? Search_RelShipID, string FHName, string FcellNo, string CNIC, string CNICFPic, string CNICBPic, string Pic, DateTime? DOB, byte? Genderid, bool? MaritalStatus, short? CityID, short? Search_CityID, bool? Religion, string OtherReligion, bool? isHafizQuran, bool? isDisable, bool? isCAgeRelax, bool? isLocked, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SPR_TehsilResult>> SPR_TehsilAsync(byte? opcode, short? TehsilID, string Tehsil, short? DistrictID, short? Search_DistID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SPR_TermsResult>> SPR_TermsAsync(byte? opcode, long? UserID, string Terms, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SPR_TermsVerifyAsync(long? UserID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SPR_twoLoopupAsync(byte? opcode, string PrimaryID, long? PrimaryIDVal, string Field1, string Field1Val, string Field2, string Field2Val, string TableName, string SecTableName, int? IsExists, string SQL, bool? isField2key, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SPR_UCResult>> SPR_UCAsync(byte? opcode, short? UCID, string UCName, short? TehsilID, short? Search_TehsilID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SPR_UpdateUsersinfoAsync(long? UserID, string Password, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SPR_UserPostingViewResult>> SPR_UserPostingViewAsync(long? OpCode, string CNIC, long? UserJID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SPR_UserregAsync(byte? OpCode, string CNIC, string UserPassword, string FullName, string CellNo, string Address, string Email, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SPR_UsersDoucmentResult>> SPR_UsersDoucmentAsync(int? opcode, long? UserID, string Attachment, byte? TypeID, string Title, string SQL, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SPR_UsersinfoResult>> SPR_UsersinfoAsync(long? opcode, byte? RoleID, long? UserID, string WhereField1, string WhereField2, string WhereField3, string WhereField4, string WhereField5, string Menu, string WhereField6, string WhereField7, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> Spr_UsersJobsAsync(byte? OpCode, long? UserJID, long? PostsID, short? District, short? UCName, short? TehsilName, long? UserID, bool? Genderid, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SPR_UserWithProfileResult>> SPR_UserWithProfileAsync(byte? OpCode, long? UserPID, long? UserID, byte? RelationShipID, string FHName, string FcellNo, string CNIC, string CNICFPic, string CNICBPic, string Pic, DateTime? DOB, byte? GENDerid, bool? MaritalStatus, short? CityID, short? DistrictID, short? TehsilID, bool? Religion, string OtherReligion, bool? isHafizQuran, bool? isDisable, bool? isCAgeRelax, bool? isLocked, string UserName, string UserPassword, string FullName, string CellNo, string Address, string Email, bool? StatusID, byte? RoleID, string PostalAddress, bool? isGovtEmp, DateTime? GovtDofJoin, bool? isEduDept, DateTime? EduDofJoin, string CityName, string UCName, string TehsilName, string District, string DisablitySource, bool? isRedirect, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SPR_UserWithProfilePicOnlyResult>> SPR_UserWithProfilePicOnlyAsync(byte? OpCode, long? UserID, string Pic, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SPR_ViewDataResult>> SPR_ViewDataAsync(byte? opcode, int? PostsID, int? UserID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SPR_ViewQCPrintDataResult>> SPR_ViewQCPrintDataAsync(byte? opcode, long? UserJID, int? UserID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
    }
}
