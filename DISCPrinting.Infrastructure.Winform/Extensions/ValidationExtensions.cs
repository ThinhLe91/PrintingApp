using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISCPrinting.Infrastructure.Winform.Extensions;

public static class ValidationExtensions
{
    public static void ApplyValidationErrors(this ErrorProvider errorProvider, ValidationResult result, Control parent)
    {
        //errorProvider.Clear();
        //foreach (var error in result.Errors)
        //{
        //    var control = parent.Controls.Find("txt" + error.PropertyName, true).FirstOrDefault()
        //               ?? parent.Controls.Find("cbo" + error.PropertyName, true).FirstOrDefault();

        //    if (control != null)
        //    {
        //        errorProvider.SetError(control, error.ErrorMessage);
        //    }
        //}
    }
}
