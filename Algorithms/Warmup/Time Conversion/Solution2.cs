namespace  Solution2{
    class Solution2
    {
        /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s) {
      var Time=DateTime.Parse(s);
      var Hour=Time.Hour.ToString().Length<2?$"0{Time.Hour.ToString()}":$"{Time.Hour.ToString()}";
      var Minute=Time.Minute.ToString().Length<2?$"0{Time.Minute.ToString()}":$"{Time.Minute.ToString()}";
      var Second=Time.Second.ToString().Length<2?$"0{Time.Second.ToString()}":$"{Time.Second.ToString()}";
        string returnVal=$"{Hour}:{Minute}:{Second}";
        return returnVal;
    }
    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
