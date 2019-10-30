using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIMS.Models.Validators
{
    public class InventoryValidator : AbstractValidator<InventoryModel>
    {
        private readonly Validators v = new Validators();
        public InventoryValidator()
        {

        }
    }
}
