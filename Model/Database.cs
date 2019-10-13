
namespace CIMS.Model
{
    public class Database
    {
        public int ID { get; set; }
        public string DateSent { get; set; }
        public int User_ID { get; set; }
        public int Recipient { get; set; }
        public string EmailContent { get; set; }
        public string DBLastSaved { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public string UserName { get; set; }
        public string Headers
        {
            get
            {
                return "DateSent,User_ID,Recipient,EmailContent,DBLastSaved,Status,Notes,";
            }
        }
    }
}
