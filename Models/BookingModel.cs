using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.Models
{
    public class BookingModel
    {
        private string id;
        private string firstname;
        private string lastname;
        private string totalprice;
        private bool depositpaid = false;
        private string checkin;
        private string checkout;
        public void SetCheckin(string checkin_value) { checkin = checkin_value; }
        public string GetCheckin() { return checkin; }
        public void SetCheckout(string checkout_value) { checkout = checkout_value; }
        public string GetCheckout() { return checkout; }
        public void SetId(int id_value) { id = id_value.ToString(); }
        public int GetId() { return Convert.ToInt32(id); }
        public void SetFirstname(string firstname_value) { firstname = firstname_value; }
        public string GetFirstname() { return firstname; }
        public void SetLastname(string lastname_value) { lastname = lastname_value; }
        public string GetLastname() { return lastname; }
        public void SetTotalprice(string totalprice_value) { totalprice = totalprice_value; }
        public string GetTotalprice() { return totalprice; }
        public bool GetDepositpaid() { return depositpaid; }
        public void SetDepositpaid(bool value) { depositpaid = value; }
        public BookingModel()
        {
            id = 0.ToString();
            firstname = GenerateRandomString();
            lastname = GenerateRandomString();
            totalprice = GenerateRandomPrice();
        }
        public BookingModel(int id_value)
        {
            id = id_value.ToString();
            firstname = GenerateRandomString();
            lastname = GenerateRandomString();
            totalprice = GenerateRandomPrice();
        }
        public BookingModel(string firstname, string lastname, string totalprice, bool depositpaid, string checkin, string checkout)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.totalprice = totalprice;
            this.depositpaid = depositpaid;
            this.checkin = checkin;
            this.checkout = checkout;
        }
        private string GenerateRandomString()
        {
            // до 8
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, 8)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private string GenerateRandomPrice()
        {
            // між 100 і 1000
            Random random = new Random();
            return random.Next(100, 1000).ToString();
        }
    }
}
