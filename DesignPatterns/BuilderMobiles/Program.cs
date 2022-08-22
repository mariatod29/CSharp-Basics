using System;
using BuilderMobiles;

namespace BuilderMobiles
{
    public class Program
    {
        public static void Main()
        {
            IBuildMobile apple = new Apple();
            Mobile firstMobile = new Mobile(apple);
            firstMobile.AssembleMobile();
            Console.WriteLine($" Model Name: {firstMobile.GetMobile().ModelName}\n Display resolution: {firstMobile.GetMobile().DisplayResolution} \n RAM: {firstMobile.GetMobile().RAM} GB\n ROM: {firstMobile.GetMobile().ROM} GB \n Processor: {firstMobile.GetMobile().Processor}");

            Console.WriteLine();

            IBuildMobile onePlus = new OnePlus();
            Mobile secondMobile = new Mobile(onePlus);
            secondMobile.AssembleMobile();
            Console.WriteLine($" Model Name: {secondMobile.GetMobile().ModelName}\n Display resolution: {secondMobile.GetMobile().DisplayResolution} \n RAM: {secondMobile.GetMobile().RAM} GB\n ROM: {secondMobile.GetMobile().ROM} GB \n Processor: {secondMobile.GetMobile().Processor}");
        
        }
    }
}