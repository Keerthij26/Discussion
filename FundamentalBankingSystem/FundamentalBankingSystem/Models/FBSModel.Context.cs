﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FundamentalBankingSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class FBSEntities : DbContext
    {
        public FBSEntities()
            : base("name=FBSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_Login_details> tbl_Login_details { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<tbl_Customer_Details> tbl_Customer_Details { get; set; }
        public virtual DbSet<tbl_Customer_Account_Details> tbl_Customer_Account_Details { get; set; }
        public virtual DbSet<tbl_Account_Types> tbl_Account_Types { get; set; }
        public virtual DbSet<tbl_TransactionDetails> tbl_TransactionDetails { get; set; }
    
        public virtual ObjectResult<Nullable<int>> sp_checkLogin(string password)
        {
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_checkLogin", passwordParameter);
        }
    
        public virtual ObjectResult<sp_getstates_Result> sp_getstates()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getstates_Result>("sp_getstates");
        }
    
        public virtual int sp_InsertCustomerDetails(string name, Nullable<long> ssn, Nullable<System.DateTime> dob, string address1, string address2, Nullable<int> state, Nullable<int> city)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var ssnParameter = ssn.HasValue ?
                new ObjectParameter("ssn", ssn) :
                new ObjectParameter("ssn", typeof(long));
    
            var dobParameter = dob.HasValue ?
                new ObjectParameter("dob", dob) :
                new ObjectParameter("dob", typeof(System.DateTime));
    
            var address1Parameter = address1 != null ?
                new ObjectParameter("address1", address1) :
                new ObjectParameter("address1", typeof(string));
    
            var address2Parameter = address2 != null ?
                new ObjectParameter("address2", address2) :
                new ObjectParameter("address2", typeof(string));
    
            var stateParameter = state.HasValue ?
                new ObjectParameter("state", state) :
                new ObjectParameter("state", typeof(int));
    
            var cityParameter = city.HasValue ?
                new ObjectParameter("city", city) :
                new ObjectParameter("city", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertCustomerDetails", nameParameter, ssnParameter, dobParameter, address1Parameter, address2Parameter, stateParameter, cityParameter);
        }
    
        public virtual ObjectResult<sp_ViewCustomers_Result> sp_ViewCustomers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ViewCustomers_Result>("sp_ViewCustomers");
        }
    
        public virtual ObjectResult<sp_getcities_Result> sp_getcities(Nullable<int> stateid)
        {
            var stateidParameter = stateid.HasValue ?
                new ObjectParameter("stateid", stateid) :
                new ObjectParameter("stateid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getcities_Result>("sp_getcities", stateidParameter);
        }
    
        public virtual int sp_UpdateCustomerDetails(Nullable<long> id, string name, Nullable<long> ssn, Nullable<System.DateTime> dob, string address1, string address2, Nullable<int> state, Nullable<int> city)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(long));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var ssnParameter = ssn.HasValue ?
                new ObjectParameter("ssn", ssn) :
                new ObjectParameter("ssn", typeof(long));
    
            var dobParameter = dob.HasValue ?
                new ObjectParameter("dob", dob) :
                new ObjectParameter("dob", typeof(System.DateTime));
    
            var address1Parameter = address1 != null ?
                new ObjectParameter("address1", address1) :
                new ObjectParameter("address1", typeof(string));
    
            var address2Parameter = address2 != null ?
                new ObjectParameter("address2", address2) :
                new ObjectParameter("address2", typeof(string));
    
            var stateParameter = state.HasValue ?
                new ObjectParameter("state", state) :
                new ObjectParameter("state", typeof(int));
    
            var cityParameter = city.HasValue ?
                new ObjectParameter("city", city) :
                new ObjectParameter("city", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_UpdateCustomerDetails", idParameter, nameParameter, ssnParameter, dobParameter, address1Parameter, address2Parameter, stateParameter, cityParameter);
        }
    
        public virtual ObjectResult<sp_ViewCustomersByID_Result> sp_ViewCustomersByID(Nullable<long> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ViewCustomersByID_Result>("sp_ViewCustomersByID", idParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_DeleteAccount(string acctnumber, Nullable<decimal> balance)
        {
            var acctnumberParameter = acctnumber != null ?
                new ObjectParameter("acctnumber", acctnumber) :
                new ObjectParameter("acctnumber", typeof(string));
    
            var balanceParameter = balance.HasValue ?
                new ObjectParameter("balance", balance) :
                new ObjectParameter("balance", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_DeleteAccount", acctnumberParameter, balanceParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_InsertAccountDetails(Nullable<long> custid, string accountnumber, Nullable<int> accounttypeid, Nullable<decimal> balance)
        {
            var custidParameter = custid.HasValue ?
                new ObjectParameter("custid", custid) :
                new ObjectParameter("custid", typeof(long));
    
            var accountnumberParameter = accountnumber != null ?
                new ObjectParameter("accountnumber", accountnumber) :
                new ObjectParameter("accountnumber", typeof(string));
    
            var accounttypeidParameter = accounttypeid.HasValue ?
                new ObjectParameter("accounttypeid", accounttypeid) :
                new ObjectParameter("accounttypeid", typeof(int));
    
            var balanceParameter = balance.HasValue ?
                new ObjectParameter("balance", balance) :
                new ObjectParameter("balance", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_InsertAccountDetails", custidParameter, accountnumberParameter, accounttypeidParameter, balanceParameter);
        }
    
        public virtual ObjectResult<sp_ViewAccounts_Result> sp_ViewAccounts()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ViewAccounts_Result>("sp_ViewAccounts");
        }
    
        public virtual ObjectResult<Nullable<int>> sp_DeleteCustomerByID(Nullable<long> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_DeleteCustomerByID", idParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_getAccountsofCustomer(Nullable<long> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_getAccountsofCustomer", idParameter);
        }
    
        public virtual ObjectResult<sp_SearchAccount_Result> sp_SearchAccount(Nullable<int> option, Nullable<long> custid, string acctno)
        {
            var optionParameter = option.HasValue ?
                new ObjectParameter("option", option) :
                new ObjectParameter("option", typeof(int));
    
            var custidParameter = custid.HasValue ?
                new ObjectParameter("custid", custid) :
                new ObjectParameter("custid", typeof(long));
    
            var acctnoParameter = acctno != null ?
                new ObjectParameter("acctno", acctno) :
                new ObjectParameter("acctno", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_SearchAccount_Result>("sp_SearchAccount", optionParameter, custidParameter, acctnoParameter);
        }
    
        public virtual ObjectResult<sp_ViewAccountsByID_Result> sp_ViewAccountsByID(string acctnumber)
        {
            var acctnumberParameter = acctnumber != null ?
                new ObjectParameter("acctnumber", acctnumber) :
                new ObjectParameter("acctnumber", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ViewAccountsByID_Result>("sp_ViewAccountsByID", acctnumberParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_DepositandWithdraw(string accountNumber, string type, Nullable<decimal> balance)
        {
            var accountNumberParameter = accountNumber != null ?
                new ObjectParameter("accountNumber", accountNumber) :
                new ObjectParameter("accountNumber", typeof(string));
    
            var typeParameter = type != null ?
                new ObjectParameter("type", type) :
                new ObjectParameter("type", typeof(string));
    
            var balanceParameter = balance.HasValue ?
                new ObjectParameter("balance", balance) :
                new ObjectParameter("balance", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_DepositandWithdraw", accountNumberParameter, typeParameter, balanceParameter);
        }
    
        public virtual ObjectResult<sp_MiniStatement_Result> sp_MiniStatement(string search, Nullable<System.DateTime> startdate, Nullable<System.DateTime> enddate, Nullable<int> transactioncnt, string selected)
        {
            var searchParameter = search != null ?
                new ObjectParameter("search", search) :
                new ObjectParameter("search", typeof(string));
    
            var startdateParameter = startdate.HasValue ?
                new ObjectParameter("startdate", startdate) :
                new ObjectParameter("startdate", typeof(System.DateTime));
    
            var enddateParameter = enddate.HasValue ?
                new ObjectParameter("enddate", enddate) :
                new ObjectParameter("enddate", typeof(System.DateTime));
    
            var transactioncntParameter = transactioncnt.HasValue ?
                new ObjectParameter("transactioncnt", transactioncnt) :
                new ObjectParameter("transactioncnt", typeof(int));
    
            var selectedParameter = selected != null ?
                new ObjectParameter("selected", selected) :
                new ObjectParameter("selected", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_MiniStatement_Result>("sp_MiniStatement", searchParameter, startdateParameter, enddateParameter, transactioncntParameter, selectedParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_Transfer(string srcacctnum, string destacctnum, Nullable<decimal> balance, string type)
        {
            var srcacctnumParameter = srcacctnum != null ?
                new ObjectParameter("srcacctnum", srcacctnum) :
                new ObjectParameter("srcacctnum", typeof(string));
    
            var destacctnumParameter = destacctnum != null ?
                new ObjectParameter("destacctnum", destacctnum) :
                new ObjectParameter("destacctnum", typeof(string));
    
            var balanceParameter = balance.HasValue ?
                new ObjectParameter("balance", balance) :
                new ObjectParameter("balance", typeof(decimal));
    
            var typeParameter = type != null ?
                new ObjectParameter("type", type) :
                new ObjectParameter("type", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_Transfer", srcacctnumParameter, destacctnumParameter, balanceParameter, typeParameter);
        }
    
        public virtual ObjectResult<sp_SearchCustomer_Result> sp_SearchCustomer(Nullable<int> option, Nullable<long> custid, Nullable<long> ssn)
        {
            var optionParameter = option.HasValue ?
                new ObjectParameter("option", option) :
                new ObjectParameter("option", typeof(int));
    
            var custidParameter = custid.HasValue ?
                new ObjectParameter("custid", custid) :
                new ObjectParameter("custid", typeof(long));
    
            var ssnParameter = ssn.HasValue ?
                new ObjectParameter("ssn", ssn) :
                new ObjectParameter("ssn", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_SearchCustomer_Result>("sp_SearchCustomer", optionParameter, custidParameter, ssnParameter);
        }
    
        public virtual ObjectResult<sp_ViewCustomersForDeleteByID_Result> sp_ViewCustomersForDeleteByID(Nullable<long> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ViewCustomersForDeleteByID_Result>("sp_ViewCustomersForDeleteByID", idParameter);
        }
    }
}
