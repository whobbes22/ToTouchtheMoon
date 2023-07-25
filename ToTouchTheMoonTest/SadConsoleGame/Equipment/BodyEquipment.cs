namespace TTtMGame.Equipment
{
  public class BodyEquipment : Core.Equipment
  {
    public static BodyEquipment None()
    {
      return new BodyEquipment{ Name = "None"};
    }
  }
}