namespace MQSCarDocFrontend.Banco
{
    class Conection
    {
        private static string server = @"DESKTOP-VF9QGB6\SQLEXPRESS";
        private static string database = "mqscardoc";
        private static string user = "sa";
        private static string password = "";

        public static string StrCon
        {
            get
            {
                return "Data Source="+server + "; Integrated Security=False; Initial Catalog="+database + "User ID="+ user +"; Password=" + password;
            }
        }
    }
}
