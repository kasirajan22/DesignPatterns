namespace AdapterMethodDP;

public class Adapter : ILegacyService
{
    //private readonly LegacyService legacyService;
    private readonly NewService newService;

    public Adapter(NewService _newService)
    {
        this.newService = _newService;
    }

    // public Adapter(LegacyService _legacyService)
    // {
    //     this.legacyService = _legacyService;
    // }

    public void LegacyRequest()
    {
        //legacyService.LegacyRequest();
        newService.NewRequest();
    }
}