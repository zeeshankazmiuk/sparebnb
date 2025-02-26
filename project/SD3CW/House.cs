﻿// Zeeshan Kazmi
// KAZ22527866

// Subclass House created
public class House : Accommodation
{
    private int floorCount;
    private int bedroomCount;
    private int bathroomCount;
    private bool hasGarden;

    // Constructor includes base attributes inherited from Accommodation
    public House(string name, string address, int doorNum, decimal price, int occupantCapacity, bool isBooked, int floorCount, int bedroomCount, int bathroomCount, bool hasGarden)
        : base(name, address, doorNum, price, occupantCapacity, isBooked)
    {
        this.floorCount = floorCount;
        this.bedroomCount = bedroomCount;
        this.bathroomCount = bathroomCount;
        this.hasGarden = hasGarden;
    }

    // Overide Print method to print details specific to House
    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Number of Floors: {floorCount}");
        Console.WriteLine($"Bedroom Count: {bedroomCount}");
        Console.WriteLine($"Bathroom Count: {bathroomCount}");
        Console.WriteLine($"Has Garden: {hasGarden} \n\n");
    }
}



