using Assignment1_Enterprise_MVC.Models;

public class Repository
{
    private static int _nextId = 1;
    private static List<EquipmentRequest> Request = new List<EquipmentRequest>();

    private static List<EquipmentItem> Equipment = new List<EquipmentItem>()
    {
        new() { Id = 1, Type = EquipmentType.Laptop, Description = "Dell Latitude 5440, 16GB RAM", IsAvailable = true },
        new() { Id = 2, Type = EquipmentType.Laptop, Description = "MacBook Pro M3", IsAvailable = false },
        new() { Id = 3, Type = EquipmentType.Phone, Description = "iPhone 13 (testing device)", IsAvailable = true },
        new() { Id = 4, Type = EquipmentType.Phone, Description = "Samsung Galaxy S22", IsAvailable = false },
        new() { Id = 5, Type = EquipmentType.Tablet, Description = "iPad 10th gen", IsAvailable = true },
        new() { Id = 6, Type = EquipmentType.Another, Description = "Logitech HD webcam", IsAvailable = true },
        new() { Id = 7, Type = EquipmentType.Another, Description = "Portable projector", IsAvailable = false },
    };
    
    public static IEnumerable<EquipmentRequest> Requests => Request;
    public static IEnumerable<EquipmentItem> AllEquipment => Equipment;
    public static IEnumerable<EquipmentItem> AvailableEquipment => Equipment.Where(e => e.IsAvailable);
    
    public static void AddRequest(EquipmentRequest request)
    {
        request.Id = _nextId++;
        Request.Add(request);
    }
}
