namespace Packt.CloudySkiesAir.Chapter2;

public class BaggageCalculator {
  private const decimal FirstBagFee = 40M;
  private const decimal ExtraBagFee = 50M;
  private const decimal CarryOnFee = 30M;

  public decimal HolidayFeePercent { get; set; } = 0.1M;

  public decimal CalculatePrice(int bags,
    int carryOn, int passengers, bool isHoliday) {

    decimal total = 0;

    if (carryOn > 0) {
      decimal carryOnFee = carryOn * CarryOnFee;
      Console.WriteLine($"Carry-on: {carryOnFee}");
      total += carryOnFee;
    }

    if (bags > 0) {
      decimal checkedFee = ApplyCheckedFee(bags, passengers);
      Console.WriteLine($"Checked: {checkedFee}");
      total += checkedFee;
    }

    if (isHoliday) {
      Console.WriteLine("Holiday Fee: " +
        (total * HolidayFeePercent));

      total += total * HolidayFeePercent;
    }

    return total;
  }

  private static decimal ApplyCheckedFee(int bags, int passengers) {
    if (bags <= passengers) {
      decimal firstBaggageFee = bags * FirstBagFee;
      return firstBaggageFee;
    } else {
      decimal firstBagFee = passengers * FirstBagFee;
      decimal extraBagFee = (bags - passengers) * ExtraBagFee;
      decimal checkedFee = firstBagFee + extraBagFee;
      return checkedFee;
    }
  }
}
