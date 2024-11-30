using CSharpFunctionalExtensions;

namespace MegaProject.Dtos;

public class PurchaseDto
{
    public DateTime DateOfPurchase { get; set; } 
    public DateTime DeliveryDate { get; set; } 
    public int PurchaseQuantity { get; set; } 

    public int MaterialId { get; set; }
}