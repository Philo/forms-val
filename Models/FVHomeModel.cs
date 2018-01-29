using System;
using System.ComponentModel.DataAnnotations;
using FluentValidation.Attributes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace forms_val.Models
{
    [Validator(typeof(HomeModelValidator))]
    public class FVHomeModel 
    {
        //[Required]
        [Display(Name = "Required String")]
        public string RequiredString {get;set;}
        
        //[StringLength(10, MinimumLength = 5)]
        [Display(Name = "String with min and max length")]
        public string StringMinMaxLength {get;set;}

        [DataType(DataType.EmailAddress)]
        //[EmailAddress]
        [Display(Name = "Email address")]
        public string EmailAddress {get;set;}

        [DataType(DataType.Text)]
        //[RegularExpression("[a-z]+")]
        [Display(Name = "Regular Expression")]
        public string RegularExpression {get;set;}

        [DataType(DataType.CreditCard)]
        //[CreditCard]
        [Display(Name = "Credit card (I've never used this)")]
        public string CreditCard {get;set;}

        //[Range(5, 10)]
        [Display(Name = "Optional Range Numeric")]
        public int? OptionalRangeNumeric {get;set;}
        
        //[Required]
        [Display(Name = "Required Numeric")]
        public int RequiredNumeric {get;set;}
        
        [DataType(DataType.Date)]
        [Display(Name = "Date Only")]
        public DateTime Date {get;set;}

        [DataType(DataType.DateTime)]
        [Display(Name = "Date and Time")]
        public DateTime DateTime {get;set;}

        [DataType(DataType.Time)]
        [Display(Name = "Time Only")]
        public TimeSpan Time {get;set;}        

        [DataType(DataType.Url)]
        //[CreditCard]
        [Display(Name = "Url")]
        public Uri Url {get;set;}

        [DataType(DataType.Currency)]
        [Display(Name = "Currency")]
        public decimal Currency {get;set;}

        [DataType(DataType.Upload)]
        [Display(Name = "Upload")]
        //[Required]
        public IFormFile Upload {get;set;}

        [DataType(DataType.Text)]
        [Remote("IsUnique", "Home", HttpMethod = "POST", AdditionalFields = "EmailAddress")]
        [Display(Name = "Remote validation (Is email that ends with \"@stormid.com\")")]
        public string Remote {get;set;}


        public string Password { get; set; }

        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}