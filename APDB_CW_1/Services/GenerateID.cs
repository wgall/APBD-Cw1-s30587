namespace APDB_CW_1.Services;

public class GenerateID
{
    public static string generate(int length)
    {
        if (length > 0)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();

            string result = new string("");

            int counter = 0;

            while (counter < length)
            {
                result += random.Next(chars.Length).ToString();
                counter++;
            }

            return result;
        }
        else
        {
            throw new Exception("Invalid ID length");
        }
    }
}