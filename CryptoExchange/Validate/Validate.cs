using Guna.UI2.WinForms.Internal;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace CryptoExchange.ValidateUser
{
    public class Validate
    {
        public bool ValidateRegistrationUser(string lastname, string firstname, string middlename, string login, string password, string passwordRepeat)
        {
            var MinPassword = new Regex(".{6,12}");
            if (string.IsNullOrWhiteSpace(lastname)
                || string.IsNullOrWhiteSpace(firstname)
                || string.IsNullOrWhiteSpace(login)
                || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Не все поля заполнены");
                return false;
            }
            if (password != passwordRepeat)
            {
                MessageBox.Show("Пароли не совпадают");
                return false;
            }
            if (!MinPassword.IsMatch(password))
            {
                MessageBox.Show("Длина пароля должна составлять от 6 до 12 символов");
                return false;
            }
            return true;
        }
        public bool ValidateCard(string CVV, string NumberCard, string LastNameUser, string ActionCard, UserControl usercontrol)
        {
            Regex numberCard = new Regex(@"^\d{16}$");
            Regex TypeCVV = new Regex(@".[0-9]");
            if (usercontrol.Visible)
            {
                if (string.IsNullOrWhiteSpace(CVV)
                    || string.IsNullOrWhiteSpace(NumberCard)
                    || string.IsNullOrWhiteSpace(LastNameUser)
                    || string.IsNullOrWhiteSpace(ActionCard))
                {
                    MessageBox.Show("Заполните все поля");
                    return false;
                }
                if(!numberCard.IsMatch(NumberCard))
                {
                    MessageBox.Show("Номер карты должен состоять из 16 цифр");
                    return false;
                }
                if(!TypeCVV.IsMatch(CVV))
                {
                    MessageBox.Show("CVV должен состоять из 3 цифр");
                    return false;
                }
            }
            return true;
        }
    }
}
