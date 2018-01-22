using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Master.MVC.Validation {
    public class RegionAttribute : ValidationAttribute
    {
        #region Overrides of ValidationAttribute

        public override string FormatErrorMessage(string name)
        {
            return $"Should be {name} value between 1 and 7";
        }

        public override bool IsValid(object value)
        {
            return Regex.IsMatch(value.ToString(), @"^[1-7]$");
        }

        #endregion
    }
}