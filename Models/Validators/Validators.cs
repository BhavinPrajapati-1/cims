using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIMS.Models.Validators
{
    public class Validators
    {

        #region ValidationMethods
        public bool BeAString(string textValue)
        {
            if (string.IsNullOrEmpty(textValue)) return false;
            textValue = textValue.Replace(" ", "");
            textValue = textValue.Replace("-", "");
            return textValue.All(Char.IsLetter);
        }

        #endregion


        #region ValidationMessage
        public string InvalidString
        {
            get
            {
                return " contains invalid characters.";
            }
        }

        #endregion

    }
}
