using System;
using System.Globalization;
using System.Threading;

public static class CreateCul
{
    public static void Create()
    {
        // Create a custom culture for ru-US.
        CultureAndRegionInfoBuilder culAndReg = new CultureAndRegionInfoBuilder("en-HU",
                                               CultureAndRegionModifiers.None);
        culAndReg.LoadDataFromCultureInfo(CultureInfo.CreateSpecificCulture("en-HU"));
        culAndReg.LoadDataFromRegionInfo(new RegionInfo("HU"));

        culAndReg.CultureEnglishName = "English(Hungary)";
        culAndReg.CultureNativeName = "English(Hungary)";
        culAndReg.CurrencyNativeName = "Hungarian Forint";
        culAndReg.RegionNativeName = "Hungarian-English";

        // Register the culture.
        try
        {
            culAndReg.Register();
            Console.Write("The new Culture and region is created for {0} :" + "en-HU");
        }
        catch (InvalidOperationException ex)
        {
            Console.Write("The Operation Failed due to " + ex.Message);
        }   

       
    }
}
