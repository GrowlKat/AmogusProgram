namespace AmogusProgram
{
    internal static class Program
    {
        /// <summary>
        /// Your meme program starts here
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}