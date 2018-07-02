namespace Madlibs.Models
{
  public class MadlibVariable
  {
    private string _personOne;
    private string _personTwo;
    private string _placeOne;
    private string _object;
    private string _animal;
    private string _exclamation;
    private string _activity;
    private string _placeTwo;

    public string GetPersonOne()
    {
        return _personOne;
    }
    public void SetPersonOne(string newPersonOne)
    {
        _personOne = newPersonOne;
    }
    public string GetPersonTwo()
    {
        return _personTwo;
    }
    public void SetPersonTwo(string newPersonTwo)
    {
        _personTwo = newPersonTwo;
    }
    public string GetPlaceOne()
    {
        return _placeOne;
    }
    public void SetPlaceOne(string newPlaceOne)
    {
        _placeOne = newPlaceOne;
    }public string GetObject()
    {
        return _object;
    }
    public void SetObject(string newObject)
    {
        _object = newObject;
    }
    public string GetAnimal()
    {
        return _animal;
    }
    public void SetAnimal(string newanimal)
    {
        _animal = newAnimal;
    }
    public string GetExclamation()
    {
        return _exclamation;
    }
    public void SetExclamation(string newExclamation)
    {
        _exclamation = newExclamation;
    }
    public string GetActivity()
    {
        return _activity;
    }
    public void SetActivity(string newActivity)
    {
        _activity = newActivity;
    }
    public string GetPlaceTwo()
    {
        return _placeTwo;
    }
    public void SetPlaceTwo(string newPlaceTwo)
    {
        _placeTwo = newPlaceTwo;
    }
  }
}
