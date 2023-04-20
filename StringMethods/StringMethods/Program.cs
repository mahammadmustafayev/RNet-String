namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] mails =
            {
                "kassandra_daniel@gmail.com",
                "eveline.morar11@yahoo.com",
                "giles_powlowski9@gmail.com",
                "glenda_armstrong@hotmail.com",
                "israel.fahey98@gmail.com",
                "annetta.rempel13@hotmail.com",
                "celine.mcdermott@gmail.com",
                "stacy.krajcik@gmail.com ",
                "jared9@gmail.com",
                "jonathan.zboncak81@hotmail.com",
                "kim.bruen64@gmail.com",
                "dayana.homenick72@gmail.com",
                "afton43@yahoo.com",
                "estell.bergstrom80@yahoo.com",
                "ramona26@hotmail.com",
                "floyd48@gmail.com",
                "stanford.gaylord1@yahoo.com",
                "rebekah_heaney91@hotmail.com",
                "lorna.vonrueden82@yahoo.com",
                "chaya79@gmail.com"
            };

            //Console.WriteLine(m.LastIndexOf('@'));
            foreach (var mail in mails)
            {
                
                int atIndex = mail.IndexOf('@');
                int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                int pointIndex = mail.IndexOf(".");

                for (int i = 0; i < nums.Length; i++)
                {
                    //int res = m.CompareTo(nums[i].ToString());
                    if (i < atIndex)
                    {
                        bool result = mail.Contains(pointIndex.ToString());
                        if (atIndex - 1 < atIndex)
                        {
                            Console.WriteLine(new String('-', 30));
                            Console.WriteLine($"FirstName:{mail.Substring(0, pointIndex)}");
                            Console.WriteLine($"LastName:{mail.Substring(pointIndex)}");
                            Console.WriteLine($"Mail:{mail}");
                            Console.WriteLine($"Domain:{mail.Split('@')}");
                            Console.WriteLine($"Extension:{mail.Substring(mail.LastIndexOf(".") + 1)}");
                        }
                    }
                    
                }
            }
        }
    }
}