using System;
using hw3part1.Utility;
using System.Net.Mail;

namespace hw3part1.Model
{
    public class CustNotify
    {
        public static void Notify(Cart cart)
        {
            string customerEmail = cart.CustomerEmail;

            if (!string.IsNullOrEmpty(customerEmail))
            {
                using (var message = new MailMessage("orders@somewhere.com", customerEmail))
                using (var client = new SmtpClient("localhost"))
                {
                    message.Subject = "Your order placed on " + DateTime.Now.ToString();
                    message.Body = "Your order details: \n " + cart.ToString();

                    try
                    {
                        client.Send(message);
                    }
                    catch (Exception ex)
                    {
                        Logger.Error("Problem sending notification email", ex);
                    }
                }
            }
        }

        public static void IfNotify(Cart cart, bool notifyCustomer)
        {
            if (notifyCustomer)
            {
               Notify(cart);
            }
        }
}
}
