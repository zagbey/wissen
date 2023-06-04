/*
 * Havale   10000 liraya kadar 4TL, üstünde 10TL
 * Eft      10000 liraya kadar 4TL, üstünde 10TL
 * Fast     Hep %1
 */

//// AbstractFactory Pattern
//var moneyTransfer = MoneyTransfer.Create("TR2937923", "TR9865986");

using VirrtualReloaded;

var eft1 = new Eft()
{
    SenderIban = "TR2934729346298342",
    ReceiverIban = "TR29384709238647834",
    Amount = 4000,
    Description = "Borç ödemesi"
};

var eft2 = new Eft()
{
    SenderIban = "TR89457864",
    ReceiverIban = "TR574658734",
    Amount = 25000,
    Description = ""
};

var bankwire1 = new BankWire()
{
    SenderIban = "TR682734823",
    ReceiverIban = "TR12987986734",
    Amount = 12000,
    Description = null
};

var fast1 = new Fast()
{
    SenderIban = "TR82734823",
    ReceiverIban = "TR2987986734",
    Amount = 25000
};

var fast2 = new Fast()
{
    SenderIban = "***********",
    ReceiverIban = "SA3979579485",
    Amount = 450000000,
    Description = "Benzema ödemesi"
};

var moneyTransferList = new List<MoneyTransfer>()
{
    eft1,
    eft2,
    bankwire1,
    fast1,
    fast2
};

// Console.WriteLine($"1. EFT Tutarı: {eft1.Amount} / Ücreti: {eft1.Fee}");
// Console.WriteLine($"2. EFT Tutarı: {eft2.Amount} / Ücreti: {eft2.Fee}");
// Console.WriteLine($"1. Havale Tutarı: {bankwire1.Amount} / Ücreti: {bankwire1.Fee}");
// Console.WriteLine($"1. Fast Tutarı: {fast1.Amount} / Ücreti: {fast1.Fee}");
// Console.WriteLine($"2. Fast Tutarı: {fast2.Amount.ToString("N")} / Ücreti: {fast2.Fee}");

// Dizilerde olduğu gibi listelerde de index'inci elemana erişebilirsiniz
for (int i = 0; i < moneyTransferList.Count; i++)
{
    Console.WriteLine(moneyTransferList[i].Description);
}