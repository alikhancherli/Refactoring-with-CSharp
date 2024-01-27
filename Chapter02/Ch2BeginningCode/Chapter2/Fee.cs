namespace Packt.CloudySkiesAir.Chapter2;

public class Fee {
  public decimal Total { get; set; }

  public void ChargeBaggageFee(decimal fee, string chargeName) {
    Console.WriteLine($"{chargeName} Fee: {fee}");
    Total += fee;
  }
}
