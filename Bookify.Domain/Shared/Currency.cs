namespace Bookify.Domain.Shared;

public record Currency
{
    internal static readonly Currency None = new Currency("None");
    public static readonly Currency USD = new Currency("USD");
    public static readonly Currency EUR = new Currency("EUR");

    private Currency(string code) => Code = code;

    private string Code { get; init; }

    public static Currency FromCode(string code)
    {
        return AllCurrencies.FirstOrDefault(c => c.Code == code) ??
            throw new ArgumentException($"Invalid currency code: {code}");
       
    }

    public static readonly IReadOnlyCollection<Currency> AllCurrencies = new List<Currency> { USD, EUR }.AsReadOnly();
}
