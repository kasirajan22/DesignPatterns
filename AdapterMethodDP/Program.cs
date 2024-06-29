
using AdapterMethodDP;

class Program
{
    static void Main()
    {
        NewService newService = new NewService();
        //LegacyService legacyService = new LegacyService();
        ILegacyService legacyServiceAdapter = new Adapter(newService);
 
        // Client invokes LegacyRequest without knowing about NewService
        legacyServiceAdapter.LegacyRequest();
    }
}