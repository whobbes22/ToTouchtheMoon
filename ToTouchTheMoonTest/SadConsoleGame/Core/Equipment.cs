namespace TTtMGame.Core
{
  public class Equipment
  {
    private char Symbol;
    public Equipment()
    {
      Symbol = ']';
    }

    public int Attack {get;set;}
    public int Defense{get;set;}
    public string Name {get;set;}
    public int Health {get;set;}
  }
}