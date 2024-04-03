using System;

public struct RejestrNazw
{
    public DateTime DataModyfikacji { get; set; }
    public string Nazwa { get; set; }

    public RejestrNazw(string nazwa, DateTime dataMod) {
        DataModyfikacji= dataMod;
        Nazwa = nazwa;
    }
    public override string ToString()
    {
        return $"Data: {DataModyfikacji:dd.MM.yyyy HH:mm:ss} - Nazwa: {Nazwa}";
    }
}