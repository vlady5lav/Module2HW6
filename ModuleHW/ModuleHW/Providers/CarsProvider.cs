namespace ModuleHW
{
    public class CarsProvider : ICarsProvider
    {
        public CarsProvider()
        {
            Init();
        }

        public Car[] AllCars { get; private set; }

        private void Init()
        {
            AllCars = new Car[]
            {
                new JaguarIPaceEM(),
                new PorscheTaycanEM(),
                new NissanLeafEM(),
                new HyundaiIonicEM(),
                new TeslaModelSEM(),
                new ToyotaRAV4Hybrid(),
                new JaguarEPace(),
                new JaguarFPace(),
                new JaguarFType(),
                new JaguarXE(),
                new JaguarXF(),
                new CheryAmulet(),
                new CheryTiggo(),
                new GeelyEmgrand(),
                new GeelyMK(),
                new SkodaOctavia(),
                new SkodaSuperb(),
                new CitroenC4(),
                new Peugeot308(),
                new RenaultLogan(),
                new AudiA5(),
                new BMW520d(),
                new FiatDoblo(),
                new MitsubishiLancer(),
                new ToyotaPrius(),
                new HyundaiAccent(),
                new KiaOptima(),
                new ChevroletAveo(),
                new FordFocus(),
            };
        }
    }
}
