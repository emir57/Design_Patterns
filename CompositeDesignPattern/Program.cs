namespace CompositeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Commander general = new Commander("Emir", Rank.General);
            general.AddSoldier(new BuckPrivate("Müslüm",Rank.Colonel));
            general.AddSoldier(new BuckPrivate("Orhan",Rank.Colonel));

            Commander albay = new Commander("Hilmi", Rank.Major);
            Commander yarbay = new Commander("Cavit", Rank.LieutenantColonel);

            yarbay.AddSoldier(new BuckPrivate("Murat",Rank.Major));
            yarbay.AddSoldier(new BuckPrivate("Kaan",Rank.Major));
            albay.AddSoldier(yarbay);
            albay.AddSoldier(new BuckPrivate("Mustafa", Rank.LieutenantColonel));
            general.ExecuteOrder();
        }
    }
}
